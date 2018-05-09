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
    public partial class FormNavigateToEvent : Form
    {
        private User m_LoggedInUser;

        public FormNavigateToEvent(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            this.fetchNavigateToEvent();
        }

        private void fetchNavigateToEvent()
        {
            int i = 0;

            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                PictureBox eventPictureBox = new PictureBox();
                eventPictureBox.Size = new System.Drawing.Size(47, 39);
                eventPictureBox.Location = new Point(60 * i, 0);
                eventPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                eventPictureBox.Click += new EventHandler((sender, e) => imageEvent_Click(sender, e, fbEvent));
                eventPictureBox.LoadAsync(fbEvent.PictureNormalURL);
                this.panelEvents.Controls.Add(eventPictureBox);
                i++;
            }
        }

        private void imageEvent_Click(object sender, EventArgs e, Event fbEvent)
        {
            string eventLocationName = fbEvent.Place.Name;
            this.labelAttending.Text = fbEvent.AttendingUsers.Count.ToString();
            this.labelMaybe.Text = fbEvent.MaybeAttendingUsers.Count.ToString();
            this.labelDecline.Text = fbEvent.DeclinedUsers.Count.ToString();
            this.richTextBoxEventDescription.Text = fbEvent.Description;
            this.pictureBoxEvent.LoadAsync(fbEvent.PictureNormalURL);

            try
            {
                StringBuilder urlEventLocation = new StringBuilder();
                urlEventLocation.Append("https://www.google.com/maps/dir/my+location/");
                urlEventLocation.Append(fbEvent);
                this.webBrowserEvent.Navigate(urlEventLocation.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
