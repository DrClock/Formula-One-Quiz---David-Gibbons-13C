using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Formula_One_Quiz
{
    class Car: GameObject
    {
        private int _moveSpeed;
        

        public Car(PictureBox owner, Bitmap carImage)
        {
            _owner = owner;
            _moveSpeed = 1;
            X = 0;
            Y = 10; // top corner of the car is 10 pixels below the top of the track
            Image = carImage;
            
        }
        public void Draw()
        {
            X += _moveSpeed;
            g = _owner.CreateGraphics();
            g.InterpolationMode = InterpolationMode.NearestNeighbor; // removes blur, gives the car a pixel-y look
            g.Clear(_owner.BackColor);
            g.DrawImage(Image, X, Y, Image.Width * 2, Image.Height * 2);
        }
        public int Speed
        {
            get
            {
                return _moveSpeed;
            }
            set
            {
                _moveSpeed = value;
            }
        }
    }
}
