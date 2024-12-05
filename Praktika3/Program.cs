// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(DigitalRoot(16));
        Console.WriteLine(DigitalRoot(942));

        static int DigitalRoot(int num)
        {
            while (num >= 10)
            {
                int sum = 0;

                foreach (char digit in num.ToString())
                {
                    sum += (digit - '0');
                }

                num = sum;
            }

            return num;
        }
    }
}
