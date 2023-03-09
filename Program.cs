using System.Dynamic;
using System.Reflection;

namespace MoodAnalyserDemo
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
           Console.WriteLine("Enter the Mood : ");
            string mood = Console.ReadLine();
            MoodAnalyser m1 = new MoodAnalyser(mood);

            Type t = typeof(MoodAnalyser);
            ConstructorInfo[] info = t.GetConstructors(BindingFlags.Public|BindingFlags.Instance);
            foreach (ConstructorInfo info2 in info)
            {
                Console.WriteLine(info2.Name);
            }
               
         /* try
            {
                MoodAnalyser m1 = new MoodAnalyser();
                m1.check(mood);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            } */
        }

    }
}