using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_One_Quiz
{
    public partial class Stats : Form
    {
        User[] _activeUsers;
        int active;
        public Stats( User[] users)
        {
            InitializeComponent();
            active = 0;
            _activeUsers = users;
            if (_activeUsers.Length == 1)
            {
                SwitchButton.Visible = false;
            }
            UpdateForm();
        }

        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(_activeUsers[active].Car, 0, 0, 37 * 3, 16 * 3);
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            bool x = Convert.ToBoolean(active);
            x = !x;
            active = Convert.ToInt32(x);
            UpdateForm();
        }
        private void UpdateForm()
        {
            this.Text = _activeUsers[active].Username + ": Stats";
            NameLabel.Text = _activeUsers[active].Username;
            GPLabel.Text = _activeUsers[active].Games.ToString();
            GWLabel.Text = _activeUsers[active].Wins.ToString();
            WLLabel.Text = String.Format("{0:0.00}" ,_activeUsers[active].CalcWinLoss());
            TPQLabel.Text = String.Format("{0:0.00}s",_activeUsers[active].TPQ);
            if (double.IsPositiveInfinity(_activeUsers[active].BestTime))
            {
                BTLabel.Text = "None set";
            }
            else
            {
                BTLabel.Text = String.Format("{0:0.00}s", _activeUsers[active].BestTime);
            }
            CarBox.Invalidate();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
