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
            Assert.IsEmpty(result.ProductName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Operations[0]);
            Assert.AreEqual("Added commission payment to the agent.", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
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