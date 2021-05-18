namespace CommandPattern
{
    public interface IWaiter
    {
        void TakeOrder(string orderName, int count);
    }
}