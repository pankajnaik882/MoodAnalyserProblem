namespace MoodAnalyserDemo
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Program.ErrorFun();
        }

        public static void ErrorFun()
        {

            Console.WriteLine("Enter the Mood Happy or Sad: ");
            string mood = Console.ReadLine();
            try
            {
                if (mood == "Happy")
                {
                    Console.WriteLine("Happy");
                }
                if(mood=="Sad")
                {
                    Console.WriteLine("Sad");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}