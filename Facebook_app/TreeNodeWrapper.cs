using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook_app
{
    public class TreeNodeWrapper : TreeNode
    {
        private IPhotoComponent m_Node;

        public TreeNodeWrapper(string i_Name, IPhotoComponent i_Node) : base(i_Name)
        {
            m_Node = i_Node;
            m_Node.PhotoComponentAdded += OnComponentAdded;
            m_Node.PhotoComponentRemoved += OnComponentRemoved;
        }

        private void OnComponentAdded(IPhotoComponent i_Param)
        {
            if (i_Param is PhotoComponent)
            {
                Nodes.Add((i_Param as PhotoComponent).Node = new TreeNodeWrapper(i_Param.ItemName, i_Param));
            }
            else
            {
                Nodes.Add((i_Param as PhotoComposite).Node = new TreeNodeWrapper(i_Param.ItemName, i_Param));
            }
        }

        private void OnComponentRemoved(IPhotoComponent i_Param)
        {
            if (i_Param is PhotoComponent)
            {
                Nodes.Remove((i_Param as PhotoComponent).Node);
            }
            else
            {
                Nodes.Remove((i_Param as PhotoComposite).Node);
            }
        }

        public IPhotoComponent Node
        {
            get { return m_Node; }
        }
    }
}
