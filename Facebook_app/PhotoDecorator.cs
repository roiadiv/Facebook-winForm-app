using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Facebook_app
{
    public abstract class PhotoDecorator : IPhotoComponent
    {
        protected IPhotoComponent m_PhotoComponent;

        public abstract event Notifier<IPhotoComponent> PhotoComponentAdded;

        public abstract event Notifier<IPhotoComponent> PhotoComponentRemoved;

        public PhotoDecorator(IPhotoComponent i_Photo)
        {
            m_PhotoComponent = i_Photo;
        }

        public string ItemName
        {
            get { return m_PhotoComponent.ItemName; }
        }

        public Image PhotoComponent
        {
            get
            {
                return (m_PhotoComponent as PhotoComponent).Image;
            }

            set
            {
                (m_PhotoComponent as PhotoComponent).Image = value;
            }
        }
    }
}
