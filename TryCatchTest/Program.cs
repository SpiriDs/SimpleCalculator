using System;

namespace TryCatchTest
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            bool isValid = false;
            double num1;
            double num2;
            double result = 0;

            string calcOperator;

            while (isValid == false)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        Console.Write("What you want to do? ");
                        Console.Write("\nPlease enter the operator ( + , -, *, / ): ");
                        calcOperator = Console.ReadLine();
                        switch (calcOperator)
                        {
                            case "+":
                                result = num1 + num2;
                                break;

                            case "-":
                                result = num1 - num2;
                                break;

                            case "*":
                                result = num1 * num2;
                                break;

                            case "/":
                                result = num1 / num2;
                                break;

                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n" + e.Message);
                    }

                    Console.WriteLine("\nThe Result is: " + result);
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    isValid = false;
                }

                if (isValid)
                {
                    bool restart = false;
                    while (restart == false)
                    {
                        try
                        {
                            Console.Write("\nYou want to do another calculation? y/n: ");
                            char answer = Convert.ToChar(Console.ReadLine());
                            if (answer == 'y')
                            {
                                isValid = false;
                                restart = true;
                            }
                            else if (answer == 'n')
                            {
                                restart = true;
                                isValid = true;
                            }
                            else
                            {
                                restart = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n" + e.Message);
                            Console.WriteLine("Please enter \'y\' or \'n\'");
                            restart = false;
                        }
                    }
                }
            }

            //Console.ReadLine();
        }
    }
}