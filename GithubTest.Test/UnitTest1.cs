using Githubtest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Callback from test method two", TestClassTwo.TestMethod());
        }
    }
}
