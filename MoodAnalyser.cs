using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string n;
        public MoodAnalyser(string name) 
        {
            this.n = name;
            Console.WriteLine(n);   
        }
       
        public string mood()
        {
            return this.n;
        }
    }
}
