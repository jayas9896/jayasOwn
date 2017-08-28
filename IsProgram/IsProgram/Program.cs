using System;

namespace IsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            E e = new E();
            Console.WriteLine(type<B>.IS(e));
            Console.WriteLine(e is B);
            C c = new C();
            Console.WriteLine(type<D>.IS(c));
            Console.WriteLine(c is D);
            object o = 50;
            Console.WriteLine(o is int);
            Console.WriteLine(type<int>.IS(o));
        }
    }
}
