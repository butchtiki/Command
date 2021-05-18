namespace CommandTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommandPattern;

    [TestClass]
    public class WaiterTest
    {
        Waiter target;

        [TestInitialize]
        public void Setup()
        {
            target = new Waiter();
        }

        [TestMethod]
        public void TakeOrder_InvalidOrderName_OrderNotAddedToCount()
        {
            var oldCount = target.count;

            target.TakeOrder("", 1);
            var newCount = target.count;

            Assert.AreEqual(oldCount, newCount);
        }

        [TestMethod]
        public void TakeOrder_ValidInput_OrderAddedToCount()
        {
            var orderCount = 1;
            var oldCount = target.count;

            target.TakeOrder("BeefTapa", orderCount);
            var newCount = target.count;

            Assert.IsTrue(newCount == oldCount + orderCount);
        }
        
    }
}
