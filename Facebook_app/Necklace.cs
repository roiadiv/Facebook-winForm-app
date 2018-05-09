using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Necklace : ThugLifeDecorator
    {
        public Necklace(PhotoComponent i_Photo, PictureBoxProxy necklacePicture) : base(i_Photo)
        {
            BlendPictures(necklacePicture);
        }
    }
}
