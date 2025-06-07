namespace ThreadSynchronization
{
    public class SemaphoreSync
    {


        private static SemaphoreSlim s_semaphore = new SemaphoreSlim(2, 2);

        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(DoWorkWriteAsync).Start();
            }
        }

        public void DoWorkWriteAsync()
        {
            s_semaphore.WaitAsync();
            Console.WriteLine("Writing has started.");
            Thread.Sleep(3000);
            Console.WriteLine("Writing completed.");
            s_semaphore.Release();


        }
    }
}
