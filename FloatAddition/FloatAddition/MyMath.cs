namespace FloatAddition
{
    class MyMath
    {
        public string StringToBinary(string input)
        {
            int precision = 20;
            float number = float.Parse(input);
            int integer = (int)number;
            float fraction = number - integer;
            string integerBinary = string.Empty;
            while (integer > 0)
            {
                int rem = integer % 2;
                integer /= 2;
                integerBinary = rem.ToString() + integerBinary;
            }
            string fractionBinary = string.Empty;
            for (int i = precision; i > 0; i--)
            {
                fraction = (fraction * 2);
                fractionBinary = fractionBinary + ((int)fraction).ToString();
                fraction = fraction - (int)fraction;
            }
            return (integerBinary + "." + fractionBinary);
        }
        public float BinaryToDecimal(string answer)
        {
            int precision = 20;
            int integerSum = 0;
            int count = 0;
            int multiplierOne = 1;
            float multiplierTwo = 1.0f;
            float fractionSum = 0.0f;
            foreach (int value in answer)
            {
                count++;
            }
            int count1 = count - (precision + 1);
            for (int i = count1 - 1; i >= 0; i--)
            {
                integerSum = integerSum + ((answer[i] - 48) * multiplierOne);
                multiplierOne *= 2;
            }
            for (int j = count1 + 1; j < count; j++)
            {
                multiplierTwo *= 0.5f;
                fractionSum = fractionSum + ((answer[j] - 48) * multiplierTwo);
            }
            return integerSum + fractionSum;
        }

        public string BinaryAddition(string firstBinary, string secondBinary)
        {
            int count1 = 0, count2 = 0;
            int maximum, minimum;
            int remainder = 0;
            string sum = string.Empty;
            string smallBinary = string.Empty;
            string bigBinary = string.Empty;
            foreach (int value in firstBinary)
            {
                count1 = count1 + 1;
            }
            foreach (int value in secondBinary)
            {
                count2 = count2 + 1;
            }
            maximum = (count1 > count2) ? count1 : count2;
            minimum = (count1 > count2) ? count2 : count1;
            smallBinary = (count1 > count2) ? secondBinary : firstBinary;
            bigBinary = (count1 > count2) ? firstBinary : secondBinary;
            for (int j = 0; j < (maximum - minimum) + 1; j++)
            {
                smallBinary = 0 + smallBinary;
            }
            bigBinary = 0 + bigBinary;
            for (int i = maximum; i >= 0; i--)
            {
                if (smallBinary[i] == '.')
                {
                    sum = "." + sum;
                }
                else
                {
                    sum = ((smallBinary[i] + bigBinary[i] + remainder - 96) % 2).ToString() + sum;
                    remainder = (smallBinary[i] + bigBinary[i] + remainder - 96) / 2;
                }
            }
            return (sum);
        }
    }
}
