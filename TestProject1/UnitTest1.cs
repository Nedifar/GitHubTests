using StudingGitHubTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass testClass = new();

            bool b = testClass.GetTrue();

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestClass testClass = new();

            bool b = testClass.GetTrue();

            Assert.IsTrue(b);
        }
    }
}