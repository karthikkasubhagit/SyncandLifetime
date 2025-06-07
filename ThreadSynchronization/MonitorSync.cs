namespace ThreadSynchronization
{
    public class MonitorSync
    {
        private static object _lock = new object();
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(WriteAsync).Start();
            }
        }



        public static void WriteAsync()
        {
            try
            {
                Monitor.Enter(_lock);

                Console.WriteLine("Waiting to write.");
                Thread.Sleep(2000);
                Console.WriteLine("Completed writing.");
                // Monitor.Exit(_lock);
                throw new Exception("Known exception.");
            }
            catch (Exception e)
            {
                // Console.WriteLine(e);
                //   throw;
            }
            finally
            {
                Monitor.Exit(_lock);
            }

        }

    }
}
