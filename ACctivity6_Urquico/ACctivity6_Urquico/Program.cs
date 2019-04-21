using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Activity3_URQUICO
{
    class Program
    {
        static void Main(string[] args)
        {

            string titleHead = @"
+-----------------------------------------------------------------------------------+
| +-------------------------------------------------------------------------------+ |
| | +---------------------------------------------------------------------------+ | |
| | | +-----------------------------------------------------------------------+ | | |
| | | |                                                                       | | | |
| | | |    __    __   __      __    __       _______. _______ .______         | | | |
| | | |   |  |  |  | |  |    |  |  |  |     /       ||   ____||   _  \        | | | |
| | | |   |  |__|  | |  |    |  |  |  |    |   (----`|  |__   |  |_)  |       | | | |
| | | |   |   __   | |  |    |  |  |  |     \   \    |   __|  |      /        | | | |
| | | |   |  |  |  | |  |    |  `--'  | .----)   |   |  |____ |  |\  \----.   | | | |
| | | |   |__|  |__| |__|     \______/  |_______/    |_______|| _| `._____|   | | | |
| | | |                                                                       | | | |
| | | |                                                                       | | | |
| | | +-----------------------------------------------------------------------+ | | |
| | +---------------------------------------------------------------------------+ | |
| +-------------------------------------------------------------------------------+ |
+-----------------------------------------------------------------------------------+

            ";
            string[] operators = new string[] {
               "1.Addition", "2.Subtraction", "3.Multiplication", "4.Division"
            };

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(titleHead);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\n\nStudents' name: ");
            string name = Console.ReadLine();


            Console.Write("Student ID No.: ");
            int studentNum = int.Parse(Console.ReadLine());

            
            Console.Write("Section: ");
            string sect = Console.ReadLine();

            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");

            Console.WriteLine("What math operation do you want to do to your data ? ");

            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");
            for (int x = 0; x < operators.Length; x++)
            {
                Console.WriteLine("\t" + operators[x]);
            }
            string ansOperator = Console.ReadLine();

            while (true)
            {
                if (ansOperator == "1")
                {
                    Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                    Console.Write("Please Enter the first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the third number: ");
                    int thirdNumber = int.Parse(Console.ReadLine());

                    int sum = firstNumber + secondNumber + thirdNumber;
                    Console.WriteLine("The sum of 3 numbers is " + sum + "\n");


                    break;

                }
                else if (ansOperator == "2")
                {
                    Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                    Console.Write("Please Enter the first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the third number: ");
                    int thirdNumber = int.Parse(Console.ReadLine());

                    int subt = firstNumber - secondNumber - thirdNumber;
                    Console.WriteLine("The difference of 3 numbers is " + subt + "\n");


                    break;

                }
                else if (ansOperator == "3")
                {
                    Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                    Console.Write("Please Enter the first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the third number: ");
                    int thirdNumber = int.Parse(Console.ReadLine());

                    int mult = firstNumber * secondNumber * thirdNumber;
                    Console.WriteLine("The product of 3 numbers is " + mult + "\n");


                    break;

                }
                else if (ansOperator == "4")
                {
                    Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                    Console.Write("Please Enter the first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the third number: ");
                    int thirdNumber = int.Parse(Console.ReadLine());

                    int div = firstNumber / secondNumber / thirdNumber;
                    Console.WriteLine("The quotient of 3 numbers is " + div + "\n");


                    break;

                }
                else
                {
                    Console.WriteLine("Please Pick 1");
                    ansOperator = Console.ReadLine();
                }


            }

            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");
            Console.WriteLine("\nExit ? Press Y to exit, Press N to return to menu");
            string valid = Console.ReadLine();

            while (true)
            {
                if (valid == "y" || valid == "Y")
                {
                    
                    Environment.Exit(0);
                    break;

                }
                else if (valid == "N" || valid == "n")
                {
                    Console.WriteLine("+-----------------------------------------------------------------------------------+");
                    Console.WriteLine("+***********************************************************************************+");

                    Console.WriteLine("What math operation do you want to do to your data ? ");

                    Console.WriteLine("+-----------------------------------------------------------------------------------+");
                    Console.WriteLine("+***********************************************************************************+");
                    for (int x = 0; x < operators.Length; x++)
                    {
                        Console.WriteLine("\t" + operators[x]);
                    }
                    ansOperator = null;
                    ansOperator = Console.ReadLine();

                    while (true)
                    {
                        if (ansOperator == "1")
                        {
                            Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                            Console.Write("Please Enter the first number: ");
                            int firstNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the second number: ");
                            int secondNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the third number: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int sum = firstNumber + secondNumber + thirdNumber;
                            Console.WriteLine("The sum of 3 numbers is " + sum + "\n");


                            break;

                        }
                        else if (ansOperator == "2")
                        {
                            Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                            Console.Write("Please Enter the first number: ");
                            int firstNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the second number: ");
                            int secondNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the third number: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int subt = firstNumber - secondNumber - thirdNumber;
                            Console.WriteLine("The difference of 3 numbers is " + subt + "\n");


                            break;

                        }
                        else if (ansOperator == "3")
                        {
                            Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                            Console.Write("Please Enter the first number: ");
                            int firstNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the second number: ");
                            int secondNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the third number: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int mult = firstNumber * secondNumber * thirdNumber;
                            Console.WriteLine("The product of 3 numbers is " + mult + "\n");


                            break;

                        }
                        else if (ansOperator == "4")
                        {
                            Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

                            Console.Write("Please Enter the first number: ");
                            int firstNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the second number: ");
                            int secondNumber = int.Parse(Console.ReadLine());
                            Console.Write("Please Enter the third number: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int div = firstNumber / secondNumber / thirdNumber;
                            Console.WriteLine("The quotient of 3 numbers is " + div + "\n");


                            break;

                        }
                        else
                        {
                            Console.WriteLine("Please Pick 1");
                            ansOperator = Console.ReadLine();
                        }


                    }

                    Console.WriteLine("+-----------------------------------------------------------------------------------+");
                    Console.WriteLine("+***********************************************************************************+");
                    Console.WriteLine("\nExit ? Press Y to exit, Press N to return to menu");
                    valid = "";
                    valid = Console.ReadLine();



                }
                else
                {
                    Console.WriteLine("Please Pick 1");
                    valid = Console.ReadLine();
                }
            }

            Console.WriteLine("Thankyou!");
            Console.ReadKey();


        }
    }
}
