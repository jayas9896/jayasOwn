using System;

namespace AsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            E e = new E();
            Console.WriteLine(type<E>.AS(50));
            Console.WriteLine(e as B);
            C c = new C();
            Console.WriteLine(type<D>.AS(c));
           // Console.WriteLine(c as D);
        }
    }
}
