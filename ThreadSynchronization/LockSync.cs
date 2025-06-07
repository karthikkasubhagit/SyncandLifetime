namespace ThreadSynchronization
{
    public class LockSync
    {
        public static Object _lock = new Object();
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(DoWriteWork);
                t1.Start();
            }
        }
        public static void DoWriteWork()
        {
            
                lock (_lock)
                {
                    Console.WriteLine("Waiting to write");
                    Thread.Sleep(5000);
                    Console.WriteLine("Completed writing.");
                }
        }
    }

   
    }
