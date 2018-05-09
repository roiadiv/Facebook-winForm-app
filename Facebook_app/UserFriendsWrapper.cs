using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class UserFriendsWrapper
    {
        private User m_UserFriendsWrapper;

        public UserFriendsWrapper(User i_UserFriend)
        {
            m_UserFriendsWrapper = i_UserFriend;
        }

        public string Name
        {
            get
            {
                return m_UserFriendsWrapper.Name;
            }
        }

        public Image ProfilePic
        {
            get
            {
                return m_UserFriendsWrapper.ImageNormal;
            }
        }
    }
}
