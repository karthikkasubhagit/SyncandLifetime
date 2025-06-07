using System.Threading;

namespace ThreadSynchronization
{
    public class ManualResetSync
    {
        static ManualResetEvent m = new ManualResetEvent(false);
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(DoWriteWork).Start();
            }


            Console.ReadKey();
        }

 /*ManualResetEvent and AutoResetEvent are synchronization primitives used for thread signaling.
The key difference lies in how they handle the signal state:

- ManualResetEvent:
Once signaled (using Set()), it remains signaled until explicitly reset (using Reset()).
This allows multiple threads to proceed after the signal is set.
Example: Useful when multiple threads need to wait for a common signal to start processing.

- AutoResetEvent:
Once signaled, it automatically resets to the non-signaled state after releasing a single waiting thread.
Example: Useful for scenarios where threads need to proceed one at a time, such as sequential access to a resource.

In summary, ManualResetEvent requires manual control to reset the signal, while AutoResetEvent handles signaling automatically for individual threads.*/

public static void DoWriteWork()
{
        Console.WriteLine("Waiting to write");
        m.WaitOne();
        Thread.Sleep(5000);
        Console.WriteLine("Completed writing.");
        m.Set();
}



}
}
