using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class LikesPagesWrapper
    {
        private Page m_LikedPageWrapper;

        public LikesPagesWrapper(Page i_Page)
        {
            m_LikedPageWrapper = i_Page;
        }

        public string Name
        {
            get
            {
                return m_LikedPageWrapper.Name;
            }
        }

        public Image PagePhoto
        {
            get
            {
                try
                {
                    return m_LikedPageWrapper.ImageSmall;
                }
                catch (Exception ex)
                {
                    return global::Facebook_app.Properties.Resources.no_image_available_md;
                }
            }
        }
    }
}