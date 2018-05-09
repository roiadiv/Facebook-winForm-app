using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook_app
{
    public class PictureBoxProxy : PictureBox
    {
        public string ImageName { get; set; }

        private Point m_ImageFirstPoint = new Point();

        public Point ImageFirstPoint
        {
            get { return m_ImageFirstPoint; }
            set { m_ImageFirstPoint = value; }
        }
    }
}
