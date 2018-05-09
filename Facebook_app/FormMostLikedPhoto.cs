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
    public partial class FormMostLikedPhoto : Form
    {
        private Photo m_MostLikedPhoto;
        private User m_LoggedInUser;

        public FormMostLikedPhoto(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            this.fetchMostLikedPhoto();
        }

        private void fetchMostLikedPhoto()
        {
            int numOfMostLikedPhoto = 0;
            string mostLikedPhotoIndex = string.Empty;

            this.findMostLikedPhoto(ref numOfMostLikedPhoto, ref mostLikedPhotoIndex, m_LoggedInUser.PhotosTaggedIn);
            this.setMostLikedPhoto(mostLikedPhotoIndex);
        }

        private void setMostLikedPhoto(string i_MostLikedPhotoIndex)
        {
            this.listBoxLikedTheMostLikedPhoto.LargeImageList = new ImageList();
            this.listBoxLikedTheMostLikedPhoto.View = View.LargeIcon;
            m_MostLikedPhoto = FacebookService.GetObject<Photo>(i_MostLikedPhotoIndex);
            pictureBoxMostLikedPhoto.Load(m_MostLikedPhoto.PictureNormalURL);
            pictureBoxMostLikedPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            textBoxMostLikedPhotoDate.Text = m_MostLikedPhoto.CreatedTime.ToString();
            for (int i = 0; i < m_MostLikedPhoto.LikedBy.Count; i++)
            {
                listBoxLikedTheMostLikedPhoto.LargeImageList.Images.Add(i.ToString(), m_MostLikedPhoto.LikedBy[i].ImageLarge);
                listBoxLikedTheMostLikedPhoto.Items.Add(i.ToString(), m_MostLikedPhoto.LikedBy[i].Name, i);
            }
        }

        private void findMostLikedPhoto(ref int io_NumOfMostLikedPhoto, ref string io_MostLikedPhotoIndex, FacebookObjectCollection<Photo> i_Photos)
        {
            foreach (Photo photo in i_Photos)
            {
                if (photo.LikedBy.Count >= io_NumOfMostLikedPhoto)
                {
                    io_NumOfMostLikedPhoto = photo.LikedBy.Count;
                    io_MostLikedPhotoIndex = photo.Id;
                }
            }
        }
    }
}