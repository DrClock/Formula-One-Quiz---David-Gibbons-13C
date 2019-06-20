using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_One_Quiz
{
    public partial class GameScreen : Form
    {
        Stopwatch quizTimer, questionTimer1, questionTimer2; // much more accurate than a standard timer
        int countdown = 3;
        bool _sfx;
        public User[] _activeUsers;
        Car car1, car2;
        Wheel wheel1, wheel2;
        Label[] Q1AnsLabels, Q2AnsLabels;
        Question Q1, Q2;
        List<double> TPQList1, TPQList2;
        Random r = new Random();
        QuestionMaker QM1, QM2;
        string[] GoodText = new string[6] { "YEP", "CORRECT", "NICELY DONE", "NOT WRONG", "GOOD ONE", "BUTTERY SMOOTH" };
        string[] BadText = new string[6] { "NOPE", "NEGATORY", "COMPLETE FAIL", "WRONG", "(OUCH)", "NO DICE" };
        public GameScreen(User[] ActiveUsers, bool sfx)
        {
            InitializeComponent();
            _sfx = sfx;
            _activeUsers = ActiveUsers;
            quizTimer = new Stopwatch();
            questionTimer1 = new Stopwatch();
            QM1 = new QuestionMaker();
            Q1AnsLabels = new Label[4] { UpAnswer1, DownAnswer1, LeftAnswer1, RightAnswer1 };
            TPQList1 = new List<double>();
            car1 = new Car(Track1, _activeUsers[0].Car);
            wheel1 = new Wheel(WheelBox1);
            if (_activeUsers.Length == 2)
            {
                Q2AnsLabels = new Label[4] { UpAnswer2, DownAnswer2, LeftAnswer2, RightAnswer2 };
                questionTimer2 = new Stopwatch();
                car2 = new Car(Track2, _activeUsers[1].Car);
                TPQList2 = new List<double>();
                wheel2 = new Wheel(WheelBox2);
            }
            Cursor.Hide();
            if (_sfx)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Show();
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            bool? correct= null; // (datatype)? specifies a version of that datatype that can have the value null
            string key = e.KeyData.ToString();
            if (key == "Escape")
            {
                this.Close();
            }
            if (!CoverLabel1.Visible) 
            {
                switch (key)
                {
                    case "A": correct = Q1.CheckAnswer(LeftAnswer1.Text); break;
                    case "D": correct = Q1.CheckAnswer(RightAnswer1.Text); break;
                    case "W": correct = Q1.CheckAnswer(UpAnswer1.Text); break;
                    case "S": correct = Q1.CheckAnswer(DownAnswer1.Text); break;
                }
                if (correct!=null)
                {
                       if (correct==true)
                {
                    CoverLabel1.Text = GoodText[r.Next(0, 6)];
                    CoverLabel1.ForeColor = Color.Green;
                    car1.X += 2;
                    car1.Speed = 4;
                }
                else
                {
                    CoverLabel1.Text = BadText[r.Next(0, 6)];
                    CoverLabel1.ForeColor = Color.Red;
                    car1.X += 1;
                    car1.Speed = 1;
                    if (_sfx)
                    {
                        SystemSounds.Hand.Play();
                    }
                }
                CoverLabel1.Show();
                questionTimer1.Stop();
                TPQList1.Add(questionTimer1.Elapsed.TotalSeconds);
                return;
                }

            }
            if (!CoverLabel2.Visible)
            {
                switch (key)
                {
                    case "Left": correct = Q2.CheckAnswer(LeftAnswer2.Text); break;
                    case "Right": correct = Q2.CheckAnswer(RightAnswer2.Text); break;
                    case "Up": correct = Q2.CheckAnswer(UpAnswer2.Text); break;
                    case "Down": correct = Q2.CheckAnswer(DownAnswer2.Text); break;
                }
                if (correct != null)
                {
                    if (correct == true)
                    {
                        CoverLabel2.Text = GoodText[r.Next(0, 6)];
                        CoverLabel2.ForeColor = Color.Green;
                        car2.X += 2;
                        car2.Speed = 4;
                    }
                    else
                    {
                        CoverLabel2.Text = BadText[r.Next(0, 6)];
                        CoverLabel2.ForeColor = Color.Red;
                        car2.X += 1;
                        car2.Speed = 1;
                        if (_sfx)
                        {
                            SystemSounds.Hand.Play();
                        }
                    }
                    CoverLabel2.Show();
                    questionTimer2.Stop();
                    TPQList2.Add(questionTimer2.Elapsed.TotalSeconds);
                    return;
                }
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown <= 0)
            {
                CoverLabel1.Visible = false;
                CoverLabel1.Text = CoverLabel2.Text = "";
                if (_activeUsers.Length == 2)
                {
                    CoverLabel2.Visible = false;
                    QM2 = new QuestionMaker(); // creating this here allows the random objects in each QuestionMaker to use different seeds, as they are dependent on time
                }
                CountdownTimer.Stop();
                CountdownTimer.Dispose();
                quizTimer.Start();
                UpdateScreenTimer_Tick(this, EventArgs.Empty);// creates a new question instantly, eliminating the possibility that a button is pressed before the timer ticks, which would cause errors
                UpdateScreenTimer.Start();
                return;
            }
            CoverLabel1.Text = countdown.ToString();
            CoverLabel2.Text = CoverLabel1.Text;
            if (_sfx)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void UpdateScreenTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = String.Format("{0:00}:{1:00}:{2:000}", quizTimer.Elapsed.Minutes, quizTimer.Elapsed.Seconds, quizTimer.Elapsed.Milliseconds);
            if (car1.X % (Track1.Width / 10) == 0 && car1.Speed != 0) // (if the car has reached a question point and isn't already stopped)
            {

                Q1 = QM1.RandomQuestion();
                Q1.ShuffleAns();
                QuestionLabel1.Text = Q1.QuestionText;
                for (int i = 0; i < 4; i++)
                {
                    Q1AnsLabels[i].Text = Q1.Answers[i];
                }
                CoverLabel1.Visible = false;
                car1.Speed = 0;
                questionTimer1.Restart();
            }
            if (questionTimer1.Elapsed.Seconds >= 15)
            {
                questionTimer1.Reset();
                CoverLabel1.Text = "TOO SLOW";
                CoverLabel1.ForeColor = Color.Red;
                car1.X += 1;
                car1.Speed = 1;
                CoverLabel1.Show();
                questionTimer1.Stop();
                TPQList1.Add(questionTimer1.Elapsed.Seconds);
            }
            if (car1.X >= Track1.Width)
            {
                if (_activeUsers.Length == 2)
                {
                    End(_activeUsers[0], _activeUsers[1]);
                }
                else
                {
                    End();
                }
            }
            car1.Draw();
            wheel1.RotateImage(car1.Speed);
            if (_activeUsers.Length == 2) // I originally had try-catch blocks to handle 1 player, but this seemed to be taxing on the computer as exceptions were thrown every 50ms
            {
                if (car2.X % (Track2.Width / 10) == 0 && car2.Speed != 0)
                {
                    Q2 = QM2.RandomQuestion();
                    Q2.ShuffleAns();
                    QuestionLabel2.Text = Q2.QuestionText;
                    for (int i = 0; i < 4; i++)
                    {
                        Q2AnsLabels[i].Text = Q2.Answers[i];
                    }
                    CoverLabel2.Visible = false;
                    car2.Speed = 0;
                    questionTimer2.Restart();
                }
                if (questionTimer2.Elapsed.Seconds >= 15)
                {
                    questionTimer2.Reset();
                    CoverLabel2.Text = "TOO SLOW";
                    CoverLabel2.ForeColor = Color.Red;
                    car2.X += 1;
                    car2.Speed = 1;
                    CoverLabel2.Show();
                    TPQList2.Add(questionTimer2.Elapsed.Seconds);
                }
                if (car2.X >= Track2.Width)
                {
                    End(_activeUsers[1], _activeUsers[0]);
                }

                car2.Draw();
                wheel2.RotateImage(car2.Speed);
            }
        }

        void End(User winner, User loser) // used in 2p mode
        {
            double tpq1 = 0, tpq2 = 0;
            foreach (double qtime in TPQList1)
            {
                tpq1 += qtime;
            }
            tpq1 = tpq1 / TPQList1.Count;
            foreach (double qtime in TPQList2)
            {
                tpq2 += qtime;
            }
            tpq2 = tpq2 / TPQList2.Count;
            _activeUsers[0].CalcTPQ(tpq1);
            _activeUsers[1].CalcTPQ(tpq2);
            quizTimer.Stop();
            questionTimer1.Stop();
            questionTimer2.Stop();
            winner.AddGame(quizTimer.Elapsed.TotalSeconds);
            loser.AddGame();
            CoverLabel1.Text = CoverLabel2.Text = winner.Username + " Wins!";
            CoverLabel1.ForeColor = CoverLabel2.ForeColor = Color.White;
            UpdateScreenTimer.Stop();
            CoverLabel1.Show();
            CoverLabel2.Show();
            countdown = 0;
            EndWaitTimer.Start();
        }
        void End() // used in 1p mode
        {
            double tpq1 = 0;
            foreach (double qtime in TPQList1)
            {
                tpq1 += qtime;
            }
            tpq1 = tpq1 / TPQList1.Count;
            _activeUsers[0].CalcTPQ(tpq1);
            quizTimer.Stop();
            questionTimer1.Stop();
            UpdateScreenTimer.Stop(); //stopping the program from checking if the user is finished
            _activeUsers[0].AddGame(quizTimer.Elapsed.TotalSeconds); //writing to file
            CoverLabel1.Text = CoverLabel2.Text = "You did it!";
            CoverLabel1.ForeColor = CoverLabel2.ForeColor = Color.White;
            CoverLabel1.Show();
            CoverLabel2.Show();
            countdown = 0;
            EndWaitTimer.Start();
        }

        private void EndWaitTimer_Tick(object sender, EventArgs e)
        {
            countdown += 1; // waits 4 seconds before closing the form, so the closing message can be viewed
            if (countdown == 4)
            {
                this.Close();
            }
        }
    }
}
