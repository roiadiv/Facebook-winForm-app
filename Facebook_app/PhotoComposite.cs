using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook_app
{
    public class PhotoComposite : IPhotoComponent
    {
        private string m_ItemName;
        private TreeNodeWrapper m_Node;

        public event Notifier<IPhotoComponent> PhotoComponentAdded;

        public event Notifier<IPhotoComponent> PhotoComponentRemoved;

        public PhotoComposite(string i_ItemName)
        {
            m_ItemName = i_ItemName;
        }

        public TreeNodeWrapper Node
        {
            get
            {
                return m_Node;
            }

            set
            {
                m_Node = value;
            }
        }

        public string ItemName
        {
            get { return m_ItemName; }
        }

        public void OnPhotoComponentAdded(IPhotoComponent i_ComponentToAdd)
        {
            PhotoComponentAdded.Invoke(i_ComponentToAdd);
        }

        public void OnPhotoComponentRemoved(IPhotoComponent i_ComponentToRemove)
        {
            PhotoComponentRemoved.Invoke(i_ComponentToRemove);
        }
    }
}