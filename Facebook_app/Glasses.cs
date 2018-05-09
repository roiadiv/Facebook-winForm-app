using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Glasses : ThugLifeDecorator
    {
        public Glasses(PhotoComponent i_Photo, PictureBoxProxy glassesPicture) : base(i_Photo)
        {
            BlendPictures(glassesPicture);
        }
    }
}
