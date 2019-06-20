using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_One_Quiz
{
    class Question
    {
        string[] _ans;
        string _question;
        string _correctAns;

        public Question(string question, string[] ans, string correctAns)
        {
            _question = question;
            _ans = ans;
            _correctAns = correctAns;
        }
        public string[] Answers
        {
            get
            {
                return _ans;
            }
        }
        public string QuestionText
        {
            get
            {
                return _question;
            }
        }
        public string CorrectAns
        {
            get
            {
                return _correctAns;
            }
        }

        public bool CheckAnswer(string ans)
        {
            if (ans == _correctAns)
            {
                return true;
            }
            return false;
        }
        public void ShuffleAns()
        {
            int[] newOrder = new int[4]{5,5,5,5}; // otherwise they're all zero by default, which messses with the rest of the method and causes an infinite loop
            int ranNum; int index = 0;
            bool used;
            Random r = new Random();
            while (index < 4)
            {
                used = false;
                ranNum = r.Next(0, 4);
                foreach (int num in newOrder)
                {
                    if (ranNum == num)
                    {
                        used = true;
                        break;
                    }
                }
                if (!used)
                {
                    newOrder[index] = ranNum;
                    index += 1;
                }
            }
            string[] oldans = (string[])_ans.Clone();
            string[] newans = new string[4];
            for (int i = 0; i < 4; i++)
            {
                newans[i] = oldans[newOrder[i]];
            }
            _ans = newans;
        }
    }
}
