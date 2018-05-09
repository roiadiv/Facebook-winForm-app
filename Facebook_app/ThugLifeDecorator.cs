using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public class ThugLifeDecorator : PhotoDecorator
    {
        public ThugLifeDecorator(IPhotoComponent i_Photo) : base(i_Photo)
        {
        }

        public string ItemName
        {
            get { return m_PhotoComponent.ItemName; }
        }

        public override event Notifier<IPhotoComponent> PhotoComponentAdded;

        public override event Notifier<IPhotoComponent> PhotoComponentRemoved;

        public void BlendPictures(PictureBoxProxy i_PictureCover)
        {
            Bitmap bitmap = new Bitmap(PhotoComponent.Width, PhotoComponent.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(PhotoComponent, 0, 0, PhotoComponent.Width, PhotoComponent.Height);
            }

            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rectangleAreaToDrawImage = new Rectangle(i_PictureCover.Location.X, i_PictureCover.Location.Y, i_PictureCover.Width, i_PictureCover.Height);
            g.DrawImage(i_PictureCover.Image, rectangleAreaToDrawImage);
            PhotoComponent = bitmap;
        }
    }
}
