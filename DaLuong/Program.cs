using System;
using System.Threading;
using System.Threading.Tasks;

namespace DaLuong
{
    public static class Program
    {
        private static void WriteLine(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }

        // Task co kieu tra ve
        public static async Task<string> Async1(string a, string b)
        {
            Func<object, string> myfunc = (object x) =>
            {
                dynamic ts = x;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3} Task 1 Tham so {ts.x} {ts.y}");
                    Thread.Sleep(300);
                }
                return " Ket thuc Task 1";
            };

            Task<string> task = new Task<string>(myfunc, new { x = a, y = b });
            task.Start();
            await task;

            Console.WriteLine("Hoan thanh tast1 -" + task.Result);
            return task.Result;
        }

        // Task khong co kieu tra ve

        public static async Task Async2()
        {
            Action action = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3} Task 2");
                    Thread.Sleep(1000);
                }
            };

            Task task2 = new Task(action);
            task2.Start();

            await task2;
            Console.WriteLine("Hoan thanh task2");
        }

        private static async Task Main(string[] args)
        {
            Console.WriteLine($"{' ',5 } {Thread.CurrentThread.ManagedThreadId,3} Main Thread");

            var task1 = Async1("a", "b");
            var task2 = Async2();
           
            //doc ket qua tra ve tu task1
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{' ',5 } {Thread.CurrentThread.ManagedThreadId,3} Main Thread");
                Thread.Sleep(1000);
            }
            await task1;
            Console.WriteLine("Sau khi task1 ket thuc");
            await task2;
            Console.WriteLine("Sau khi task2 ket thuc");

            Console.WriteLine("Chay tiep ne");
            Console.ReadLine();
        }
    }
}