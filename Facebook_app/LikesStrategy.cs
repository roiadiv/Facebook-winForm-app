using System;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class LikesStrategy : IPostStrategy
    {
        public string FilterPosts(Post i_Post)
        {
            return i_Post.LikedBy.Count.ToString();
        }
    }
}
