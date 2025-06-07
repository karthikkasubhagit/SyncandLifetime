namespace ThreadSynchronization
{
    public class AutoResetSyc
    {
        private static AutoResetEvent a = new AutoResetEvent(false);

        public void Run()
        {
            
        }

        public void DoWriteWork()
        {

            a.Reset();

            Console.WriteLine("Started writing..");
            Thread.Sleep(2000);

            Console.WriteLine("Completed Writing..");
            a.Set();
        }

        public void DoReadWork()
        {
            a.WaitOne();
            Console.WriteLine("Started Reading..");

            Thread.Sleep(1000);
            Console.WriteLine("Completed reading");
        }
    }
}
