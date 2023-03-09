using MoodAnalyserDemo;

namespace Operation
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void MoodAnalyser_Success()
        {
            //Arrange
            string s1 = "";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "HAPPY";

            //Act
            string actualOutput = m1.Fun(s1);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}