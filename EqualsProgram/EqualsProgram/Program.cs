using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            Class1 c3 = new Class1();
            c3 = c1;
            Console.WriteLine(Class1.MyReferenceEquals(c1,c2));
            Console.WriteLine(Class1.MyReferenceEquals(c1,c3));
            Console.WriteLine(Class1.MyEquals(c1,c2));
            Console.WriteLine(c1.MyEquals(c2));
        }
    }
}
