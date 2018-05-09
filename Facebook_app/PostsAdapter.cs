using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public class PostsAdapter : IPosts
    {
        private Post m_Post;

        public PostsAdapter(Post i_Post)
        {
            m_Post = i_Post;
        }

        public DateTime? Date
        {
            get { return m_Post.CreatedTime; }
        }

        public int Comments
        {
            get { return m_Post.Comments.Count; }
        }

        public int Likes
        {
            get { return m_Post.LikedBy.Count; }
        }

        public string Post
        {
            get { return m_Post.Message; }
        }
    }
}
