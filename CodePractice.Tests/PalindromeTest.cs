using CodePractice;
using NUnit.Framework;

namespace CodePractice.Tests
{
    [TestFixture]
    public class PalindromeTest
    {
       
       [Test]
        public void IsPalindrome1Test()
        {
            var sourceString = "civic";
            var result = Program.IsPalindrome1(sourceString);

            Assert.AreEqual(true, result);
        }   

        [Test]
        public void IsPalindrome2Test()
        {
            var sourceString = "civic";
            var result = Program.IsPalindrome2(sourceString);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome3Test()
        {
            var sourceString = "civic";
            var result = Program.IsPalindrome3(sourceString);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome4Test()
        {
            var sourceString = "rotor";
            var result = Program.IsPalindrome4(sourceString);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindromeRecursiveTest()
        {
            var sourceString = "rotor";
            var result = Program.IsPalindromeRecursive(sourceString);

            Assert.AreEqual(true, result);
        }



    }
}
