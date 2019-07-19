using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer_Pre_Alpha
{
    public class Control
    {
        public static Gameplay gm;
        public static Design des;
        public static ShowText method;

        public static void Play()
        {
            method = new ShowText(des.Shows);
            gm.Start();
            NewStep();
        }

        public static bool Answer(string ans)
        {
            gm.answer = ans.ToLower();
            NewStep();
            if(gm.GameOver == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Stop()
        {
            gm.GameOver = true;
        }

        private static void NewStep()
        {
            if(gm.CheckAnswer())
            {
                gm.timer = 0;
                gm.Process(method);
            }
        }

        public static bool ChangeColor()
        {
            return gm.CheckCorrect();
        }
    }
}
