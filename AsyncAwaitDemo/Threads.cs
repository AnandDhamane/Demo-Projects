using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class Threads
    {
        //public static void PrintOneToFifty()
        //{
        //    Console.WriteLine("PrintOneToFifty - Execution started.");

        //    for (int i = 1; i < 50; i++)
        //    {
        //        Console.WriteLine("PrintOneToFifty : {0}", i);
        //    }

        //    Console.WriteLine("PrintOneToFifty - Execution ended.");
        //}

        //public static void PrintOneToFiveHundred()
        //{
        //    Console.WriteLine("PrintOneToFiveHundred - Execution started.");

        //    for (int i = 1; i < 500; i++)
        //    {
        //        Console.WriteLine("PrintOneToFiveHundred : {0}", i);
        //    }

        //    Console.WriteLine("PrintOneToFiveHundred - Execution ended.");
        //}

        //public static void PrintOneToFiveThousand()
        //{
        //    Console.WriteLine("PrintOneToFiveThousand - Execution started.");

        //    for (int i = 1; i < 5000; i++)
        //    {
        //        Console.WriteLine("PrintOneToFiveThousand : {0}", i);
        //    }

        //    Console.WriteLine("PrintOneToFiveThousand - Execution ended.");
        //}

        public static async void PrintOneToFifty()
        {
            Console.WriteLine("PrintOneToFifty - Execution started.");

            await Task.Run(() =>
            {
                for (int i = 1; i < 50; i++)
                {
                    Console.WriteLine("PrintOneToFifty : {0}", i);
                }
            });

            Console.WriteLine("PrintOneToFifty - Execution ended.");
        }

        public static async void PrintOneToFiveHundred()
        {
            Console.WriteLine("PrintOneToFiveHundred - Execution started.");

            await Task.Run(() =>
            {
                for (int i = 1; i < 500; i++)
                {
                    Console.WriteLine("PrintOneToFiveHundred : {0}", i);
                }
            });

            Console.WriteLine("PrintOneToFiveHundred - Execution ended.");
        }

        public static async void PrintOneToFiveThousand()
        {
            Console.WriteLine("PrintOneToFiveThousand - Execution started.");

            await Task.Run(() =>
            {
                for (int i = 1; i < 5000; i++)
                {
                    Console.WriteLine("PrintOneToFiveThousand : {0}", i);
                }
            });

            Console.WriteLine("PrintOneToFiveThousand - Execution ended.");
        }
    }
}
