using System;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class DateStrategy : IPostStrategy
    {
        public string FilterPosts(Post i_Post)
        {
            return i_Post.CreatedTime.ToString();
        }
    }
}
