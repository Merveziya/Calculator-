using System;

namespace calculate_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" How many times do you want to calculation: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();




            for (int i = 0; i < time; i++)
            {
                //Getting User Input
                Console.Write(" Please enter first number: ");
                float number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write(" Please enter second number: ");
                float number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                Console.WriteLine(" Add = 1\n Substraction = 2\n Multiplication = 3\n Divide = 4\n Square = 5\n Mod = 6");
                Console.Write(" Which of the above number do you want to do: ");
                string operation = Console.ReadLine();

                Console.WriteLine();
                float total = 0;
                if (operation == "1")
                {
                    total = number1 + number2;
                    Console.WriteLine(total);
                }
                else if (operation == "2")
                {
                    if (number1 >= number2)
                    {
                        total = number1 - number2;
                        Console.WriteLine(total);

                    }
                    else if (number2 > number1)
                    {
                        total = number2 - number1;
                        Console.WriteLine(total);

                    }

                }
                else if (operation == "3")
                {
                    total = number1 * number2;
                    Console.WriteLine(total);
                }
                else if (operation == "4")
                {
                    if (number1 >= number2)
                    {
                        total = number1 / number2;
                        Console.WriteLine(total);

                    }
                    else if (number2 > number1)
                    {
                        total = number2 / number1;
                        Console.WriteLine(total);

                    }
                }
                else if (operation == "5")
                {
                    float total1 = number1 * number1;
                    float total2 = number2 * number2;
                    Console.WriteLine("Square root of the first number: " + total1 + "   Square root of the first number: " + total2);
                }
                else if (operation == "6")
                {
                    if (number1 >= number2)
                    {
                        total = number1 % number2;
                        Console.WriteLine(total);
                    }
                    else if (number2 > number1)
                    {
                        total = number2 % number1;
                        Console.WriteLine(total);

                    }
                }
                else
                {

                    Console.WriteLine("You didn't enter number!!");
                }


                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
