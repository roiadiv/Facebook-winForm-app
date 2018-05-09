using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Ben_304815616_Roy_203055892
{
    public sealed class LoggedInUserSingleton
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

        private static User s_LoggedInUserInstance = null;
        private static object s_LockObj = new object();
        private static AppSettings s_AppSettings = AppSettings.LoadFromFile();
        private static LoginResult s_LoginResult = null;

        public static AppSettings AppSettings
        {
            get { return s_AppSettings; }
        }

        private LoggedInUserSingleton()
        {
        }

        public static User Instance
        {
            get
            {
                if (s_LoggedInUserInstance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_LoggedInUserInstance == null)
                        {
                            if (rememberMeChecked())
                            {
                                s_LoginResult = FacebookService.Connect(s_AppSettings.LastAccessToken);
                            }
                            else
                            {
                                s_LoginResult = FacebookService.Login(k_AppId, sr_FacebookPermissions);
                                s_AppSettings.LastAccessToken = s_LoginResult.AccessToken;
                            }

                            s_LoggedInUserInstance = s_LoginResult.LoggedInUser;
                        }
                    }
                }

                return s_LoggedInUserInstance;
            }
        }

        private static bool rememberMeChecked()
        {
            bool isRememberMeChecked = false;

            if (s_AppSettings.RememberUser && !string.IsNullOrEmpty(s_AppSettings.LastAccessToken))
            {
                isRememberMeChecked = true;
            }

            return isRememberMeChecked;
        }
    }
}