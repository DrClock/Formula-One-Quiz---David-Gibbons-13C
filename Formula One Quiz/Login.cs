using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Formula_One_Quiz
{
    public partial class Login : Form
    {
        Bitmap car1, car2;
        User[] ActiveUsers;
        Dictionary<string,User> AllUsers;
        Stream userFileStream;
        MainMenu menuform;
        SoundPlayer player;
        int[,] CarColourCoords = new int[216, 2] { { 1, 2 }, { 2, 2 }, { 1, 3 }, { 2, 3 }, { 5, 3 }, { 6, 3 }, { 7, 3 }, { 1, 4 }, { 2, 4 }, { 5, 4 }, { 6, 4 }, { 7, 4 }, { 8, 4 }, { 9, 4 }, { 10, 4 }, { 11, 4 }, { 12, 4 }, { 13, 4 }, { 14, 4 }, { 15, 4 }, { 16, 4 }, { 17, 4 }, { 18, 4 }, { 19, 4 }, { 35, 4 }, { 1, 5 }, { 2, 5 }, { 4, 5 }, { 5, 5 }, { 6, 5 }, { 7, 5 }, { 8, 5 }, { 9, 5 }, { 10, 5 }, { 11, 5 }, { 12, 5 }, { 13, 5 }, { 14, 5 }, { 15, 5 }, { 16, 5 }, { 17, 5 }, { 18, 5 }, { 19, 5 }, { 20, 5 }, { 35, 5 }, { 1, 6 }, { 2, 6 }, { 4, 6 }, { 5, 6 }, { 6, 6 }, { 7, 6 }, { 8, 6 }, { 9, 6 }, { 10, 6 }, { 11, 6 }, { 12, 6 }, { 15, 6 }, { 16, 6 }, { 17, 6 }, { 18, 6 }, { 19, 6 }, { 20, 6 }, { 21, 6 }, { 22, 6 }, { 23, 6 }, { 24, 6 }, { 25, 6 }, { 26, 6 }, { 27, 6 }, { 28, 6 }, { 29, 6 }, { 30, 6 }, { 31, 6 }, { 32, 6 }, { 33, 6 }, { 35, 6 }, { 1, 7 }, { 2, 7 }, { 4, 7 }, { 5, 7 }, { 6, 7 }, { 7, 7 }, { 8, 7 }, { 9, 7 }, { 10, 7 }, { 11, 7 }, { 12, 7 }, { 14, 7 }, { 15, 7 }, { 16, 7 }, { 17, 7 }, { 18, 7 }, { 19, 7 }, { 20, 7 }, { 21, 7 }, { 22, 7 }, { 23, 7 }, { 24, 7 }, { 25, 7 }, { 26, 7 }, { 27, 7 }, { 28, 7 }, { 29, 7 }, { 30, 7 }, { 31, 7 }, { 32, 7 }, { 33, 7 }, { 35, 7 }, { 1, 8 }, { 2, 8 }, { 4, 8 }, { 5, 8 }, { 6, 8 }, { 7, 8 }, { 8, 8 }, { 9, 8 }, { 10, 8 }, { 11, 8 }, { 12, 8 }, { 14, 8 }, { 15, 8 }, { 16, 8 }, { 17, 8 }, { 18, 8 }, { 19, 8 }, { 20, 8 }, { 21, 8 }, { 22, 8 }, { 23, 8 }, { 24, 8 }, { 25, 8 }, { 26, 8 }, { 27, 8 }, { 28, 8 }, { 29, 8 }, { 30, 8 }, { 31, 8 }, { 32, 8 }, { 33, 8 }, { 35, 8 }, { 1, 9 }, { 2, 9 }, { 4, 9 }, { 5, 9 }, { 6, 9 }, { 7, 9 }, { 8, 9 }, { 9, 9 }, { 10, 9 }, { 11, 9 }, { 12, 9 }, { 15, 9 }, { 16, 9 }, { 17, 9 }, { 18, 9 }, { 19, 9 }, { 20, 9 }, { 21, 9 }, { 22, 9 }, { 23, 9 }, { 24, 9 }, { 25, 9 }, { 26, 9 }, { 27, 9 }, { 28, 9 }, { 29, 9 }, { 30, 9 }, { 31, 9 }, { 32, 9 }, { 33, 9 }, { 35, 9 }, { 1, 10 }, { 2, 10 }, { 4, 10 }, { 5, 10 }, { 6, 10 }, { 7, 10 }, { 8, 10 }, { 9, 10 }, { 10, 10 }, { 11, 10 }, { 12, 10 }, { 13, 10 }, { 14, 10 }, { 15, 10 }, { 16, 10 }, { 17, 10 }, { 18, 10 }, { 19, 10 }, { 20, 10 }, { 35, 10 }, { 1, 11 }, { 2, 11 }, { 5, 11 }, { 6, 11 }, { 7, 11 }, { 8, 11 }, { 9, 11 }, { 10, 11 }, { 11, 11 }, { 12, 11 }, { 13, 11 }, { 14, 11 }, { 15, 11 }, { 16, 11 }, { 17, 11 }, { 18, 11 }, { 19, 11 }, { 35, 11 }, { 1, 12 }, { 2, 12 }, { 5, 12 }, { 6, 12 }, { 7, 12 }, { 1, 13 }, { 2, 13 } };
        // the above is a list of every pixel that needs to be changed when the car colour is changed
        public Login()
        {
            InitializeComponent();
            AllUsers = new Dictionary<string, User>();
            car1 = new Bitmap(Properties.Resources.myf1car);
            car2 = (Bitmap)car1.Clone();
            try
            {
                if (File.Exists("users.bin"))
                {
                    userFileStream = File.OpenRead("users.bin");
                }
                else
                {
                    userFileStream = File.Create("users.bin");
                }
                BinaryFormatter bf = new BinaryFormatter();
                while (userFileStream.Position < userFileStream.Length)
                {
                    User x = (User)bf.Deserialize(userFileStream);
                    AllUsers.Add(x.Username, x);
                }
                userFileStream.Close();
                userFileStream.Dispose();
                UserListBox1.Items.AddRange(AllUsers.Keys.ToArray());
                UserListBox2.Items.AddRange(UserListBox1.Items);
                player = new SoundPlayer( "music.wav"); // created the music player here to allow time for it to load before the main menu (I'm not sure if it's necessary)
                player.LoadAsync();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }


        private void ColourButton1_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCar(colorDialog1, car1);
                AllUsers[(string)UserListBox1.SelectedItem].Car = car1;
            }
            catch
            {
                MessageBox.Show("(You're not changing anyone's colour. Make sure you have a player selected first!)");
            }
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(car1, 20, 75, 37 * 3, 16 * 3);
            g.DrawImage(car2, 20, 150, 37 * 3, 16 * 3);
        }

        private void TwoPlayerButton_Click(object sender, EventArgs e)
        {
            User user1 = AllUsers[(string)UserListBox1.SelectedItem];
            User user2 = AllUsers[(string)UserListBox2.SelectedItem];
            if (user1.Equals(user2))
            {
                MessageBox.Show("Select 2 different players please!");
                return;
            }
            ActiveUsers = new User[2] { user1, user2 };
            MakeMainMenu();
        }

        private void ColourButton2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCar(colorDialog2, car2);
                AllUsers[(string)UserListBox2.SelectedItem].Car = car2;
            }
            catch
            {
                MessageBox.Show("(You're not changing anyone's colour. Make sure you have a player selected first!)");
            }
        }
        private void UpdateCar(ColorDialog cdialog, Bitmap car)
        {
            if (cdialog.ShowDialog() == DialogResult.OK)
            {
                Color chosenColor = cdialog.Color;
                for (int pixel = 0; pixel < 216; pixel++)
                {
                    car.SetPixel(CarColourCoords[pixel, 0], CarColourCoords[pixel, 1], chosenColor);
                }
                this.Invalidate(false);
            }
        }

        private void OnePlayerButton_Click(object sender, EventArgs e)
        {
            User user1 = AllUsers[(string)UserListBox1.SelectedItem];
            ActiveUsers = new User[1] { user1 };
            MakeMainMenu();
        }
        private void MakeMainMenu()
        {
            try
            {
                userFileStream = File.Open("users.bin", FileMode.Truncate); // wipes the file and writes to it the new, edited list of users
                BinaryFormatter bf = new BinaryFormatter();
                foreach (string key in UserListBox1.Items)
                {
                    bf.Serialize(userFileStream, AllUsers[key]);
                }
                userFileStream.Close();
                userFileStream.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }
            menuform = new MainMenu(ActiveUsers, player);
            this.Hide();
            menuform.ShowDialog();
            this.Show();
        }

        private void UserListBox_SelectedValueChanged(object sender, EventArgs e) // this event seems to trigger whenever the box is clicked, not just the value changed, which causes an error if no user is selected already, hence the try catch block
        {
            if (UserListBox1.SelectedItem != null)
            {
                OnePlayerButton.Visible = true;
                if (UserListBox2.SelectedItem != null)
                {
                    TwoPlayerButton.Visible = true;
                }
                else
                {
                    TwoPlayerButton.Visible = false;
                }
            }
            else
            {
                OnePlayerButton.Visible = false;
            }
            try
            {
                if (sender.Equals(UserListBox1))
                {
                    car1 = AllUsers[(string)UserListBox1.SelectedItem].Car;
                    this.Invalidate(false);
                }
                else if (sender.Equals(UserListBox2))
                {
                    car2 = AllUsers[(string)UserListBox2.SelectedItem].Car;
                    this.Invalidate(false);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Something bad happened when changing the user's car. (This error can happen when you click on the box, but not on a user. I don't know how to prevent it. If that's what you just did, then don't do that.)");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(UserCreateTextBox.Text))
            {
                try
                {
                    if (MessageBox.Show("Add player " + UserCreateTextBox.Text + "?", "New Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User newbie = new User(UserCreateTextBox.Text);
                        AllUsers.Add(newbie.Username, newbie);
                        UserListBox1.Items.Add(newbie.Username);
                        UserListBox2.Items.Add(newbie.Username);
                        UserCreateTextBox.Text = String.Empty;
                    }

                }
                catch (ArgumentException) // if the user already exists, there will already be a user in the dictionary with the same key. As dictionary keys must be unique, this throws an exception
                {
                    MessageBox.Show("This user already exists!");
                }
            }
            else
            {
                MessageBox.Show("You can't have a user with no username!");
            }
        }        
    }
}
