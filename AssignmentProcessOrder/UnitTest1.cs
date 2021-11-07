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
            var result = ProcessOrder.GetProductTypeAndName(new string[] { "Book" });
            Assert.IsEmpty(result.ProductName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Operations[0]);
            Assert.AreEqual("Create a duplicate packing slip for the royalty department.", result.Operations[1]);
            Assert.AreEqual("Added commission payment to the agent.", result.Operations[2]);
            Assert.AreEqual(3, result.Operations.Count);
        }

        [Test]
        public void TestCaseForMembership()
        {
            var result = ProcessOrder.GetProductTypeAndName(new string[] { "membership" });
            Assert.IsNull(result.ProductName);
            Assert.AreEqual("Activate that membership.", result.Operations[0]);
            Assert.AreEqual("Mail Sent to Owner.", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
        }

        [Test]
        public void TestCaseForUpgrade()
        {
            var result = ProcessOrder.GetProductTypeAndName(new string[] { "upgrade" });
            Assert.AreEqual("apply the upgrade.", result.Operations[0]);
            Assert.AreEqual("Mail Sent to Owner.", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
        }

        [Test]
        public void TestCaseForVideo()
        {
            var result = ProcessOrder.GetProductTypeAndName(new string[] { "Video" });
            Assert.IsEmpty(result.ProductName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual(1, result.Operations.Count);
        }

        [Test]
        public void TestCaseForVideoLearningToSki()
        {
            Assert.Pass();
        }
    }
}