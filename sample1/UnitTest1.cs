using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace sample1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "shubham";

            Assert.AreEqual("shubham",s);
        }
    }
}
