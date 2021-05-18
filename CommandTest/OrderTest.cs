namespace CommandTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommandPattern;
    using CommandTest.Stubs;
    using Moq;

    [TestClass]
    public class OrderTest
    {
        Order target;
        string orderName;
        int count;
        Mock<IWaiter> waiter;

        [TestInitialize]
        public void Setup()
        {
            waiter = new Mock<IWaiter>();
            this.orderName = "BeefSteak";
            this.count = 1;
            this.target = new Order(waiter.Object, orderName, count);
        }

        [TestMethod]
        public void Execute_WaiterIsNotNull_TakenOrder()
        {
            waiter.Setup(x => x.TakeOrder(orderName, count));
            this.target.Execute();
            waiter.Verify(x => x.TakeOrder(orderName, count), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Execute_WaiterIsNull_ExceptionThrown()
        {
            this.target = new Order(null, orderName, count);
            this.target.Execute();
        }

    }
}
