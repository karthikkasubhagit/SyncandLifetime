namespace Lifetime
{
    public class TransactionClass : ITransaction
    {
        public Guid Guid { get; set; }

        public TransactionClass()
        {
            Guid = Guid.NewGuid();
        }
    }

    public interface ITransaction
    {
        public Guid Guid { get; set; }
    }

}
