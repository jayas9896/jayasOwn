using System;

namespace FloatAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two float numbers: ");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            MyMath objMyMath = new MyMath();
            string binaryFirst = objMyMath.StringToBinary(firstNumber);
            string binarySecond = objMyMath.StringToBinary(secondNumber);
            string binarySum = objMyMath.BinaryAddition(binaryFirst, binarySecond);
            float sum = objMyMath.BinaryToDecimal(binarySum);
            Console.WriteLine(sum);
        }
    }
}
