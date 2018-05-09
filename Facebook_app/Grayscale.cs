using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Grayscale : ColorChangerDecorator
    {
        public Grayscale(IPhotoComponent i_Photo) : base(i_Photo)
        {
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[] { 0.33f, 0.33f, 0.33f, 0, 0 }, 
                    new float[] { 0.59f, 0.59f, 0.59f, 0, 0 }, 
                    new float[] { 0.11f, 0.11f, 0.11f, 0, 0 },  
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0, 0, 0, 0, 1 }
            });
            filter(cmPicture);
        }
    }
}