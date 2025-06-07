namespace ThreadSynchronization
{
    /*
      The advantage of using a Mutex over AutoResetEvent is that only the thread that acquires the Mutex
      has the ability to release it. This ensures that the Mutex cannot be released by another thread,
      such as the main thread or the caller thread, which is a limitation of AutoResetEvent.
     */
    public class MutexSync
    {
        private static Mutex _mutex = new Mutex();


        public void Run()
        {
            for (int i = 1; i < 5; i++)
            {
                 new Thread(DoWorkWrite).Start();

            }
        }

        public void DoWorkWrite()
        {
            _mutex.WaitOne();

            Console.WriteLine($"Started writing to a file from thread.. {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(3000);

            Console.WriteLine($"Completed writing from thread {Thread.CurrentThread.ManagedThreadId}");

            _mutex.ReleaseMutex();
        }
    }
}
