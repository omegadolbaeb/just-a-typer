using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Typer_Pre_Alpha
{
    public delegate void ShowText(string word,int score);

    public sealed class Gameplay
    {
        public bool GameOver { get; set; }
        string Word { get; set; }
        string[] dic;
        public string answer;
        public int timer;
        public int score { get; set; }
        private int MaxTimer { get; set; }

        public void Start()
        {
            MaxTimer = 0;
            timer = Settings.timerCount;
            score = 0;
            dic = new string[Settings.wordCount];
            Fillup();
        }

        private void Fillup()
        {
            StreamReader reader = new StreamReader("Dictionary.txt");
            for(int i = 0;i < Settings.wordCount;i++)
            {
                dic[i] = reader.ReadLine();
            }
        }

        public void Process(ShowText method)
        {
            
            score++;
            if (score != 80)
            {
                timer = Settings.timerCount - score;
            }
            else
            {
                timer = Settings.timerCount - 80;
            }
            Word = Pick().ToLower();
            method(Word,score);
        }

        private string Pick()
        {
            Random r = new Random();
            string word = dic[r.Next(0, dic.Length)];
            return word;
        }

        public bool CheckAnswer()
        {
            timer--;
            if(timer == MaxTimer)
            {
                GameOver = true;
            }
            if (answer == Word)
                return true;
            else return false;
        }

        public bool CheckCorrect()
        {
            if (answer != null)
            {
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (answer[i] == Word[i] && Word.Length >= answer.Length)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else { return true; }
        }
    }
}
