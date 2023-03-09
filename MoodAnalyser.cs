using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string Fun(string mood)
        {
            try
            {
                if (mood == "Happy")
                {
                    return "HAPPY";
                }
                else if (mood == "Sad")
                {
                    return "SAD";
                }
                else if (mood == "")
                {
                    return "HAPPY";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
             return ex.ToString();
            }
        }
    }
}
