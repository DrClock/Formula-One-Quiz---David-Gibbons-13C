using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Formula_One_Quiz
{
    class Wheel : GameObject
    {
        int angle = 0;
        public Wheel(PictureBox owner)
        {
            image = Properties.Resources.Wheel;
            _owner = owner;
        }

        // complicated...!
        public void RotateImage(int speed)
        {
            image = Properties.Resources.Wheel;
            angle = angle + (10 * speed);

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics newG = Graphics.FromImage(rotatedBmp);

            //Put the origin point of the image object to the centre
            newG.TranslateTransform(image.Width / 2, image.Height / 2);

            //rotate the image
            newG.RotateTransform(angle);

            //move the image back
            newG.TranslateTransform(-image.Width / 2, -image.Height / 2);

            //draw passed in image onto rotated graphics object
            newG.DrawImage(image, new Point(0, 0));

            //delete the old image
            image.Dispose();

            image = rotatedBmp;

            //draw the new wheel onto the respective picturebox
            g = _owner.CreateGraphics();
            g.DrawImage(image, 0, 0, 56, 56);
        }
    }
}
