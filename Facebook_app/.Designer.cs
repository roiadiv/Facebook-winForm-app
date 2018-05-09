namespace Facebook_app
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.groupBoxPosts = new System.Windows.Forms.GroupBox();
            this.comboBoxPosts = new System.Windows.Forms.ComboBox();
            this.buttonPostKeywordSearch = new System.Windows.Forms.Button();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.buttonFeature = new System.Windows.Forms.Button();
            this.comboBoxFbFeatures = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.dataGridViewLikedPages = new System.Windows.Forms.DataGridView();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.pictureBoxOfAlbum = new Facebook_app.PictureBoxProxy();
            this.groupBoxEditPhoto = new System.Windows.Forms.GroupBox();
            this.pictureBoxEditPhoto = new Facebook_app.PictureBoxProxy();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.groupBoxDecorator = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartDecorate = new System.Windows.Forms.Button();
            this.groupBoxThugLife = new System.Windows.Forms.GroupBox();
            this.panelThugLife = new System.Windows.Forms.Panel();
            this.groupBoxColorType = new System.Windows.Forms.GroupBox();
            this.panelColorType = new System.Windows.Forms.Panel();
            this.buttonEditPhoto = new System.Windows.Forms.Button();
            this.buttonDeletePhotoComponent = new System.Windows.Forms.Button();
            this.panelAddPhoto = new System.Windows.Forms.Panel();
            this.labelAddPhoto = new System.Windows.Forms.Label();
            this.buttonPhotoToAdd = new System.Windows.Forms.Button();
            this.textBoxAddPhoto = new System.Windows.Forms.TextBox();
            this.treeViewAlbums = new System.Windows.Forms.TreeView();
            this.panelAddFolder = new System.Windows.Forms.Panel();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.labelChooseAlbum = new System.Windows.Forms.Label();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.groupBoxPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfAlbum)).BeginInit();
            this.groupBoxEditPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditPhoto)).BeginInit();
            this.groupBoxDecorator.SuspendLayout();
            this.groupBoxThugLife.SuspendLayout();
            this.groupBoxColorType.SuspendLayout();
            this.panelAddPhoto.SuspendLayout();
            this.panelAddFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.General);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 585);
            this.tabControl1.TabIndex = 51;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPageAlbums_Clicked);
            // 
            // General
            // 
            this.General.BackgroundImage = global::Facebook_app.Properties.Resources.backgroundForm;
            this.General.Controls.Add(this.groupBoxPosts);
            this.General.Controls.Add(this.dataGridViewPosts);
            this.General.Controls.Add(this.buttonFeature);
            this.General.Controls.Add(this.comboBoxFbFeatures);
            this.General.Controls.Add(this.label5);
            this.General.Controls.Add(this.label2);
            this.General.Controls.Add(this.label1);
            this.General.Controls.Add(this.labelPicture);
            this.General.Controls.Add(this.labelProfile);
            this.General.Controls.Add(this.dataGridViewFriends);
            this.General.Controls.Add(this.dataGridViewLikedPages);
            this.General.Controls.Add(this.checkBoxRememberUser);
            this.General.Controls.Add(this.labelUserName);
            this.General.Controls.Add(this.searchTextBox);
            this.General.Controls.Add(this.buttonLogin);
            this.General.Controls.Add(this.buttonSetStatus);
            this.General.Controls.Add(this.picture_smallPictureBox);
            this.General.Controls.Add(this.textBoxStatus);
            this.General.Controls.Add(this.label3);
            this.General.Cursor = System.Windows.Forms.Cursors.Default;
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(812, 559);
            this.General.TabIndex = 1;
            this.General.Text = "Filter By";
            this.General.UseVisualStyleBackColor = true;
            // 
            // groupBoxPosts
            // 
            this.groupBoxPosts.Controls.Add(this.comboBoxPosts);
            this.groupBoxPosts.Controls.Add(this.buttonPostKeywordSearch);
            this.groupBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxPosts.ForeColor = System.Drawing.Color.Red;
            this.groupBoxPosts.Location = new System.Drawing.Point(427, 275);
            this.groupBoxPosts.Name = "groupBoxPosts";
            this.groupBoxPosts.Size = new System.Drawing.Size(145, 81);
            this.groupBoxPosts.TabIndex = 79;
            this.groupBoxPosts.TabStop = false;
            this.groupBoxPosts.Text = "Filter By";
            // 
            // comboBoxPosts
            // 
            this.comboBoxPosts.FormattingEnabled = true;
            this.comboBoxPosts.Location = new System.Drawing.Point(4, 19);
            this.comboBoxPosts.Name = "comboBoxPosts";
            this.comboBoxPosts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosts.TabIndex = 78;
            // 
            // buttonPostKeywordSearch
            // 
            this.buttonPostKeywordSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostKeywordSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonPostKeywordSearch.Enabled = false;
            this.buttonPostKeywordSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonPostKeywordSearch.Location = new System.Drawing.Point(6, 52);
            this.buttonPostKeywordSearch.Name = "buttonPostKeywordSearch";
            this.buttonPostKeywordSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPostKeywordSearch.TabIndex = 53;
            this.buttonPostKeywordSearch.Text = "Search";
            this.buttonPostKeywordSearch.UseVisualStyleBackColor = false;
            this.buttonPostKeywordSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.AllowUserToAddRows = false;
            this.dataGridViewPosts.AllowUserToDeleteRows = false;
            this.dataGridViewPosts.AllowUserToResizeColumns = false;
            this.dataGridViewPosts.AllowUserToResizeRows = false;
            this.dataGridViewPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPosts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPosts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPosts.Location = new System.Drawing.Point(12, 294);
            this.dataGridViewPosts.MultiSelect = false;
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.ReadOnly = true;
            this.dataGridViewPosts.RowHeadersVisible = false;
            this.dataGridViewPosts.ShowRowErrors = false;
            this.dataGridViewPosts.Size = new System.Drawing.Size(405, 150);
            this.dataGridViewPosts.TabIndex = 77;
            // 
            // buttonFeature
            // 
            this.buttonFeature.Enabled = false;
            this.buttonFeature.Location = new System.Drawing.Point(370, 47);
            this.buttonFeature.Name = "buttonFeature";
            this.buttonFeature.Size = new System.Drawing.Size(47, 21);
            this.buttonFeature.TabIndex = 75;
            this.buttonFeature.Text = "Select";
            this.buttonFeature.UseVisualStyleBackColor = true;
            this.buttonFeature.Click += new System.EventHandler(this.buttonFeature_Click);
            // 
            // comboBoxFbFeatures
            // 
            this.comboBoxFbFeatures.BackColor = System.Drawing.Color.Red;
            this.comboBoxFbFeatures.Enabled = false;
            this.comboBoxFbFeatures.FormattingEnabled = true;
            this.comboBoxFbFeatures.Location = new System.Drawing.Point(232, 47);
            this.comboBoxFbFeatures.Name = "comboBoxFbFeatures";
            this.comboBoxFbFeatures.Size = new System.Drawing.Size(132, 21);
            this.comboBoxFbFeatures.TabIndex = 74;
            this.comboBoxFbFeatures.Text = " fb additional features";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Fetch Posts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(534, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Fetch Friends";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fetch Pages";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(59, 163);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(96, 33);
            this.labelPicture.TabIndex = 69;
            this.labelPicture.Text = "Picture";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelProfile.Location = new System.Drawing.Point(59, 112);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(90, 33);
            this.labelProfile.TabIndex = 68;
            this.labelProfile.Text = "Profile";
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.AllowUserToAddRows = false;
            this.dataGridViewFriends.AllowUserToDeleteRows = false;
            this.dataGridViewFriends.AllowUserToResizeColumns = false;
            this.dataGridViewFriends.AllowUserToResizeRows = false;
            this.dataGridViewFriends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFriends.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFriends.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFriends.Location = new System.Drawing.Point(534, 84);
            this.dataGridViewFriends.MultiSelect = false;
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.ReadOnly = true;
            this.dataGridViewFriends.RowHeadersVisible = false;
            this.dataGridViewFriends.ShowRowErrors = false;
            this.dataGridViewFriends.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewFriends.TabIndex = 65;
            // 
            // dataGridViewLikedPages
            // 
            this.dataGridViewLikedPages.AllowUserToAddRows = false;
            this.dataGridViewLikedPages.AllowUserToDeleteRows = false;
            this.dataGridViewLikedPages.AllowUserToResizeColumns = false;
            this.dataGridViewLikedPages.AllowUserToResizeRows = false;
            this.dataGridViewLikedPages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLikedPages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLikedPages.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLikedPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLikedPages.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLikedPages.Location = new System.Drawing.Point(254, 84);
            this.dataGridViewLikedPages.MultiSelect = false;
            this.dataGridViewLikedPages.Name = "dataGridViewLikedPages";
            this.dataGridViewLikedPages.ReadOnly = true;
            this.dataGridViewLikedPages.RowHeadersVisible = false;
            this.dataGridViewLikedPages.ShowRowErrors = false;
            this.dataGridViewLikedPages.Size = new System.Drawing.Size(256, 150);
            this.dataGridViewLikedPages.TabIndex = 64;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Enabled = false;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(716, 12);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRememberUser.TabIndex = 62;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(175)));
            this.labelUserName.Location = new System.Drawing.Point(6, 48);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(172, 34);
            this.labelUserName.TabIndex = 61;
            this.labelUserName.Text = "Guest";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(88, 275);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(329, 20);
            this.searchTextBox.TabIndex = 52;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_textChange);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Image = global::Facebook_app.Properties.Resources.LogInButton;
            this.buttonLogin.Location = new System.Drawing.Point(8, 8);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(188, 37);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Enabled = false;
            this.buttonSetStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSetStatus.Location = new System.Drawing.Point(497, 6);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonSetStatus.TabIndex = 46;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.picture_smallPictureBox.Location = new System.Drawing.Point(12, 82);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(200, 156);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_smallPictureBox.TabIndex = 41;
            this.picture_smallPictureBox.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(283, 8);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(208, 20);
            this.textBoxStatus.TabIndex = 76;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_textChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Post Status:";
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.BackgroundImage = global::Facebook_app.Properties.Resources.backgroundForm;
            this.tabPageAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAlbums.Controls.Add(this.buttonPostPhoto);
            this.tabPageAlbums.Controls.Add(this.pictureBoxOfAlbum);
            this.tabPageAlbums.Controls.Add(this.groupBoxEditPhoto);
            this.tabPageAlbums.Controls.Add(this.buttonSaveChanges);
            this.tabPageAlbums.Controls.Add(this.groupBoxDecorator);
            this.tabPageAlbums.Controls.Add(this.buttonEditPhoto);
            this.tabPageAlbums.Controls.Add(this.buttonDeletePhotoComponent);
            this.tabPageAlbums.Controls.Add(this.panelAddPhoto);
            this.tabPageAlbums.Controls.Add(this.treeViewAlbums);
            this.tabPageAlbums.Controls.Add(this.panelAddFolder);
            this.tabPageAlbums.Controls.Add(this.labelChooseAlbum);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(812, 559);
            this.tabPageAlbums.TabIndex = 3;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOfAlbum
            // 
            this.pictureBoxOfAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOfAlbum.ImageFirstPoint = new System.Drawing.Point(0, 0);
            this.pictureBoxOfAlbum.ImageName = null;
            this.pictureBoxOfAlbum.Location = new System.Drawing.Point(232, 12);
            this.pictureBoxOfAlbum.Name = "pictureBoxOfAlbum";
            this.pictureBoxOfAlbum.Size = new System.Drawing.Size(361, 245);
            this.pictureBoxOfAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOfAlbum.TabIndex = 67;
            this.pictureBoxOfAlbum.TabStop = false;
            // 
            // groupBoxEditPhoto
            // 
            this.groupBoxEditPhoto.Controls.Add(this.pictureBoxEditPhoto);
            this.groupBoxEditPhoto.Location = new System.Drawing.Point(226, 263);
            this.groupBoxEditPhoto.Name = "groupBoxEditPhoto";
            this.groupBoxEditPhoto.Size = new System.Drawing.Size(373, 263);
            this.groupBoxEditPhoto.TabIndex = 66;
            this.groupBoxEditPhoto.TabStop = false;
            // 
            // pictureBoxEditPhoto
            // 
            this.pictureBoxEditPhoto.ImageFirstPoint = new System.Drawing.Point(0, 0);
            this.pictureBoxEditPhoto.ImageName = null;
            this.pictureBoxEditPhoto.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxEditPhoto.Name = "pictureBoxEditPhoto";
            this.pictureBoxEditPhoto.Size = new System.Drawing.Size(361, 245);
            this.pictureBoxEditPhoto.TabIndex = 68;
            this.pictureBoxEditPhoto.TabStop = false;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(641, 451);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(133, 61);
            this.buttonSaveChanges.TabIndex = 65;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // groupBoxDecorator
            // 
            this.groupBoxDecorator.Controls.Add(this.buttonReset);
            this.groupBoxDecorator.Controls.Add(this.buttonStartDecorate);
            this.groupBoxDecorator.Controls.Add(this.groupBoxThugLife);
            this.groupBoxDecorator.Controls.Add(this.groupBoxColorType);
            this.groupBoxDecorator.Location = new System.Drawing.Point(11, 263);
            this.groupBoxDecorator.Name = "groupBoxDecorator";
            this.groupBoxDecorator.Size = new System.Drawing.Size(193, 269);
            this.groupBoxDecorator.TabIndex = 62;
            this.groupBoxDecorator.TabStop = false;
            this.groupBoxDecorator.Text = "Decorate Your Photo";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(4, 237);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(81, 26);
            this.buttonReset.TabIndex = 64;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStartDecorate
            // 
            this.buttonStartDecorate.Enabled = false;
            this.buttonStartDecorate.Location = new System.Drawing.Point(91, 237);
            this.buttonStartDecorate.Name = "buttonStartDecorate";
            this.buttonStartDecorate.Size = new System.Drawing.Size(94, 26);
            this.buttonStartDecorate.TabIndex = 63;
            this.buttonStartDecorate.Text = "Start A Decorate";
            this.buttonStartDecorate.UseVisualStyleBackColor = true;
            this.buttonStartDecorate.Click += new System.EventHandler(this.buttonStartDecorate_Click);
            // 
            // groupBoxThugLife
            // 
            this.groupBoxThugLife.Controls.Add(this.panelThugLife);
            this.groupBoxThugLife.Location = new System.Drawing.Point(6, 128);
            this.groupBoxThugLife.Name = "groupBoxThugLife";
            this.groupBoxThugLife.Size = new System.Drawing.Size(143, 103);
            this.groupBoxThugLife.TabIndex = 62;
            this.groupBoxThugLife.TabStop = false;
            this.groupBoxThugLife.Text = "Thug Life Items";
            // 
            // panelThugLife
            // 
            this.panelThugLife.AutoScroll = true;
            this.panelThugLife.Location = new System.Drawing.Point(7, 20);
            this.panelThugLife.Name = "panelThugLife";
            this.panelThugLife.Size = new System.Drawing.Size(131, 74);
            this.panelThugLife.TabIndex = 0;
            // 
            // groupBoxColorType
            // 
            this.groupBoxColorType.Controls.Add(this.panelColorType);
            this.groupBoxColorType.Location = new System.Drawing.Point(6, 19);
            this.groupBoxColorType.Name = "groupBoxColorType";
            this.groupBoxColorType.Size = new System.Drawing.Size(143, 103);
            this.groupBoxColorType.TabIndex = 61;
            this.groupBoxColorType.TabStop = false;
            this.groupBoxColorType.Text = "Color Type";
            // 
            // panelColorType
            // 
            this.panelColorType.AutoScroll = true;
            this.panelColorType.Location = new System.Drawing.Point(7, 20);
            this.panelColorType.Name = "panelColorType";
            this.panelColorType.Size = new System.Drawing.Size(131, 74);
            this.panelColorType.TabIndex = 0;
            // 
            // buttonEditPhoto
            // 
            this.buttonEditPhoto.Enabled = false;
            this.buttonEditPhoto.Location = new System.Drawing.Point(134, 213);
            this.buttonEditPhoto.Name = "buttonEditPhoto";
            this.buttonEditPhoto.Size = new System.Drawing.Size(77, 27);
            this.buttonEditPhoto.TabIndex = 60;
            this.buttonEditPhoto.Text = "Edit Photo";
            this.buttonEditPhoto.UseVisualStyleBackColor = true;
            this.buttonEditPhoto.Click += new System.EventHandler(this.buttonEditPhoto_Click);
            // 
            // buttonDeletePhotoComponent
            // 
            this.buttonDeletePhotoComponent.Location = new System.Drawing.Point(11, 213);
            this.buttonDeletePhotoComponent.Name = "buttonDeletePhotoComponent";
            this.buttonDeletePhotoComponent.Size = new System.Drawing.Size(117, 27);
            this.buttonDeletePhotoComponent.TabIndex = 43;
            this.buttonDeletePhotoComponent.Text = "Delete Photo/Album";
            this.buttonDeletePhotoComponent.UseVisualStyleBackColor = true;
            this.buttonDeletePhotoComponent.Click += new System.EventHandler(this.buttonDeletePhotoComponent_Click);
            // 
            // panelAddPhoto
            // 
            this.panelAddPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddPhoto.Controls.Add(this.labelAddPhoto);
            this.panelAddPhoto.Controls.Add(this.buttonPhotoToAdd);
            this.panelAddPhoto.Controls.Add(this.textBoxAddPhoto);
            this.panelAddPhoto.Location = new System.Drawing.Point(11, 117);
            this.panelAddPhoto.Name = "panelAddPhoto";
            this.panelAddPhoto.Size = new System.Drawing.Size(200, 81);
            this.panelAddPhoto.TabIndex = 38;
            // 
            // labelAddPhoto
            // 
            this.labelAddPhoto.AutoSize = true;
            this.labelAddPhoto.Location = new System.Drawing.Point(18, 16);
            this.labelAddPhoto.Name = "labelAddPhoto";
            this.labelAddPhoto.Size = new System.Drawing.Size(67, 13);
            this.labelAddPhoto.TabIndex = 2;
            this.labelAddPhoto.Text = "Folder Name";
            // 
            // buttonPhotoToAdd
            // 
            this.buttonPhotoToAdd.Location = new System.Drawing.Point(21, 51);
            this.buttonPhotoToAdd.Name = "buttonPhotoToAdd";
            this.buttonPhotoToAdd.Size = new System.Drawing.Size(158, 23);
            this.buttonPhotoToAdd.TabIndex = 43;
            this.buttonPhotoToAdd.Text = "Add Photo To Folder";
            this.buttonPhotoToAdd.UseVisualStyleBackColor = true;
            this.buttonPhotoToAdd.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // textBoxAddPhoto
            // 
            this.textBoxAddPhoto.Location = new System.Drawing.Point(91, 13);
            this.textBoxAddPhoto.Name = "textBoxAddPhoto";
            this.textBoxAddPhoto.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPhoto.TabIndex = 1;
            // 
            // treeViewAlbums
            // 
            this.treeViewAlbums.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAlbums.Location = new System.Drawing.Point(611, 29);
            this.treeViewAlbums.Name = "treeViewAlbums";
            this.treeViewAlbums.Size = new System.Drawing.Size(193, 218);
            this.treeViewAlbums.TabIndex = 42;
            this.treeViewAlbums.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAlbums_SelectedIndexChanged);
            // 
            // panelAddFolder
            // 
            this.panelAddFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddFolder.Controls.Add(this.labelFolderName);
            this.panelAddFolder.Controls.Add(this.textBoxFolderName);
            this.panelAddFolder.Controls.Add(this.buttonCreateFolder);
            this.panelAddFolder.Location = new System.Drawing.Point(11, 17);
            this.panelAddFolder.Name = "panelAddFolder";
            this.panelAddFolder.Size = new System.Drawing.Size(200, 81);
            this.panelAddFolder.TabIndex = 37;
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Location = new System.Drawing.Point(18, 16);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(67, 13);
            this.labelFolderName.TabIndex = 2;
            this.labelFolderName.Text = "Folder Name";
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.Location = new System.Drawing.Point(91, 13);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFolderName.TabIndex = 1;
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(33, 48);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(133, 23);
            this.buttonCreateFolder.TabIndex = 0;
            this.buttonCreateFolder.Text = "Create Folder";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // labelChooseAlbum
            // 
            this.labelChooseAlbum.AutoSize = true;
            this.labelChooseAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelChooseAlbum.Location = new System.Drawing.Point(612, 13);
            this.labelChooseAlbum.Name = "labelChooseAlbum";
            this.labelChooseAlbum.Size = new System.Drawing.Size(78, 13);
            this.labelChooseAlbum.TabIndex = 3;
            this.labelChooseAlbum.Text = "Choose Album:";
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.comboBoxActionType.Location = new System.Drawing.Point(120, 6);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxActionType.TabIndex = 23;
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            this.dataGridViewActions.AllowUserToOrderColumns = true;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.Size = new System.Drawing.Size(815, 408);
            this.dataGridViewActions.TabIndex = 22;
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.Location = new System.Drawing.Point(641, 363);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(133, 62);
            this.buttonPostPhoto.TabIndex = 68;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = true;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 585);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Name = "FormMain";
            this.Text = "Main Form - Facebook App";
            this.tabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.groupBoxPosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfAlbum)).EndInit();
            this.groupBoxEditPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditPhoto)).EndInit();
            this.groupBoxDecorator.ResumeLayout(false);
            this.groupBoxThugLife.ResumeLayout(false);
            this.groupBoxColorType.ResumeLayout(false);
            this.panelAddPhoto.ResumeLayout(false);
            this.panelAddPhoto.PerformLayout();
            this.panelAddFolder.ResumeLayout(false);
            this.panelAddFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.Button buttonPostKeywordSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.DataGridView dataGridViewLikedPages;
        private System.Windows.Forms.ComboBox comboBoxFbFeatures;
        private System.Windows.Forms.Button buttonFeature;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.Label labelChooseAlbum;
        private System.Windows.Forms.Panel panelAddFolder;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.TreeView treeViewAlbums;
        private System.Windows.Forms.Button buttonPhotoToAdd;
        private System.Windows.Forms.Panel panelAddPhoto;
        private System.Windows.Forms.Label labelAddPhoto;
        private System.Windows.Forms.TextBox textBoxAddPhoto;
        private System.Windows.Forms.Button buttonDeletePhotoComponent;
        private System.Windows.Forms.Button buttonEditPhoto;
        private System.Windows.Forms.GroupBox groupBoxColorType;
        private System.Windows.Forms.Panel panelColorType;
        private System.Windows.Forms.GroupBox groupBoxDecorator;
        private System.Windows.Forms.GroupBox groupBoxThugLife;
        private System.Windows.Forms.Panel panelThugLife;
        private System.Windows.Forms.Button buttonStartDecorate;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.GroupBox groupBoxEditPhoto;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxPosts;
        private System.Windows.Forms.ComboBox comboBoxPosts;
        private PictureBoxProxy pictureBoxOfAlbum;
        private PictureBoxProxy pictureBoxEditPhoto;
        private System.Windows.Forms.Button buttonPostPhoto;
    }
}