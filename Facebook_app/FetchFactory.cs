using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public static class FetchFactory
    {
        public static Form CreateFetchForm(eFbFeatures i_Fetch, User i_User)
        { 
            Form fetchFormToCreate = null;
            switch (i_Fetch)
            {
                case eFbFeatures.MostLikedPost:
                    fetchFormToCreate = new FormMostLikedPost(i_User);
                    break;
                case eFbFeatures.MostLikedPhoto:
                    fetchFormToCreate = new FormMostLikedPhoto(i_User);
                    break;
                case eFbFeatures.MostAttendedEvent:
                    fetchFormToCreate = new FormMostAttendedEvent(i_User);
                    break;
                case eFbFeatures.NavigateToEvent:
                    fetchFormToCreate = new FormNavigateToEvent(i_User);
                    break;
            }

            return fetchFormToCreate;
        }
    }
}