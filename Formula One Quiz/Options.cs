using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_One_Quiz
{
    public partial class Options : Form
    {
        bool restart, _music, _sfx;
        SoundPlayer _player;

        public bool SFX
        {
            get { return _sfx; }
        }

        public bool Music
        {
            get { return _music; }
        }

        public bool Restart
        {
            get { return restart; }
        }
        
        public Options(bool music, bool sfx, SoundPlayer player)
        {
            InitializeComponent();
            _music = music;
            _sfx = sfx;
            _player = player;
            UpdateText();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            restart = true;
            _player.Stop();
            this.Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("help.txt");
                MessageBox.Show(sr.ReadToEnd(),"Help");
                sr.Close();
                sr.Dispose();
            }
            catch 
            {
                MessageBox.Show("There was a problem getting the instructions. Make sure help.txt is in the right directory.","Whoops!");
            }
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_music)
                {
                    _player.Stop();
                }
                else
                {
                    _player.PlayLooping();
                }
                _music = !_music;
                UpdateText();
            }
            catch
            {
                MessageBox.Show("Can't play music.");
            }
        }

        private void SFXButton_Click(object sender, EventArgs e)
        {
            _sfx = !_sfx;
            UpdateText();
        }
        private void UpdateText()
        {
            if (_music)
            {
                MusicButton.Text = "Music Off"; 
            }
            else
            {
                MusicButton.Text = "Music On";
            }
            if (_sfx)
            {
                SFXButton.Text = "SFX Off";
            }
            else
            {
                SFXButton.Text = "SFX On";
            }
        }
    }
}
