using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Polaroid : ColorChangerDecorator
    {
        public Polaroid(IPhotoComponent i_Photo) : base(i_Photo)
        {
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
              {
                    new float[] { 1.438f, -0.062f, -0.062f, 0, 0 }, 
                    new float[] { -0.122f, 1.378f, -0.122f, 0, 0 }, 
                    new float[] { -0.016f, -0.016f, 1.483f, 0, 0 },  
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { -0.03f, 0.05f, -0.02f, 0, 1 }
              });

            filter(cmPicture);
        }
    }
}