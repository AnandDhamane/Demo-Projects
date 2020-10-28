using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnotherMethod();

            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            //Thread threadOne = new Thread(Threads.PrintOneToFifty);
            //Thread threadTwo = new Thread(Threads.PrintOneToFiveHundred);
            //Thread threadThree = new Thread(Threads.PrintOneToFiveThousand);

            Threads.PrintOneToFifty();
            Threads.PrintOneToFiveHundred();
            Threads.PrintOneToFiveThousand();

            //threadOne.Start();
            //threadTwo.Start();
            //threadThree.Start();

            stopWatch.Stop();
            Console.WriteLine("Elapsed MilliSeconds : {0}", stopWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        public void TT()
        {
            Thread threadOne = new Thread(Threads.PrintOneToFifty);
            Thread threadTwo = new Thread(Threads.PrintOneToFiveHundred);
            Thread threadThree = new Thread(Threads.PrintOneToFiveThousand);

            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();
        }

        public static async void AnotherMethod()
        {
            var result = await CookEggs(); //This method will execute first & then CookKhichadi() & CookDal() methods.

            CookKhichadi();
            CookDal();
        }

        public static async Task<bool> CookEggs()
        {
            bool result = false;

            await Task.Run(() =>
            {
                Console.WriteLine("Cooking eggs started...");
                Thread.Sleep(5000);
                Console.WriteLine("Eggs cooked...");
                result = true;
            });
            return result;
        }

        public static async void CookKhichadi()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Cooking khichadi started...");
                Thread.Sleep(5000);
                Console.WriteLine("Khichadi cooked...");
            });
        }

        public static async void CookDal()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Cooking Dal started...");
                Thread.Sleep(7000);
                Console.WriteLine("Dal cooked...");
            });
        }
    }
}
