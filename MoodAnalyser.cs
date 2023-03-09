using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string Mood(string m)
        {
            if(m == "Happy")
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
