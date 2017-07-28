using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    class Program
    {
        static int i = 10;
        static void Main(string[] args)
        {
            Console.WriteLine(i);
            Console.WriteLine(i);
            Console.WriteLine(i);
            i = 50;
            Console.WriteLine(i);
            Console.WriteLine(i);
            Console.WriteLine(i);
        }
    }
}
