using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserDemo;
using System.Text;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void MoodAnalyser_Success()
        {
            // Arrange
            //MoodAnalyser m1 = new MoodAnalyser("happy");
            MoodAnalyser m1 = new MoodAnalyser("Sad");

            // Act
            var result = m1.mood();

            // Assert
            Assert.AreEqual("Sad", result);



        }
       
    }
}