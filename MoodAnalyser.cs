using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        string mood; 
       public void MoodException(string mood) 
        {
            if(mood == null) 
            {
                Console.WriteLine("Invalid Mood");
                throw new Exception("Invalid Mood Found Exception");
            }
            else if(mood == "")
            {
                throw new Exception("Invalid Empty Mood Found Exception");
            }
            else if(mood == "Happy" || mood == "happy")
            {
                Console.WriteLine("Happy Mood");
            }
            else if(mood == "Sad" || mood == "sad")
            {
                Console.WriteLine("Sad Mood");
            }
            else 
            {
                Console.WriteLine("The mood is " + mood);
            }
        }
    }
}
