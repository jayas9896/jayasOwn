using System;

namespace floatBinAddInt
{
    class myMath
    {
        public static int max = 0, dotPos = 0;
        public static long intToBin(int intNumber)
        {
            long reverseBinary, binary;
            int count = 0;
            for (reverseBinary = 0; intNumber > 0; intNumber /= 2)
            {
                if ((reverseBinary == 0) && (intNumber % 2 == 0))
                {
                    count++;
                }
                reverseBinary = (reverseBinary * 10) + intNumber % 2;
            }
            for (binary = 0; reverseBinary > 0; reverseBinary /= 10)
            {
                binary = binary * 10 + (reverseBinary % 10);
            }
            for (int i = 0; i < count; i++)
            {
                binary *= 10;
            }
            return binary;
        }
        public static decimal decToBin(double a)
        {
            decimal x = 0;
            int i = 0;
            for (i = 0; i < 14; i++)
            {
                if (a == 0)
                    break;
                x = (x * 10) + ((int)(a * 2));
                a = (a * 2) - (int)(a * 2);
            }
            if (i > max)
                max = i;
            decimal m = 1;
            for (int j = 0; j < max; j++)
            {
                m *= 10;
            }
            return (x / m);
        }
        public static int[] Correct(decimal num)
        {
            string str = num.ToString();
            int j = str.Length - 2;
            int[] Num = new int[str.Length + 1];
            foreach (char i in str)
            {
                if (j < 0)
                    break;
                if (i != '.')
                    Num[j] = i - 48;
                if (i == '.')
                {
                    dotPos = j;
                    j++;
                }
                j--;
            }
            for (int i = 0; i <= str.Length; i++)
            {
                if (Num[i] > 1)
                {
                    Num[i + 1] += (Num[i] / 2);
                    Num[i] %= 2;
                }
            }
            return Num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Int64 xIb = myMath.intToBin((int)x);
            Int64 yIb = myMath.intToBin((int)y);
            decimal xDb = myMath.decToBin(x - (int)x);
            decimal yDb = myMath.decToBin(y - (int)y);
            decimal xB = xIb + xDb;
            decimal yB = yIb + yDb;
            Console.WriteLine(x + " in bin is " + xB);
            Console.WriteLine(y + " in bin is " + yB);
            decimal sum = xB + yB;
            Console.Write("Sum in Binary is ");
            int[] Num = myMath.Correct(sum);
            int k = 0;
            double Sum = 0;
            bool print = false;
            for (int i = Num.Length - 1; i >= 0; i--)
            {
                Sum += Num[i] * Math.Pow(2, i - myMath.dotPos - 1);
                if (Num[i] == 1)
                    print = true;
                if (print == true)
                {
                    if (k == Num.Length - myMath.dotPos - 1)
                        Console.Write('.');
                    Console.Write(Num[i]);
                }
                k++;
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + Sum);
        }
    }
}