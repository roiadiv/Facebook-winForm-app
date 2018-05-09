using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Facebook_app
{
    public class Hat : ThugLifeDecorator
    {
        public Hat(PhotoComponent i_Photo, PictureBoxProxy hatPicture) : base(i_Photo)
        {
            BlendPictures(hatPicture);
        }
    }
}
