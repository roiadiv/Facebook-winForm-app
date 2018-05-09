using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public static class PostStrategyFactory
    {
        public static IPostStrategy CreatePostStrategy(string i_PostStrategy)
        {
            IPostStrategy postStrategy = null;

            switch (i_PostStrategy)
            {
                case "Post":
                    postStrategy = new PostStrategy();
                    break;

                case "Likes":
                    postStrategy = new LikesStrategy();
                    break;
                case "Comments":
                    postStrategy = new CommentsStrategy();
                    break;
                case "Date":
                    postStrategy = new DateStrategy();
                    break;
            }

            return postStrategy;
        }
    }
}
