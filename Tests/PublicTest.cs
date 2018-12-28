using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace VowelCount.Public
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCountTask.GetVowelCount("abracadabra"));
        }

        [Test]
        public void TestCase2()
        {
            Assert.AreEqual(0, VowelCountTask.GetVowelCount("kkkwhfk"));
        }

        [Test]
        public void TestCase3()
        {
            Assert.AreEqual(3, VowelCountTask.GetVowelCount("aaa"));
        }
    }
}
