using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_One_Quiz
{
    class QuestionMaker
    {
        Random rand = new Random();
        List<int> _usedQuestions = new List<int>();
        static Question[] _questions = new Question[20]{
            new Question("The most titles achieved by one driver is 7. Who holds this record?",new string[4]{"Ayrton Senna","Michael Schumacher","Sebastian Vettel","Fernando Alonso"},"Michael Schumacher"),
            new Question("In 1970, a driver was killed during a practice, yet still won the championship 2 rounds later. Who was this?",new string[4]{"Ayrton Senna", "Jochen Rindt","Niki Lauda","Jackie Stewart"},"Jochen Rindt"),
            new Question("Who won the 2007 Drivers Championship?",new string[4]{"Kimi Räikkönen","Michael Schumacher","Lewis Hamilton","Fernando Alonso"},"Kimi Räikkönen"),
            new Question("Who was the very first Drivers Championship Winner in 1950?",new string[4]{"Nino Farina","Juan Manuel Fangio","Alberto Ascari","Luigi Fagioli"},"Nino Farina"),
            new Question("Who was the youngest ever Driver World champion at the age of 24?",new string[4]{"Fernando Alonso","Lewis Hamilton","Sebastian Vettel","Kimi Räikkönen"},"Fernando Alonso"),
            new Question("Which team won the very first Constructors Championship?",new string[4]{"Ferrari","Vanwall","Cooper-Climax","BRM"},"Vanwall"),
            new Question("Which team holds the record for most Constructors Championship titles?",new string[4]{"Ferrari","McLaren","Williams","Honda"},"Ferrari"),
            new Question("Who currently holds the \'record\' for least amount of points earned in their career?",new string[4]{"Kevin Magnussen","Wolfgang von Trips","Carlos Pace","Lorenzo Bandini"},"Kevin Magnussen"),
            new Question("Which of these teams has gained 0 points during their lifetime?",new string[4]{"Spyker","Trevis","Bugatti","Marussia"},"Bugatti"),
            new Question("How many drivers have died during a Grand Prix race?",new string[4]{"4","24","32","17"},"24"),
            new Question("What team did Lewis Hamilton move to in 2013?",new string[4]{"Ferrari","McLaren","Mercedes","Force India"},"Mercedes"),
            new Question("On average, how much does an F1 car weigh?",new string[4]{"550kg","950kg","300kg","750kg"},"550kg"),
            new Question("Most road car engines last 20 years. How long do F1 car engines last?",new string[4]{"2 weeks","2 hours","2 days","2 months"},"2 hours"),
            new Question("Road car tyres last for up to 100,000km. How long can F1 racing tyres last?",new string[4]{"120km","40km","300km","500km"},"120km"),
            new Question("As a result of extreme G-force and temperature, how much weight can a driver lose?",new string[4]{"4kg","10kg","1kg","7.5kg"},"4kg"),
            new Question("Who was the first driver to win multiple Championships?",new string[4]{"Nino Farina","Juan Manuel Fangio","Alberto Ascari","Jack Brabham"},"Alberto Ascari"),
            new Question("What does a black flag being waved with a driver number on it signify?",new string[4]{"Warning","Disqualification","Mechanical issue","Give way to driver behind"},"Disqualification"),
            new Question("In which year was Ayrton Senna's famous yet fatal crash?",new string[4]{"1993","1994","1991","1992"},"1994"),
            new Question("Which driver has entered the most races?",new string[4]{"Michael Schumacher","Rubens Barrichello","Jenson Button","Jarno Trulli"},"Rubens Barrichello"),
            new Question("Who holds the record for most consecutive race wins?",new string[4]{"Sebastian Vettel","Alberto Ascari","Michael Schumacher","Nigel Mansell"},"Sebastian Vettel")};

        public Question RandomQuestion()
        {
            bool used = true;
            int index = 0;
            while (used)
            {
                index = rand.Next(0, 20);
                used = false;
                foreach (int i in _usedQuestions)
                {
                    if (i == index)
                    {
                        used = true;
                        break;
                    }
                }
            }
            _usedQuestions.Add(index);
            return _questions[index];
        }
    }
}
