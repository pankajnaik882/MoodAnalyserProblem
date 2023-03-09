using MoodAnalyserDemo;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mood_Success()
        {
            //Arrange
            string h = "Sad";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "SAD";

            //Act 
            string actualOutput = m1.Mood(h);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);


        }
    }
}