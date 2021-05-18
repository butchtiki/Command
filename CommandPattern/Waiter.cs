
namespace CommandPattern
{
    using System;

    public class Waiter : IWaiter
    {
        string orderName;
        public int count;

        public void TakeOrder(string orderName, int count)
        {
            if(orderName == null || orderName == string.Empty)
            {
                return;
            }

            this.orderName = orderName;
            this.count = count;
            Console.WriteLine("The order has been taken");
        }


    }
}
