using NUnit.Framework;
using ProcessOrderApplication;

namespace AssignmentProcessOrder
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCaseForPhisicalProduct()
        {
            var result = ProcessOrder.GetProductTypeAndName(new string[] { "Phisical Product" });
            Assert.Pass();
        }

        [Test]
        public void TestCaseForBook()
        {
            Assert.Pass();
        }

        [Test]
        public void TestCaseForMembership()
        {
            Assert.Pass();
        }

        [Test]
        public void TestCaseForUpgrade()
        {
            Assert.Pass();
        }

        [Test]
        public void TestCaseForVideo()
        {
            Assert.Pass();
        }

        [Test]
        public void TestCaseForVideoLearningToSki()
        {
            Assert.Pass();
        }
    }
}