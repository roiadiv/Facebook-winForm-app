﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class Invert : ColorChangerDecorator
    {
        public Invert(IPhotoComponent i_Photo) : base(i_Photo)
        {
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[] { -1, 0, 0, 0, 0 }, 
                    new float[] { 0, -1, 0, 0, 0 }, 
                    new float[] { 0, 0, -1, 0, 0 },  
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 1, 1, 1, 0, 1 }
            });

            filter(cmPicture);
        }
    }
}