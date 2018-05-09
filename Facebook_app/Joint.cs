using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Joint : ThugLifeDecorator
    {
        public Joint(PhotoComponent i_Photo, PictureBoxProxy jointPicture) : base(i_Photo)
        {
            BlendPictures(jointPicture);
        }
    }
}
