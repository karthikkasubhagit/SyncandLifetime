namespace Lifetime
{
    public class AnotherService: IAnotherService
    {
        private readonly ITransaction _transaction;

        public AnotherService(ITransaction transaction)
        {
            _transaction = transaction;
        }

        public Guid GetId()
        {
            return _transaction.Guid;
        }
    }

    public interface IAnotherService
    {
        Guid GetId();
    }
}
