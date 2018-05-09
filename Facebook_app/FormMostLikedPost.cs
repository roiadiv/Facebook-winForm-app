using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public partial class FormMostLikedPost : Form
    {
        private Post m_MostLikedPost;
        private User m_LoggedInUser;

        public FormMostLikedPost(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            this.runMostLikedPost();
        }

        private void runMostLikedPost()
        {
            int numOfMostLikedPost = 0;
            string mostLikedPostIndex = string.Empty;

            this.findMostLikedPost(ref numOfMostLikedPost, ref mostLikedPostIndex, m_LoggedInUser.Posts);
            this.setMostLikedPost(mostLikedPostIndex);
        }

        private void setMostLikedPost(string i_MostLikedPostIndex)
        {
            this.listBoxLikedTheMostLikedPost.LargeImageList = new ImageList();
            this.listBoxLikedTheMostLikedPost.View = View.LargeIcon;
            m_MostLikedPost = FacebookService.GetObject<Post>(i_MostLikedPostIndex);
            pictureBoxMostLikedPost.LoadAsync(m_LoggedInUser.PictureNormalURL);
            pictureBoxMostLikedPost.SizeMode = PictureBoxSizeMode.StretchImage;
            textBoxMostLikedPostDate.Text = m_MostLikedPost.CreatedTime.ToString();
            textBoxMostLikePostMessage.Text = m_MostLikedPost.Message;
            for (int i = 0; i < m_MostLikedPost.LikedBy.Count; i++)
            {
                listBoxLikedTheMostLikedPost.LargeImageList.Images.Add(i.ToString(), m_MostLikedPost.LikedBy[i].ImageLarge);
                listBoxLikedTheMostLikedPost.Items.Add(i.ToString(), m_MostLikedPost.LikedBy[i].Name, i);
            }     
        }

        private void findMostLikedPost(ref int io_NumOfMostLikedPost, ref string io_MostLikedPostIndex, FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                if (post.LikedBy.Count >= io_NumOfMostLikedPost)
                {
                    io_NumOfMostLikedPost = post.LikedBy.Count;
                    io_MostLikedPostIndex = post.Id;
                }
            }
        }
    }
}
