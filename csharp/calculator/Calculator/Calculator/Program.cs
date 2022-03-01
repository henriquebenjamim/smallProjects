using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("May u want realize a math operation?");
            string answer = Console.ReadLine();

            if (answer != "yes")
            {
                Console.WriteLine("Program finished.");
            }
            else
            {
                Console.WriteLine("0 to break, any number to continue");
                int subAnswer = int.Parse(Console.ReadLine());
                while (subAnswer != 0)
                {

                    Console.WriteLine();
                    Console.WriteLine("What simple operation u want?");
                    Console.WriteLine("1 - Addition;");
                    Console.WriteLine("2 - Subtraction;");
                    Console.WriteLine("3 - Multiplication;");
                    Console.WriteLine("4 - Division;");
                    Console.WriteLine("0 - Close Program");

                    int mathOperation = int.Parse(Console.ReadLine());

                    Console.WriteLine("Give me two numbers:");
                    string[] number = Console.ReadLine().Split(' ');
                    int number1 = int.Parse(number[0]);
                    int number2 = int.Parse(number[1]);
                    switch (mathOperation)
                    {
                        case 1:
                            Console.WriteLine($"(Addition) The result is: {number1 + number2}");
                            break;
                        case 2:
                            Console.WriteLine($"(Subtraction) The result is: {number1 - number2}");
                            break;
                        case 3:
                            Console.WriteLine($"(Multiplication) The result is: {number1 * number2}");
                            break;
                        case 4:
                            Console.WriteLine($"(Division) The result is: {number1 / number2}");
                            break;
                        default:
                            Console.WriteLine("Closing...");
                            break;
                    }
                    Console.WriteLine("0 to Continue");
                    subAnswer = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
