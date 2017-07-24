using System;

namespace floatAddBin
{
    class myMath
    {
        public static int max = 0;
        public static void intToBin(int num, int[] bin)
        {
            int dup = num, i = 0, j = 0;
            for (i = 0; dup > 0; i++)
            {
                bin[i] = dup % 2;
                dup /= 2;
            }
            if (i > max)
                max = i;
        }
        public static void decToBin(double num, int[] bin)
        {
            for (int i = 0; i < 15; i++)
            {
                bin[i] = 0;
            }
            for (int i = 14; i >= 0; i--)
            {
                bin[i] = (int)(Math.Floor(num * 2));
                num = (num * 2) - (int)(num * 2);
            }
        }
        public static void joinIntDec(int[] a, int[] aI, int[] aD)
        {
            bool print = false;
            for (int i = 15; i < max + 15; i++)
            {
                a[i] = aI[i - 15];
            }
            for (int j = max + 15; j >= 15; j--)
            {
                if (a[j] == 1)
                    print = true;
                if (print == true)
                    Console.Write(a[j]);
            }
            Console.Write('.');
            for (int i = 14; i >= 0; i--)
            {
                a[i] = aD[i];
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        public static void readNum(out double num, out int numInt, out double numDec)
        {
            Console.Write("Enter the number: ");
            num = Convert.ToDouble(Console.ReadLine());
            numInt = Convert.ToInt32(Math.Floor(num));
            numDec = num - Convert.ToDouble(numInt);
        }
        public static double sumBinTot(int[] a, int[] b, int max)
        {
            int i = 0;
            double sum = 0;
            bool print = false;
            int[] sumIntTot = new int[100];
            for (int j = 0; j < 100; j++)
                sumIntTot[j] = -1;
            for (i = 0; i < max + 3; i++)
            {
                if ((i > max) && (sumIntTot[i] == -1))
                    break;
                sumIntTot[i] += a[i] + b[i] + 1;
                if (sumIntTot[i] > 1)
                {
                    sumIntTot[i] = sumIntTot[i] % 2;
                    sumIntTot[i + 1] = sumIntTot[i] / 2;
                }
            }
            Console.Write("Total sum of Num in binary is ");
            while (i >= 0)
            {
                if (sumIntTot[i] == 1)
                {
                    print = true;
                    if (i > max)
                        max = i;
                }
                if (print == true)
                {
                    Console.Write(sumIntTot[i]);
                    if (i == 15)
                        Console.Write('.');
                    sum += (Math.Pow(2, i - 15)) * sumIntTot[i];
                }
                i--;
            }
            Console.WriteLine();
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            double num1, num2;
            int numInt1, numInt2;
            double numDec1, numDec2;
            int[] aI = new int[85];
            for (int k = 0; k < 85; k++)
            {
                aI[k] = 0;
            }
            int[] bI = new int[85];
            for (int k = 0; k < 85; k++)
            {
                bI[k] = 0;
            }
            int[] aD = new int[15];
            int[] bD = new int[15];
            int[] a = new int[100];
            int[] b = new int[100];
            #endregion
            myMath.readNum(num: out num1, numInt: out numInt1, numDec: out numDec1);
            myMath.readNum(num: out num2, numInt: out numInt2, numDec: out numDec2);
            myMath.intToBin(Math.Abs(numInt1), aI);
            myMath.decToBin(numDec1, aD);
            myMath.intToBin(Math.Abs(numInt2), bI);
            myMath.decToBin(numDec2, bD);
            int max = myMath.max;
            Console.Write("Num1 in binary is \t\t");
            myMath.joinIntDec(a, aI, aD);
            Console.Write("Num2 in binary is \t\t");
            myMath.joinIntDec(b, bI, bD);
            Console.WriteLine("Total sum in int is  " + myMath.sumBinTot(a, b, max + 15));
        }
    }
}
