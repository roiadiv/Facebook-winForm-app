using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "321132011665053";
        private static readonly string[] sr_FacebookPermissions =
        {
                "public_profile",
                "user_about_me",
                "user_friends",
                "user_events",
                "user_likes",
                "user_photos",
                "user_posts",
        };

        private readonly BindingList<UserFriendsWrapper> r_UserFriends = new BindingList<UserFriendsWrapper>();
        private readonly BindingList<LikesPagesWrapper> r_LikedPages = new BindingList<LikesPagesWrapper>();
        private readonly BindingList<PostsAdapter> r_PostsAdapter = new BindingList<PostsAdapter>();
        private readonly List<string> r_CheckedDecoratorFeatures = new List<string>();
        private readonly List<Album> r_Albums = new List<Album>();
        private readonly List<string> r_ComboBoxPostsSource = new List<string>();
        private readonly Dictionary<string, PictureBoxProxy> r_ItemsToBlend = new Dictionary<string, PictureBoxProxy>();
        private User m_LoggedInUser = null;
        private AppSettings m_AppSettings = new AppSettings();
        private object m_ObjLockAddToTreeNode = new object();

        public FormMain()
        {
            InitializeComponent();
        }

        public IPostStrategy FilterPostStrategy { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            comboBoxFbFeatures.DataSource = Enum.GetValues(typeof(eFbFeatures));
            foreach (var property in typeof(IPosts).GetProperties())
            {
                r_ComboBoxPostsSource.Add(property.Name);
            }

            comboBoxPosts.DataSource = r_ComboBoxPostsSource;
            m_AppSettings = AppSettings.LoadFromFile();
            if (!string.IsNullOrEmpty(m_AppSettings.LastAccessToken) && m_AppSettings.RememberUser)
            {
                new Thread(connectToFacebook).Start();
            }
            else
            {
                this.performLogin();
            }
        }

        private void connectToFacebook()
        {
            LoginResult result = FacebookService.Connect(m_AppSettings.LastAccessToken);
            m_LoggedInUser = result.LoggedInUser;
            this.loginUser();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FacebookService.Logout(performLogout);
            base.OnFormClosing(e);
        }

        private void loginUser()
        {
            enableControls();
            dataGridViewLikedPages.Invoke(new Action(() => dataGridViewLikedPages.DataSource = r_LikedPages));
            dataGridViewFriends.Invoke(new Action(() => dataGridViewFriends.DataSource = r_UserFriends));
            dataGridViewPosts.Invoke(new Action(() => dataGridViewPosts.DataSource = r_PostsAdapter));
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelUserName.Invoke(new Action(() => labelUserName.Text = m_LoggedInUser.Name));
            startFacebookAppFeatures();
        }

        private void enableControls()
        {
            this.labelPicture.Hide();
            this.labelProfile.Hide();
            this.buttonLogin.Image = global::Facebook_app.Properties.Resources.Logout;
            comboBoxFbFeatures.Invoke(new Action(() => comboBoxFbFeatures.Enabled = true));
            textBoxStatus.Invoke(new Action(() => textBoxStatus.Enabled = true));
            buttonFeature.Invoke(new Action(() => buttonFeature.Enabled = true));
            checkBoxRememberUser.Invoke(new Action(() => checkBoxRememberUser.Enabled = true));
            buttonPostKeywordSearch.Invoke(new Action(() => buttonPostKeywordSearch.Enabled = true));
            searchTextBox.Invoke(new Action(() => searchTextBox.Enabled = true));
        }

        private void startFacebookAppFeatures()
        {
            new Thread(fetchPosts).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchPages).Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                performLogin();
            }
            else
            {
                FacebookService.Logout(performLogout);
            }
        }

        private void performLogin()
        {
            LoginResult result = FacebookService.Login(k_AppId, sr_FacebookPermissions);
            if (result.AccessToken != null)
            {
                m_LoggedInUser = result.LoggedInUser;
                this.loginUser();
            }
        }

        private void performLogout()
        {
            disableControls();
            validateDataSourcesFeatures();
            labelPicture.Show();
            labelProfile.Show();
            dataGridViewFriends.DataSource = null;
            dataGridViewLikedPages.DataSource = null;
            dataGridViewPosts.DataSource = null;
            pictureBoxOfAlbum.Image = null;
            m_LoggedInUser = null;
            picture_smallPictureBox.Image = null;
            labelUserName.Text = "Guest";
            textBoxStatus.Clear();
            treeViewAlbums.Nodes.Clear();
            buttonLogin.Image = global::Facebook_app.Properties.Resources.LogInButton;
            saveSettings();
        }

        private void validateDataSourcesFeatures()
        {
            if (checkBoxRememberUser.Checked == false)
            {
                r_PostsAdapter.Clear();
                r_LikedPages.Clear();
                r_UserFriends.Clear();
            }
        }

        private void saveSettings()
        {
            if (checkBoxRememberUser.Checked == true)
            {
                m_AppSettings.RememberUser = true;
            }
            else
            {
                m_AppSettings.RememberUser = false;
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void disableControls()
        {
            comboBoxFbFeatures.Enabled = false;
            buttonFeature.Enabled = false;
            checkBoxRememberUser.Enabled = false;
            buttonSetStatus.Enabled = false;
            buttonPostKeywordSearch.Enabled = false;
            searchTextBox.Enabled = false;
            textBoxStatus.Enabled = false;
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            performPostStatus();
        }

        private void performPostStatus()
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void textBoxStatus_textChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxStatus.Text))
            {
                buttonSetStatus.Enabled = true;
            }
            else
            {
                buttonSetStatus.Enabled = false;
            }
        }

        private void fetchPosts()
        {
            buttonPostKeywordSearch.Invoke(new Action(() => buttonPostKeywordSearch.Enabled = false));

            if (m_LoggedInUser.Posts.Count != r_PostsAdapter.Count)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Type == Post.eType.status && !string.IsNullOrEmpty(post.Message))
                    {
                        dataGridViewPosts.Invoke(new Action(() => r_PostsAdapter.Add(new PostsAdapter(post))));
                    }
                }

                dataGridViewPosts.Invoke(new Action(() => dataGridViewPosts.Refresh()));
            }

            buttonPostKeywordSearch.Invoke(new Action(() => buttonPostKeywordSearch.Enabled = true));
        }

        private void tabPageAlbums_Clicked(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == this.tabControl1.Controls.IndexOf(tabPageAlbums))
            {
                this.ClientSize = new System.Drawing.Size(839, 280);
            }

            if (this.tabControl1.SelectedIndex == this.tabControl1.Controls.IndexOf(General))
            {
                this.ClientSize = new System.Drawing.Size(821, 520);
            }

            if (treeViewAlbums.Nodes.Count == 0 && m_LoggedInUser != null)
            {
                createAlbumsTreeView();
            }

            if (panelColorType.Controls.Count == 0 && m_LoggedInUser != null)
            {
                createDecoratorColorType(new eColorTypes(), panelColorType);
                createDecoratorColorType(new eThugLifeItems(), panelThugLife);
            }
        }

        private void createDecoratorColorType(Enum enumType, Panel controller)
        {
            int i = 0;

            foreach (string decoratorToAdd in Enum.GetNames(enumType.GetType()))
            {
                CheckBox newCheckBox = new CheckBox();
                newCheckBox.Name = decoratorToAdd;
                newCheckBox.Text = decoratorToAdd;
                newCheckBox.Checked = false;
                controller.Controls.Add(newCheckBox);
                newCheckBox.Location = new Point(5, 5 + i);
                newCheckBox.CheckedChanged += checkBox_CheckedChanged; 
                i += 20;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox selectedCheckBox = sender as CheckBox;
            if (selectedCheckBox.Checked == true)
            {
                buttonStartDecorate.Enabled = true;
                r_CheckedDecoratorFeatures.Add(selectedCheckBox.Text);
                if (selectedCheckBox.Parent == panelThugLife)
                {
                    eThugLifeItems thugLifeItem;
                    Enum.TryParse(selectedCheckBox.Text, out thugLifeItem);
                    switch (thugLifeItem)
                    {
                        case eThugLifeItems.Hat:
                            PictureBoxProxy hatPhoto = new PictureBoxProxy();
                            hatPhoto.Location = pictureBoxEditPhoto.Location;
                            hatPhoto.Name = "Hat";
                            hatPhoto.Image = global::Facebook_app.Properties.Resources.Thug_Life_Black_Hat_PNG;
                            hatPhoto.Size = hatPhoto.Image.Size;
                            hatPhoto.Parent = pictureBoxEditPhoto;
                            hatPhoto.BackColor = Color.Transparent;
                            hatPhoto.MouseDown += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    hatPhoto.ImageFirstPoint = Control.MousePosition;
                                }
                            };

                            hatPhoto.MouseMove += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    Point tempPointToDrag = Control.MousePosition;
                                    Point reLocation = new Point(hatPhoto.ImageFirstPoint.X - tempPointToDrag.X, hatPhoto.ImageFirstPoint.Y - tempPointToDrag.Y);
                                    hatPhoto.Location = new Point(hatPhoto.Location.X - reLocation.X, hatPhoto.Location.Y - reLocation.Y);
                                    hatPhoto.ImageFirstPoint = tempPointToDrag;
                                }
                            };

                            r_ItemsToBlend.Add(hatPhoto.Name, hatPhoto);
                            pictureBoxEditPhoto.Controls.Add(hatPhoto);
                            break;

                        case eThugLifeItems.Necklace:
                            PictureBoxProxy necklacePhoto = new PictureBoxProxy();
                            necklacePhoto.Location = pictureBoxEditPhoto.Location;
                            necklacePhoto.Name = "Necklace";
                            necklacePhoto.Parent = pictureBoxEditPhoto;
                            necklacePhoto.BackColor = Color.Transparent;
                            necklacePhoto.Image = global::Facebook_app.Properties.Resources.Thug_Life_Gold_Chain1;
                            necklacePhoto.Size = necklacePhoto.Image.Size;
                            necklacePhoto.MouseDown += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    necklacePhoto.ImageFirstPoint = Control.MousePosition;
                                }
                            };

                            necklacePhoto.MouseMove += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    Point tempPointToDrag = Control.MousePosition;
                                    Point reLoction = new Point(necklacePhoto.ImageFirstPoint.X - tempPointToDrag.X, necklacePhoto.ImageFirstPoint.Y - tempPointToDrag.Y);
                                    necklacePhoto.Location = new Point(necklacePhoto.Location.X - reLoction.X, necklacePhoto.Location.Y - reLoction.Y);
                                    necklacePhoto.ImageFirstPoint = tempPointToDrag;
                                }
                            };

                            r_ItemsToBlend.Add(necklacePhoto.Name, necklacePhoto);
                            pictureBoxEditPhoto.Controls.Add(necklacePhoto);
                            break;

                        case eThugLifeItems.Joint:
                            PictureBoxProxy jointPhoto = new PictureBoxProxy();
                            jointPhoto.Location = pictureBoxEditPhoto.Location;
                            jointPhoto.Name = "Joint";
                            jointPhoto.Image = global::Facebook_app.Properties.Resources.thugLifeJoint;
                            jointPhoto.Size = jointPhoto.Image.Size;
                            jointPhoto.Parent = pictureBoxEditPhoto;
                            jointPhoto.BackColor = Color.Transparent;
                            jointPhoto.MouseDown += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    jointPhoto.ImageFirstPoint = Control.MousePosition;
                                }
                            };

                            jointPhoto.MouseMove += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    Point tempPointToDrag = Control.MousePosition;
                                    Point reLoaction = new Point(jointPhoto.ImageFirstPoint.X - tempPointToDrag.X, jointPhoto.ImageFirstPoint.Y - tempPointToDrag.Y);
                                    jointPhoto.Location = new Point(jointPhoto.Location.X - reLoaction.X, jointPhoto.Location.Y - reLoaction.Y);
                                    jointPhoto.ImageFirstPoint = tempPointToDrag;
                                }
                            };

                            r_ItemsToBlend.Add(jointPhoto.Name, jointPhoto);
                            pictureBoxEditPhoto.Controls.Add(jointPhoto);
                            break;

                        case eThugLifeItems.Glasses:
                            PictureBoxProxy glassesPhoto = new PictureBoxProxy();
                            glassesPhoto.Location = pictureBoxEditPhoto.Location;
                            glassesPhoto.Name = "Glasses";
                            glassesPhoto.Image = global::Facebook_app.Properties.Resources.Thug_Life_Cool_Glasse1;
                            glassesPhoto.Size = glassesPhoto.Image.Size;
                            glassesPhoto.Parent = pictureBoxEditPhoto;
                            glassesPhoto.BackColor = Color.Transparent;
                            glassesPhoto.MouseDown += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    glassesPhoto.ImageFirstPoint = Control.MousePosition;
                                }
                            };

                            glassesPhoto.MouseMove += (ss, mouseEvent) =>
                            {
                                if (mouseEvent.Button == MouseButtons.Left)
                                {
                                    Point tempPointToDrag = Control.MousePosition;
                                    Point reLoaction = new Point(glassesPhoto.ImageFirstPoint.X - tempPointToDrag.X, glassesPhoto.ImageFirstPoint.Y - tempPointToDrag.Y);
                                    glassesPhoto.Location = new Point(glassesPhoto.Location.X - reLoaction.X, glassesPhoto.Location.Y - reLoaction.Y);
                                    glassesPhoto.ImageFirstPoint = tempPointToDrag;
                                }
                            };

                            r_ItemsToBlend.Add(glassesPhoto.Name, glassesPhoto);
                            pictureBoxEditPhoto.Controls.Add(glassesPhoto);
                            break;
                    }
                }
            }
            else
            {
                r_CheckedDecoratorFeatures.Remove(selectedCheckBox.Text);
                r_ItemsToBlend.Remove(selectedCheckBox.Text);
                if (selectedCheckBox.Parent == panelThugLife)
                {
                    pictureBoxEditPhoto.Controls.RemoveByKey(selectedCheckBox.Text);
                }
                        
               if (r_CheckedDecoratorFeatures.Count == 0)
                {
                    buttonStartDecorate.Enabled = false;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != string.Empty)
            {
                r_PostsAdapter.Clear();
                new Thread(performFilterPosts).Start();
            }
        }

         private void performFilterPosts()
        {
            buttonPostKeywordSearch.Invoke(new Action(() => buttonPostKeywordSearch.Enabled = false));
            FilterPostStrategy = PostStrategyFactory.CreatePostStrategy(comboBoxPosts.SelectedItem.ToString());

            foreach (Post post in m_LoggedInUser.WallPosts)
            {
                if (post.Type == Post.eType.status && !string.IsNullOrEmpty(post.Message))
                {
                    if (FilterPostStrategy.FilterPosts(post).ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        dataGridViewPosts.Invoke(new Action(() => r_PostsAdapter.Add(new PostsAdapter(post))));
                    }
                }
            }

            dataGridViewPosts.Invoke(new Action(() => dataGridViewPosts.Refresh()));
            buttonPostKeywordSearch.Invoke(new Action(() => buttonPostKeywordSearch.Enabled = true));
        }

        private void searchTextBox_textChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                r_PostsAdapter.Clear();
                fetchPosts();
            }
        }

        private void fetchPages()
        {
            if (m_LoggedInUser.LikedPages.Count != r_LikedPages.Count)
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    dataGridViewLikedPages.Invoke(new Action(() => r_LikedPages.Add(new LikesPagesWrapper(page))));
                }

                dataGridViewLikedPages.Invoke(new Action(() => dataGridViewLikedPages.Refresh()));
            }
        }

        private void fetchFriends()
        {
            if (m_LoggedInUser.Friends.Count != r_UserFriends.Count)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    dataGridViewFriends.Invoke(new Action(() => r_UserFriends.Add(new UserFriendsWrapper(friend))));
                }
            }

            dataGridViewFriends.Invoke(new Action(() => dataGridViewFriends.Refresh()));
        }

        private void buttonFeature_Click(object sender, EventArgs e)
        {
            eFbFeatures fetchFormToCreate = (eFbFeatures)comboBoxFbFeatures.SelectedItem;
            Form fetchForm = FetchFactory.CreateFetchForm(fetchFormToCreate, m_LoggedInUser);
            fetchForm.ShowDialog();
        }

        private void treeViewAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNodeWrapper selectedNode = treeViewAlbums.SelectedNode as TreeNodeWrapper;
            if (selectedNode.Node is PhotoComponent)
            {
                PhotoComponent photoComponentToLoad = selectedNode.Node as PhotoComponent;
                pictureBoxOfAlbum.Image = photoComponentToLoad.Image;
                pictureBoxOfAlbum.ImageName = photoComponentToLoad.ItemName;
                buttonEditPhoto.Enabled = true;
            }
            else
            {
                textBoxAddPhoto.Text = treeViewAlbums.SelectedNode.Text;
            }
        }

        private void createAlbumsTreeView()
        {
            int i = 0;
            PhotoComposite root = new PhotoComposite("Facebook User Albums");
            treeViewAlbums.Nodes.Add(root.Node = new TreeNodeWrapper(root.ItemName, root));
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (!(album.Photos.Count == 0))
                {
                    r_Albums.Add(album);
                    PhotoComposite subAlbum = new PhotoComposite(album.Name);
                    treeViewAlbums.Nodes[0].Nodes.Add(subAlbum.Node = new TreeNodeWrapper(subAlbum.ItemName, subAlbum));
                    new Thread(() =>
                    {
                        lock (m_ObjLockAddToTreeNode)
                        {
                            foreach (Photo photo in r_Albums[i].Photos)
                            {
                                PhotoComponent photoComponent = new PhotoComponent(photo.Name, photo.ImageNormal);
                                treeViewAlbums.Invoke(new Action(() => treeViewAlbums.Nodes[0].Nodes[i].Nodes.Add(photoComponent.Node = new TreeNodeWrapper(photoComponent.ItemName, photoComponent))));
                            }
                        }

                        i++;
                    }).Start();
                }
            }
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            TreeNodeWrapper selectedNode = treeViewAlbums.SelectedNode as TreeNodeWrapper;
            PhotoComposite albumToAdd = new PhotoComposite(textBoxFolderName.Text);

            if (selectedNode.Node is PhotoComposite)
            {
                (selectedNode.Node as PhotoComposite).OnPhotoComponentAdded(albumToAdd);
            }
            else if (selectedNode.Node is PhotoComponent)
            {
                (selectedNode.Node as PhotoComponent).OnPhotoComponentAdded(albumToAdd);
            }
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            TreeNodeWrapper selectedNode = treeViewAlbums.SelectedNode as TreeNodeWrapper;
            PhotoComponent imageToAdd = new PhotoComponent(pictureBoxOfAlbum.ImageName, pictureBoxOfAlbum.Image);

            if (selectedNode.Node is PhotoComposite)
            {
                if (pictureBoxOfAlbum.Image != null)
                {
                    (selectedNode.Node as PhotoComposite).OnPhotoComponentAdded(imageToAdd);
                }
            }
            else
            {
                (selectedNode.Node as PhotoComponent).OnPhotoComponentAdded(imageToAdd);
            }
        }

        private void buttonDeletePhotoComponent_Click(object sender, EventArgs e)
        {
            TreeNodeWrapper selectedNode = treeViewAlbums.SelectedNode as TreeNodeWrapper;
            PhotoComposite photoComponentToRemove = new PhotoComposite(textBoxFolderName.Text);
            photoComponentToRemove.Node = selectedNode;

            if (selectedNode.Node is PhotoComposite)
            {
                (selectedNode.Node as PhotoComposite).OnPhotoComponentRemoved(photoComponentToRemove);
            }
            else
            {
                (selectedNode.Node as PhotoComponent).OnPhotoComponentRemoved(photoComponentToRemove);
            }

            pictureBoxOfAlbum.Image = null;
        }

        private void buttonEditPhoto_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == this.tabControl1.Controls.IndexOf(tabPageAlbums))
            {
                this.ClientSize = new System.Drawing.Size(836, 605);
            }

            Bitmap strechPhoto = new Bitmap(pictureBoxEditPhoto.Width, pictureBoxEditPhoto.Height);
            using (Graphics g = Graphics.FromImage(strechPhoto))
            {
                g.DrawImage(pictureBoxOfAlbum.Image, 0, 0, pictureBoxEditPhoto.Width, pictureBoxEditPhoto.Height);
            }

            pictureBoxEditPhoto.BackgroundImage = strechPhoto;
        }

        private void buttonStartDecorate_Click(object sender, EventArgs e)
        {
            IPhotoComponent photoComponentToDecorate = new PhotoComponent(pictureBoxEditPhoto.Name, pictureBoxEditPhoto.BackgroundImage);
            Image imageToDecorate = null;
            List<object> items = new List<object>();
            items.Add(photoComponentToDecorate);
            foreach (string fetchDecorator in r_CheckedDecoratorFeatures)
            {
                string name = string.Format("C17_Ex03_Ben_304815616_Roy_203055892.{0}", fetchDecorator);
                Type type = Type.GetType(name);
                if (type.BaseType == typeof(ThugLifeDecorator))
                {
                    items.Add(r_ItemsToBlend[fetchDecorator]);
                }

                object instance = Activator.CreateInstance(type, items.ToArray());
                imageToDecorate = (instance as PhotoDecorator).PhotoComponent;
                if (items.Count != 1)
                {
                    items.Remove(r_ItemsToBlend[fetchDecorator]);
                }
            }

            foreach (CheckBox checkBox in panelThugLife.Controls)
            {
                if (checkBox.Checked == true)
                {
                    r_ComboBoxPostsSource.Remove(checkBox.Text);
                    pictureBoxEditPhoto.Controls.RemoveByKey(checkBox.Text);
                    checkBox.Checked = false;
                }
            }

            pictureBoxEditPhoto.BackgroundImage = imageToDecorate;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Bitmap strechPhoto = new Bitmap(pictureBoxEditPhoto.Width, pictureBoxEditPhoto.Height);
            using (Graphics graphics = Graphics.FromImage(strechPhoto))
            {
                graphics.DrawImage(pictureBoxOfAlbum.Image, 0, 0, pictureBoxEditPhoto.Width, pictureBoxEditPhoto.Height);
            }

            pictureBoxEditPhoto.BackgroundImage = strechPhoto;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            PhotoComposite root;
            if (treeViewAlbums.Nodes.Count == 1)
            {
                root = new PhotoComposite("Edit Facebook User Photos");
                treeViewAlbums.Nodes.Add(root.Node = new TreeNodeWrapper(root.ItemName, root));
            }

            PhotoComponent photoComponent = new PhotoComponent(pictureBoxOfAlbum.Name, pictureBoxEditPhoto.BackgroundImage);
            treeViewAlbums.Nodes[1].Nodes.Add(photoComponent.Node = new TreeNodeWrapper(photoComponent.ItemName, photoComponent));
        }

        private void buttonPostPhoto_Click(object sender, EventArgs e)
        {
            m_LoggedInUser.PostPhoto(imageToByteArray(pictureBoxEditPhoto.BackgroundImage), "my new decorated photo", "Thug Life", "thugLife1.jpg", null);
        }

        private byte[] imageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
    }
}