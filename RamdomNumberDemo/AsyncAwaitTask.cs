using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamdomNumberDemo
{
    internal static class AsyncAwaitTask
    {
        //Example #1
        public static async Task Method1Async()
        {
            await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("This is method 1: " + i);
                        Task.Delay(250).Wait();
                    }
                }
            );

        }

        public static async Task Method2Async()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("This is method 2: " + i);
                    Task.Delay(250).Wait();
                }
            });

        }

        //Example #2
        public static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();
            Console.WriteLine("4. Take the cups out");
            Console.WriteLine("5. Put tea in cups");

            var water = await boilingWater;
            var tea = $"6. Pour {water} in cups";
            Console.WriteLine(tea);

            return tea;
        }

        public static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("ASYNC execution of the process\n");
            Console.Write("1. Start the kettle\n");
            Console.Write("2. Waiting for the kettle\n");
            await Task.Delay(2000);
            Console.Write("3. Kettle finished boiling\n");

            return "water";
        }

        public static string MakeTea()
        {
            var water = BoilWater();            
            Console.WriteLine("4. Take the cups out");
            Console.WriteLine("5. Put tea in cups");

            var tea = $"6. Pour {water} in cups";
            Console.WriteLine(tea);
            Console.WriteLine("\n");

            return tea;
        }

        public static string BoilWater()
        {
            Console.WriteLine("Normal (SYNC) execution of the process\n");
            Console.Write("1. Start the kettle\n");
            Console.Write("2. Waiting for the kettle\n");
            Task.Delay(2000).GetAwaiter().GetResult();
            Console.Write("3. Kettle finished boiling\n");

            return "water";
        }


        //Example #3
        public static async void ListNumbers()
        {
            Console.WriteLine("Wait for 3 seconds...");
            await Task.Delay(3000);

            for (int i=0; i<=10; i++)
            {
                Console.WriteLine("Counting..." + i);
                await Task.Delay(500);
            }

            ListNumberMultiple5();
            ListNumberMultiple7();
        }

        public static async void ListNumberMultiple5()
        {
            int i = 0;

            while (i<50)
            {
                i += 5;
                Console.WriteLine("Multiple by 5: " + i);
                await Task.Delay(100);
            }
        }

        public static async void ListNumberMultiple7()
        {
            int i = 0;

            while (i < 50)
            {
                i += 7;
                Console.WriteLine("Multiple by 7: " + i);
                await Task.Delay(100);
            }
        }


        //Example 4

    }
}
