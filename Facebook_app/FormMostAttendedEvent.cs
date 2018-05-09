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
    public partial class FormMostAttendedEvent : Form
    {
        private Event m_MostAttendedEvent;
        private User m_LoggedInUser;

        public FormMostAttendedEvent(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            this.fetchMostAttendedEvent();
        }

        private void fetchMostAttendedEvent()
        {
            int numOfMostAttendedToEvent = 0;
            string mostAttendedEventIndex = string.Empty;
            this.findMostAttendedEvent(ref numOfMostAttendedToEvent, ref mostAttendedEventIndex, m_LoggedInUser.Events);
            this.setMostAttendingEvent(mostAttendedEventIndex, numOfMostAttendedToEvent);
        }

        private void findMostAttendedEvent(ref int io_NumOfMostAttendedToEvent, ref string io_MostAttendedEventIndex, FacebookObjectCollection<Event> i_Events)
        {
            foreach (Event objEvent in i_Events)
            {
                if (objEvent.AttendingUsers.Count >= io_NumOfMostAttendedToEvent)
                {
                    io_NumOfMostAttendedToEvent = objEvent.AttendingUsers.Count;
                    io_MostAttendedEventIndex = objEvent.Id;
                }
            }
        }

        private void setMostAttendingEvent(string i_MostAttendingEventIndex, int i_NumOfMostAttendingToEvent)
        {
            m_MostAttendedEvent = FacebookService.GetObject<Event>(i_MostAttendingEventIndex);
            this.textBoxNumOfAttending.Text = i_NumOfMostAttendingToEvent.ToString();
            this.textBoxEventsMostAttendedName.Text = m_MostAttendedEvent.Name;
            this.pictureBoxMostAttendingEvent.Load(m_MostAttendedEvent.PictureNormalURL);
            this.pictureBoxMostAttendingEvent.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
