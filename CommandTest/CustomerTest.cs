namespace CommandTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommandPattern;
    using CommandTest.Stubs;
    using Moq;

    [TestClass]
    public class CustomerTest
    {
        Customer target;
 
        [TestInitialize]
        public void Setup()
        {
            this.target = new Customer();
        }

        [TestMethod]
        public void ChooseOrder_ValidInput_NoException()
        {
            Mock<ICommand> command = new Mock<ICommand>();
            this.target.ChooseOrder(command.Object);
            command.Verify(x => x.Execute(),Times.Once);
        }

        [TestMethod]
        public void ChooseOrder_InvalidInput_ExceptionThrown()
        {
            Mock<ICommand> command = new Mock<ICommand>();
            target.ChooseOrder(command.Object);
            command.Verify(x => x.Execute(), Times.Never);
        }

        [TestMethod]
        public void Order_CommandIsNotNull_CommandExecuted()
        {
            Mock<ICommand> command = new Mock<ICommand>();
            this.target.ChooseOrder(command.Object);
            this.target.Order();
            command.Verify(x => x.Execute(), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Order_CommandIsNull_ExceptionThrown()
        {
            this.target.Order();
        }


    }
}
