using System;
namespace CommandPattern
{
    public class Order : ICommand
    {
        string orderName;
        int count;
        IWaiter waiter;

        public Order(IWaiter reciever, string orderName, int count)
        {
            this.orderName = orderName;
            this.count = count;
            this.waiter = reciever;
        }

        public void Execute()
        {
            this.waiter.TakeOrder(orderName, count);
        }
    }
}
