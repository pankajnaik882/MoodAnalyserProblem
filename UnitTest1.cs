using MoodAnalyserDemo;
namespace RelectionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyser_Success()
        {
            //Arrange
            string mood = "";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "No Such Class Error";

            //Act
            string actualOutput = m1.check(mood);
            Console.WriteLine(actualOutput);


            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        public void MoodAnalyser()
        {
            //Arrange
            string mood = "";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "No Such Method Error";

            //Act
            string actualOutput = m1.check(mood);
            Console.WriteLine(actualOutput);


            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}