using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodePractice.Tests
{
    [TestFixture]
    public class RemoveChar
    {
        [Test]
         public void IsCharacterRemoved()
        {
            var source = "This is the string";
            var removechar = "s";

            var result = Program.RemoveCharacter(source, removechar);

            Assert.AreEqual("This is the string", result);

        }
        
    }
}
