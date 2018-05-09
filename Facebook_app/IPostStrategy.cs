using System;
using FacebookWrapper.ObjectModel;

namespace Facebook_app
{
    public interface IPostStrategy
    {
        string FilterPosts(Post i_Post);
    }
}
