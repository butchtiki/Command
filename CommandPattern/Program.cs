using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter1 = new Waiter();
            Order myorder = new Order(waiter1, "BeefStew", 2);
            Customer firstCustomer = new Customer();
            firstCustomer.ChooseOrder(myorder);
            firstCustomer.Order();
        }
    }
}
