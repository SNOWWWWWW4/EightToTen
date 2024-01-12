using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Service.MagicBall
{
    public class MagicBallService : IMagicBallService
    {
        public string MagicBall(string input)
        {
            Random randClass = new Random();
            int picked = randClass.Next(0,9);

            string[] advice = new string[8];
            advice[0] = "It's better to not tell you";
            advice[1] = "Definitely";
            advice[2] = "Undetermined";
            advice[3] = "Very doubtful";
            advice[4] = "Ask again later";
            advice[5] = "Most likely";
            advice[6] = "No";
            advice[7] = "Yes";

            return advice[picked];

        }
    }
}