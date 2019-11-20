using System;

namespace PerfectNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            void checkNumber(int number)
            {
                int sum = 0;

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                }

                if (number == sum)
                {
                    Console.WriteLine("\nPERFECT NUMBER");
                }
                else
                {
                    Console.WriteLine("\nNOT PERFECT NUMBER");
                }
            }

            while (true)
            {
                string input = "";

                int inputNumber = 0;

                Console.Write("\nPlease entering a number : ");
                input = Console.ReadLine();

                inputNumber = Convert.ToInt32(input);

                checkNumber(inputNumber);
            }
        }
    }
}
