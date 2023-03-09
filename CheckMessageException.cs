using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class CheckMessageException : Exception
    {
        public CheckMessageException(string message) : base(message)
        {
            
        }
    }
}
