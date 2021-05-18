using System;
namespace CommandPattern
{
    public class Customer
    {
        ICommand command;

        public void ChooseOrder(ICommand command)
        {
            if(command == null)
            {
                throw new Exception();
            }
            this.command = command;
        }

        public void Order()
        {
            this.command.Execute();
        }
    }
}
