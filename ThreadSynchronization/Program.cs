namespace ThreadSynchronization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MutexSync m = new();
            m.Run();
        }
    }
}
