using System.Reflection;

namespace MoodAnalyserDemo
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            
            //Type t = GetType(m1);
            Type t = typeof(MoodAnalyser);
            ConstructorInfo[] constructorInfos = t.GetConstructors(BindingFlags.Public|BindingFlags.Instance);
            foreach(ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo);
            }
        }

    }
}