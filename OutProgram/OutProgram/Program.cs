using System;
using System.Threading;

namespace OutProgram
{
    class Program
    {
        public void check(out int a)
        {
            Console.WriteLine("check method started.");
            Thread.Sleep(1000);
            a = 50;
            Thread.Sleep(1000);
            Console.WriteLine("End of check method");
        }
        static void Main(string[] args)
        {
            int variable = 53;
            Program p = new Program();
            Thread t = new Thread(() => p.check(out variable));
            t.Start();
            Thread.Sleep(500);
            Console.WriteLine("Value of the variable = " + variable);
            Thread.Sleep(500);
            Console.WriteLine("Value of the variable = " + variable);
        }
    }
}
