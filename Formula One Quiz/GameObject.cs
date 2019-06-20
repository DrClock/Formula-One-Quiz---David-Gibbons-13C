using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Formula_One_Quiz
{
    abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        protected Bitmap image;
        protected Graphics g; // should be set to the drawing surface of its owner - the picturebox
        protected PictureBox _owner;

        public Bitmap Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }
    }
}
