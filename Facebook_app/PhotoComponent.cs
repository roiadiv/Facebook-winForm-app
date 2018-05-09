using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook_app
{
    public class PhotoComponent : IPhotoComponent
    {
        private string m_ItemName;
        private TreeNodeWrapper m_Node;
        private Image m_Image;

        public event Notifier<IPhotoComponent> PhotoComponentAdded;

        public event Notifier<IPhotoComponent> PhotoComponentRemoved;

        public PhotoComponent(string i_ItemName, Image i_Image)
        {
            m_ItemName = i_ItemName;
            m_Image = i_Image;
        }

        public string ItemName
        {
            get { return m_ItemName; }
        }

        public Image Image
        {
            get
            {
                return m_Image;
            }

            set
            {
                m_Image = value;
            }
        }

        public TreeNodeWrapper Node
        {
            get { return m_Node; }
            set { m_Node = value; }
        }

        public void OnPhotoComponentAdded(IPhotoComponent i_ComponentToAdd)
        {
            throw new Exception("You can't add a photo to a photo!");
        }

        public void OnPhotoComponentRemoved(IPhotoComponent i_ComponentToRemove)
        {
            PhotoComponentRemoved.Invoke(i_ComponentToRemove);
        }
    }
}
