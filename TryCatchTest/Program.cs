﻿using System;

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

                    //Rechenoperatoren mit switch/case
                    try
                    {
                        bool validOperator = false;
                        while (validOperator == false)
                        {
                            Console.Write("What you want to do? ");
                            Console.Write("\nPlease enter the operator ( + , -, *, / ): ");
                            calcOperator = Console.ReadLine();

                            switch (calcOperator)
                            {
                                case "+":
                                    validOperator = true;
                                    result = num1 + num2;

                                    break;

                                case "-":
                                    validOperator = true;
                                    result = num1 - num2;

                                    break;

                                case "*":
                                    validOperator = true;
                                    result = num1 * num2;

                                    break;

                                case "/":
                                    validOperator = true;
                                    result = num1 / num2;
                                    break;

                                default:
                                    //validOperator = false;
                                    Console.WriteLine("Please enter a valid Operator.");
                                    break;
                            }
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

                //Abfrage ob Programm beendet werden soll
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
                                Console.WriteLine("See you.");
                            }
                            else
                            {
                                Console.WriteLine("Please enter only \'y\' or \'n\'");
                                restart = false;
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