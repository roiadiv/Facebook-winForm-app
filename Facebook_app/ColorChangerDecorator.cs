using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class ColorChangerDecorator : PhotoDecorator
    {
        protected ColorMatrix m_ColorMatrix;

        public ColorChangerDecorator(IPhotoComponent i_Photo) : base(i_Photo)
        {
        }

        public string ItemName
        {
            get { return m_PhotoComponent.ItemName; }
        }

        public override event Notifier<IPhotoComponent> PhotoComponentAdded;

        public override event Notifier<IPhotoComponent> PhotoComponentRemoved;

        protected void filter(ColorMatrix i_cmPicture)
        {
                Image image = (m_PhotoComponent as PhotoComponent).Image;
                Bitmap bmpInverted = new Bitmap(image.Width, image.Height);
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(i_cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                (m_PhotoComponent as PhotoComponent).Image = bmpInverted;
        }
    }
}
