using System;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class CommentsStrategy : IPostStrategy
    {
        public string FilterPosts(Post i_Post)
        {
            return i_Post.Comments.Count.ToString();
        }
    }
}
