using System;
using System.Threading;
using System.Threading.Tasks;

namespace TheadDEmos
{
    class Program
    {
        static void Func1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Func2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task t1 = new Task(GetTheTime);
            t1.Start();
            t1.Wait();
            //Console.WriteLine("Main Method Starts");
            //ThreadStart ts1 = new ThreadStart(Func1);
            //ThreadStart ts2 = new ThreadStart(Func2);

            //Thread t1 = new Thread(ts1);
            //Thread t2 = new Thread(ts2);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            ////Func1();
            ////Func2();

            //Console.WriteLine("Main Method Ends");

        }
        private static void GetTheTime()
        {
            Console.WriteLine("Started");
            Console.WriteLine("The time now is {0}", DateTime.Now);
        }

    }
}
