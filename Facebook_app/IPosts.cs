using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public interface IPosts
    {
        DateTime? Date
        {
            get;
        }

        int Comments
        {
            get;
        }

        int Likes
        {
            get;
        }

        string Post
        {
            get;
        }
    }
}
