using System;

namespace Classlib
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Ifscore8_returnA()
        {
            Student s = new Student();
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Ifscore7_returnB()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Ifscore_returnA()
        {
            Student s = new Student();
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
    }
}
