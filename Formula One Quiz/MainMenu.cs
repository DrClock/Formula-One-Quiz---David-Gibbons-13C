using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Formula_One_Quiz
{
    // in the designer, the font for TitleLabel is Agency FB. If that font isn't installed, it'll be it's default value and won't fit on the label
    public partial class MainMenu : Form
    {
        bool exit;
        bool music, sfx;
        SoundPlayer _player;
        Options optionForm;
        Stats statsForm;
        GameScreen gameForm;
        User[] activeUsers;
        public MainMenu(User[] users, SoundPlayer player)
        {
            InitializeComponent();
            if (MessageBox.Show("Do you want music to play?", "Music", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    player.PlayLooping();
                    music = true;
                }
                catch
                {
                    MessageBox.Show("Can't play music.");
                }
            }
            activeUsers = users;
            exit = false;
            sfx = true;

            _player = player;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you want to quit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                exit = true; 
                Application.Exit(); // even if the user said no, this form will still close unless stopped - something to do with the form returning a DialogResult
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            optionForm = new Options(music,sfx,_player);
            this.Hide();
            optionForm.ShowDialog();// Stops this form from doing anything else until the new form is closed
            if (optionForm.Restart)
            {
                //exit = true;
                this.Dispose(); // this bypasses the exit check I established
            }
            else
            {
                music = optionForm.Music;
                sfx = optionForm.SFX;
                optionForm.Dispose();
                this.Show();
            }
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            statsForm = new Stats(activeUsers);
            this.Hide();
            statsForm.ShowDialog();
            this.Show();
            statsForm.Dispose();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exit)
            {
                if (e.CloseReason == CloseReason.None) // this won't stop the form from closing if A) the exit button was pressed B) the form was closed by ALT+F4 or another command such as closing from the taskbar
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            gameForm = new GameScreen(activeUsers, sfx);
            this.Hide();
            gameForm.ShowDialog();
            activeUsers = gameForm._activeUsers;
            this.Show();
            gameForm.Dispose();
        }
    }
}
