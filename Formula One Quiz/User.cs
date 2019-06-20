using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Formula_One_Quiz
{
    [Serializable]
    public class User
    {
        string _username;
        int _gamesPlayed, _wins;
        double _tpq, _bestTime;
        Bitmap _Car;
         
        public User(string username)
        {
            _username = username;
            _gamesPlayed = 0;
            _wins = 0;
            _tpq = 0;
            _bestTime = double.PositiveInfinity;
            _Car = Properties.Resources.myf1car;
        }

        public void AddGame(double wintime)
        {
            _gamesPlayed+=1;
            _wins+=1;

            if (wintime < _bestTime)
            {
                _bestTime = wintime;
            }
            UpdateUser();
        }
        public void AddGame()
        {
            _gamesPlayed += 1;
            UpdateUser();
        }

        public double Games
        {
            get
            {
                return _gamesPlayed;
            }
        }

        public Bitmap Car
        {
            get
            {
                return _Car;
            }
            set
            {
                _Car = value;
            }
        }

        public double Wins
        {
            get
            {
                return _wins;
            }
        }

        public double CalcWinLoss()
        {
            try
            {
                double winloss = (double)(_wins) / (double)(_gamesPlayed - _wins);
                return Math.Round(winloss, 2);
            }
            catch (DivideByZeroException)
            {
                return _wins;
            }
        }

        public void CalcTPQ(double gametpq)
        {
            if (_tpq == 0)
            {
                _tpq = gametpq;
                return;
            }
            double sumtime = (_tpq * _gamesPlayed) + gametpq;
            _tpq = sumtime / (_gamesPlayed+1);
        }

        public double TPQ
        {
            get
            {
                return _tpq;
            }
        }

        public double BestTime
        {
            get
            {
                return _bestTime;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        private void UpdateUser()
        {
            try
            {
                Stream sr = File.Open("users.bin", FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bool found = false;
                User readUser;
                while (sr.Position < sr.Length && found == false)
                {
                    long pos = sr.Position;
                    readUser = (User)bf.Deserialize(sr);
                    if (readUser.Username.CompareTo(this.Username) == 0)
                    {
                        found = true;
                        sr.Seek(pos, SeekOrigin.Begin);
                        bf.Serialize(sr, this);
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving user");
                return;
            }
        }
    }
}
