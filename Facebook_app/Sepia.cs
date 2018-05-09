using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Sepia : ColorChangerDecorator
    {
        public Sepia(IPhotoComponent i_Photo) : base(i_Photo)
        {
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
               {
                    new float[] { 0.393f, 0.349f, 0.272f, 0, 0 }, 
                    new float[] { 0.769f, 0.686f, 0.534f, 0, 0 }, 
                    new float[] { 0.189f, 0.168f, 0.131f, 0, 0 },   
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0, 0, 0, 0, 1 }
               });

            filter(cmPicture);
        }
    }
}