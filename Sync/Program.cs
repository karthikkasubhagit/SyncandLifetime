using System.Threading;

namespace Sync
{
    internal class Program
    {
        private static object _lock = new();
        static void Main(string[] args)
        {
            new Thread(DoWriteWork).Start();

            for (int i = 0; i < 5; i++)
            {
                new Thread(DoReadWork).Start();

            }
        }

        public static void DoWriteWork()
        {
            lock(_lock)
            {
                Console.WriteLine($"Starting write thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
                Console.WriteLine($"Completing write thread {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public static void DoReadWork()
        {
            Console.WriteLine($"Starting read thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine($"Completing read thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
