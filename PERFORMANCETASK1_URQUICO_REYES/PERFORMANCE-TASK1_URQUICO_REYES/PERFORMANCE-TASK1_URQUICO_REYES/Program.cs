using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PERFORMANCE_TASK1_URQUICO_REYES
{
    class Program
    {
        static void Main(string[] args)
        {
            int empNum;
            string empName;
            string[] items = new string[] {
                "0. Skip",
                "1.Notebook 50's - P45",
                "2.Notebook 100's - P72",
                "3.Pencil - P10",
                "4.Eraser - P8",
                "5.Sharpener - P15",
                "6.Colored Pencils 20's - P65",
                "7.Colored Pencils 40's - P130",
                "8.Sketch Pad - P110",
                "9.Clay - P35",
                "10.Cartolina - P6",
                "11.Vellum Board - P55",
                "12.Gtech C3 - P65",
                "13.Gtech C4 - P75"
                
            };




            Console.Write("+----------------------------------------------------------------------+");
            Console.Write("\n\tEnter Employee No: ");
            empNum = int.Parse(Console.ReadLine());
            Console.Write("+----------------------------------------------------------------------+\n");

            Console.Write("\n\n+----------------------------------------------------------------------+");
            Console.Write("\n\t Employee Name: ");
            empName = Console.ReadLine();
            Console.Write("+----------------------------------------------------------------------+\n");

            //input header here
            string titleHead = @"
----------------------------------------------------------------------
  _    _      _ _                        _                            
 | |  | |    | | |                      | |                           
 | |__| | ___| | | ___     ___ _   _ ___| |_ ___  _ __ ___   ___ _ __ 
 |  __  |/ _ \ | |/ _ \   / __| | | / __| __/ _ \| '_ ` _ \ / _ \ '__|
 | |  | |  __/ | | (_) | | (__| |_| \__ \ || (_) | | | | | |  __/ |   
 |_|  |_|\___|_|_|\___/   \___|\__,_|___/\__\___/|_| |_| |_|\___|_|   
                                                                      
----------------------------------------------------------------------                                                        

            ";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleHead);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\tHello " + empName + "\n\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Customer's TIN: ");
            int empTIN = int.Parse(Console.ReadLine());
                



            Console.Write("City : ");
            string city = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n+----------------------------------------------------------------------+");
            Console.WriteLine("\n\t\t\t\tLet's Start");
            Console.Write("+----------------------------------------------------------------------+\n\n");


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int x = 0; x < items.Length; x++) {
                Console.WriteLine(items[x]);
            }

            //int price1,price2,price3,price4,price5,price6,price7,price8,price9,price10,price11,price12,price13;
            string ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10, ans11, ans12,ans13;
            int val1, val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13;

            Console.WriteLine("Please choose 1");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ans1 = Console.ReadLine();
                while (true) {
                    if (ans1 == "1")
                    {
                        val1 = 45;
                        break;
                    }
                    else if (ans1 == "2")
                    {
                        val1 = 72;
                        break;

                    }
                    else if (ans1 == "0")
                    {
                        val1 = 0;
                        break;
                    }
                    else if (ans1 == "3")
                    {
                        val1 = 10;
                        break;
                    }
                    else if (ans1 == "4")
                    {
                        val1 = 8;
                        break;
                    }
                    else if (ans1 == "5")
                    {
                        val1 = 15;
                        break;
                    }
                    else if (ans1 == "6")
                    {
                        val1 = 65;
                        break;
                    }
                    else if (ans1 == "7")
                    {
                        val1 = 130;
                        break;
                    }
                    else if (ans1 == "8")
                    {
                        val1 = 110;
                        break;
                    }
                    else if (ans1 == "9")
                    {
                        val1 = 35;
                        break;
                    }
                    else if (ans1 == "10")
                    {
                        val1 = 6;
                        break;
                    }
                    else if (ans1 == "11")
                    {
                        val1 = 55;
                        break;
                    }
                    else if (ans1 == "12")
                    {
                        val1 = 65;
                        break;
                    }
                    else if (ans1 == "13")
                    {
                        val1 = 75;
                        break;
                    }
                    else if(ans1 == "")
                    {
                        Console.WriteLine("Please select");
                        ans1 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            
            ans2 = Console.ReadLine();
                while (true)
                {
                    if (ans2 == "1")
                    {
                        val2 = 45;
                        break;
                    }
                    else if (ans2 == "2")
                    {
                        val2 = 72;
                        break;

                    }
                    else if (ans2 == "0")
                    {
                        val2 = 0;
                        break;
                    }
                    else if (ans2 == "3")
                    {
                        val2 = 10;
                        break;
                    }
                    else if (ans2 == "4")
                    {
                        val2 = 8;
                        break;
                    }
                    else if (ans2 == "5")
                    {
                        val2 = 15;
                        break;
                    }
                    else if (ans2 == "6")
                    {
                        val2 = 65;
                        break;
                    }
                    else if (ans2 == "7")
                    {
                        val2 = 130;
                        break;
                    }
                    else if (ans2 == "8")
                    {
                        val2 = 110;
                        break;
                    }
                    else if (ans2 == "9")
                    {
                        val2 = 35;
                        break;
                    }
                    else if (ans2 == "10")
                    {
                        val2 = 6;
                        break;
                    }
                    else if (ans2 == "11")
                    {
                        val2 = 55;
                        break;
                    }
                    else if (ans2 == "12")
                    {
                        val2 = 65;
                        break;
                    }
                    else if (ans2 == "13")
                    {
                        val2 = 75;
                        break;
                    }
                    else if (ans2 == "")
                    {
                        Console.WriteLine("Please select");
                        ans2 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

           
            ans3 = Console.ReadLine();
                while (true)
                {
                    if (ans3 == "1")
                    {
                        val3 = 45;
                        break;
                    }
                    else if (ans3 == "2")
                    {
                        val3 = 72;
                        break;

                    }
                    else if (ans3 == "0")
                    {
                        val3 = 0;
                        break;
                    }
                    else if (ans3 == "3")
                    {
                        val3 = 10;
                        break;
                    }
                    else if (ans3 == "4")
                    {
                        val3 = 8;
                        break;
                    }
                    else if (ans3 == "5")
                    {
                        val3 = 15;
                        break;
                    }
                    else if (ans3 == "6")
                    {
                        val3 = 65;
                        break;
                    }
                    else if (ans3 == "7")
                    {
                        val3 = 130;
                        break;
                    }
                    else if (ans3 == "8")
                    {
                        val3 = 110;
                        break;
                    }
                    else if (ans3 == "9")
                    {
                        val3 = 35;
                        break;
                    }
                    else if (ans3 == "10")
                    {
                        val3 = 6;
                        break;
                    }
                    else if (ans3 == "11")
                    {
                        val3 = 55;
                        break;
                    }
                    else if (ans3 == "12")
                    {
                        val3 = 65;
                        break;
                    }
                    else if (ans3 == "13")
                    {
                        val3 = 75;
                        break;
                    }
                    else if (ans3 == "")
                    {
                        Console.WriteLine("Please select");
                        ans3 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");
            
            ans4 = Console.ReadLine();
                while (true)
                {
                    if (ans4 == "1")
                    {
                        val4 = 45;
                        break;
                    }
                    else if (ans4 == "2")
                    {
                        val4 = 72;
                        break;

                    }
                    else if (ans4 == "0")
                    {
                        val4 = 0;
                        break;
                    }
                    else if (ans4 == "3")
                    {
                        val4 = 10;
                        break;
                    }
                    else if (ans4 == "4")
                    {
                        val4 = 8;
                        break;
                    }
                    else if (ans4 == "5")
                    {
                        val4 = 15;
                        break;
                    }
                    else if (ans4 == "6")
                    {
                        val4 = 65;
                        break;
                    }
                    else if (ans4 == "7")
                    {
                        val4 = 130;
                        break;
                    }
                    else if (ans4 == "8")
                    {
                        val4 = 110;
                        break;
                    }
                    else if (ans4 == "9")
                    {
                        val4 = 35;
                        break;
                    }
                    else if (ans4 == "10")
                    {
                        val4 = 6;
                        break;
                    }
                    else if (ans4 == "11")
                    {
                        val4 = 55;
                        break;
                    }
                    else if (ans4 == "12")
                    {
                        val4 = 65;
                        break;
                    }
                    else if (ans4 == "13")
                    {
                        val4 = 75;
                        break;
                    }
                    else if (ans4 == "")
                    {
                        Console.WriteLine("Please select");
                        ans4 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

           
            ans5 = Console.ReadLine();
                while (true)
                {
                    if (ans5 == "1")
                    {
                        val5 = 45;
                        break;
                    }
                    else if (ans5 == "2")
                    {
                        val5 = 72;
                        break;

                    }
                    else if (ans5 == "0")
                    {
                        val5 = 0;
                        break;
                    }
                    else if (ans5 == "3")
                    {
                        val5 = 10;
                        break;
                    }
                    else if (ans5 == "4")
                    {
                        val5 = 8;
                        break;
                    }
                    else if (ans5 == "5")
                    {
                        val5 = 15;
                        break;
                    }
                    else if (ans5 == "6")
                    {
                        val5 = 65;
                        break;
                    }
                    else if (ans5 == "7")
                    {
                        val5 = 130;
                        break;
                    }
                    else if (ans5 == "8")
                    {
                        val5 = 110;
                        break;
                    }
                    else if (ans5 == "9")
                    {
                        val5 = 35;
                        break;
                    }
                    else if (ans5 == "10")
                    {
                        val5 = 6;
                        break;
                    }
                    else if (ans5 == "11")
                    {
                        val5 = 55;
                        break;
                    }
                    else if (ans5 == "12")
                    {
                        val5 = 65;
                        break;
                    }
                    else if (ans5 == "13")
                    {
                        val5 = 75;
                        break;
                    }
                    else if (ans5 == "")
                    {
                        Console.WriteLine("Please select");
                        ans5 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans6 = Console.ReadLine();
                while (true)
                {
                    if (ans6 == "1")
                    {
                        val6 = 45;
                        break;
                    }
                    else if (ans6 == "2")
                    {
                        val6 = 72;
                        break;

                    }
                    else if (ans6 == "0")
                    {
                        val6 = 0;
                        break;
                    }
                    else if (ans6 == "3")
                    {
                        val6 = 10;
                        break;
                    }
                    else if (ans6 == "4")
                    {
                        val6 = 8;
                        break;
                    }
                    else if (ans6 == "5")
                    {
                        val6 = 15;
                        break;
                    }
                    else if (ans6 == "6")
                    {
                        val6 = 65;
                        break;
                    }
                    else if (ans6 == "7")
                    {
                        val6 = 130;
                        break;
                    }
                    else if (ans6 == "8")
                    {
                        val6 = 110;
                        break;
                    }
                    else if (ans6 == "9")
                    {
                        val6 = 35;
                        break;
                    }
                    else if (ans6 == "10")
                    {
                        val6 = 6;
                        break;
                    }
                    else if (ans6 == "11")
                    {
                        val6 = 55;
                        break;
                    }
                    else if (ans6 == "12")
                    {
                        val6 = 65;
                        break;
                    }
                    else if (ans6 == "13")
                    {
                        val6 = 75;
                        break;
                    }
                    else if (ans6 == "")
                    {
                        Console.WriteLine("Please select");
                        ans6 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans7 = Console.ReadLine();
                while (true)
                {
                    if (ans7 == "1")
                    {
                        val7 = 45;
                        break;
                    }
                    else if (ans7 == "2")
                    {
                        val7 = 72;
                        break;

                    }
                    else if (ans7 == "0")
                    {
                        val7 = 0;
                        break;
                    }
                    else if (ans7 == "3")
                    {
                        val7 = 10;
                        break;
                    }
                    else if (ans7 == "4")
                    {
                        val7 = 8;
                        break;
                    }
                    else if (ans7 == "5")
                    {
                        val7 = 15;
                        break;
                    }
                    else if (ans7 == "6")
                    {
                        val7 = 65;
                        break;
                    }
                    else if (ans7 == "7")
                    {
                        val7 = 130;
                        break;
                    }
                    else if (ans7 == "8")
                    {
                        val7 = 110;
                        break;
                    }
                    else if (ans7 == "9")
                    {
                        val7 = 35;
                        break;
                    }
                    else if (ans7 == "10")
                    {
                        val7 = 6;
                        break;
                    }
                    else if (ans7 == "11")
                    {
                        val7 = 55;
                        break;
                    }
                    else if (ans7 == "12")
                    {
                        val7 = 65;
                        break;
                    }
                    else if (ans7 == "13")
                    {
                        val7 = 75;
                        break;
                    }
                    else if (ans7 == "")
                    {
                        Console.WriteLine("Please select");
                        ans7 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans8 = Console.ReadLine();
                while (true)
                {
                    if (ans8 == "1")
                    {
                        val8 = 45;
                        break;
                    }
                    else if (ans8 == "2")
                    {
                        val8 = 72;
                        break;

                    }
                    else if (ans8 == "0")
                    {
                        val8 = 0;
                        break;
                    }
                    else if (ans8 == "3")
                    {
                        val8 = 10;
                        break;
                    }
                    else if (ans8 == "4")
                    {
                        val8 = 8;
                        break;
                    }
                    else if (ans8 == "5")
                    {
                        val8 = 15;
                        break;
                    }
                    else if (ans8 == "6")
                    {
                        val8 = 65;
                        break;
                    }
                    else if (ans8 == "7")
                    {
                        val8 = 130;
                        break;
                    }
                    else if (ans8 == "8")
                    {
                        val8 = 110;
                        break;
                    }
                    else if (ans8 == "9")
                    {
                        val8 = 35;
                        break;
                    }
                    else if (ans8 == "10")
                    {
                        val8 = 6;
                        break;
                    }
                    else if (ans8 == "11")
                    {
                        val8 = 55;
                        break;
                    }
                    else if (ans8 == "12")
                    {
                        val8 = 65;
                        break;
                    }
                    else if (ans8 == "13")
                    {
                        val8 = 75;
                        break;
                    }
                    else if (ans8 == "")
                    {
                        Console.WriteLine("Please select");
                        ans8 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans9 = Console.ReadLine();
                while (true)
                {
                    if (ans9 == "1")
                    {
                        val9 = 45;
                        break;
                    }
                    else if (ans9 == "2")
                    {
                        val9 = 72;
                        break;

                    }
                    else if (ans9 == "0")
                    {
                        val9 = 0;
                        break;
                    }
                    else if (ans9 == "3")
                    {
                        val9 = 10;
                        break;
                    }
                    else if (ans9 == "4")
                    {
                        val9 = 8;
                        break;
                    }
                    else if (ans9 == "5")
                    {
                        val9 = 15;
                        break;
                    }
                    else if (ans9 == "6")
                    {
                        val9 = 65;
                        break;
                    }
                    else if (ans9 == "7")
                    {
                        val9 = 130;
                        break;
                    }
                    else if (ans9 == "8")
                    {
                        val9 = 110;
                        break;
                    }
                    else if (ans9 == "9")
                    {
                        val9 = 35;
                        break;
                    }
                    else if (ans9 == "10")
                    {
                        val9 = 6;
                        break;
                    }
                    else if (ans9 == "11")
                    {
                        val9 = 55;
                        break;
                    }
                    else if (ans9 == "12")
                    {
                        val9 = 65;
                        break;
                    }
                    else if (ans9 == "13")
                    {
                        val9 = 75;
                        break;
                    }
                    else if (ans9 == "")
                    {
                        Console.WriteLine("Please select");
                        ans9 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans10 = Console.ReadLine();
                while (true)
                {
                    if (ans10 == "1")
                    {
                        val10 = 45;
                        break;
                    }
                    else if (ans10 == "2")
                    {
                        val10 = 72;
                        break;

                    }
                    else if (ans10 == "0")
                    {
                        val10 = 0;
                        break;
                    }
                    else if (ans10 == "3")
                    {
                        val10 = 10;
                        break;
                    }
                    else if (ans10 == "4")
                    {
                        val10 = 8;
                        break;
                    }
                    else if (ans10 == "5")
                    {
                        val10 = 15;
                        break;
                    }
                    else if (ans10 == "6")
                    {
                        val10 = 65;
                        break;
                    }
                    else if (ans10 == "7")
                    {
                        val10 = 130;
                        break;
                    }
                    else if (ans10 == "8")
                    {
                        val10 = 110;
                        break;
                    }
                    else if (ans10 == "9")
                    {
                        val10 = 35;
                        break;
                    }
                    else if (ans10 == "10")
                    {
                        val10 = 6;
                        break;
                    }
                    else if (ans10 == "11")
                    {
                        val10 = 55;
                        break;
                    }
                    else if (ans10 == "12")
                    {
                        val10 = 65;
                        break;
                    }
                    else if (ans10 == "13")
                    {
                        val10 = 75;
                        break;
                    }
                    else if (ans10 == "")
                    {
                        Console.WriteLine("Please select");
                        ans10 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");
            
            ans11 = Console.ReadLine();
                while (true)
                {
                    if (ans11 == "1")
                    {
                        val11 = 45;
                        break;
                    }
                    else if (ans11 == "2")
                    {
                        val11 = 72;
                        break;

                    }
                    else if (ans11 == "0")
                    {
                        val11 = 0;
                        break;
                    }
                    else if (ans11 == "3")
                    {
                        val11 = 10;
                        break;
                    }
                    else if (ans11 == "4")
                    {
                        val11 = 8;
                        break;
                    }
                    else if (ans11 == "5")
                    {
                        val11 = 15;
                        break;
                    }
                    else if (ans11 == "6")
                    {
                        val11 = 65;
                        break;
                    }
                    else if (ans11 == "7")
                    {
                        val11 = 130;
                        break;
                    }
                    else if (ans11 == "8")
                    {
                        val11 = 110;
                        break;
                    }
                    else if (ans11 == "9")
                    {
                        val11 = 35;
                        break;
                    }
                    else if (ans11 == "10")
                    {
                        val11 = 6;
                        break;
                    }
                    else if (ans11 == "11")
                    {
                        val11 = 55;
                        break;
                    }
                    else if (ans11 == "12")
                    {
                        val11 = 65;
                        break;
                    }
                    else if (ans11 == "13")
                    {
                        val11 = 75;
                        break;
                    }
                    else if (ans11 == "")
                    {
                        Console.WriteLine("Please select");
                        ans11 = Console.ReadLine();
                    }
                }

                Console.WriteLine("Select again");

            ans12 = Console.ReadLine();
                while (true)
                {
                    if (ans12 == "1")
                    {
                        val12 = 45;
                        break;
                    }
                    else if (ans12 == "2")
                    {
                        val12 = 72;
                        break;

                    }
                    else if (ans12 == "0")
                    {
                        val12 = 0;
                        break;
                    }
                    else if (ans12 == "3")
                    {
                        val12 = 10;
                        break;
                    }
                    else if (ans12 == "4")
                    {
                        val12 = 8;
                        break;
                    }
                    else if (ans12 == "5")
                    {
                        val12 = 15;
                        break;
                    }
                    else if (ans12 == "6")
                    {
                        val12 = 65;
                        break;
                    }
                    else if (ans12 == "7")
                    {
                        val12 = 130;
                        break;
                    }
                    else if (ans12 == "8")
                    {
                        val12 = 110;
                        break;
                    }
                    else if (ans12 == "9")
                    {
                        val12 = 35;
                        break;
                    }
                    else if (ans12 == "10")
                    {
                        val12 = 6;
                        break;
                    }
                    else if (ans12 == "11")
                    {
                        val12 = 55;
                        break;
                    }
                    else if (ans12 == "12")
                    {
                        val12 = 65;
                        break;
                    }
                    else if (ans12 == "13")
                    {
                        val12 = 75;
                        break;
                    }
                    else if (ans12 == "")
                    {
                        Console.WriteLine("Please select");
                        ans12 = Console.ReadLine();
                    }
                }

                Console.WriteLine("select 1 more");

            ans13 = Console.ReadLine();
                while (true)
                {
                    if (ans13 == "1")
                    {
                        val13 = 45;
                        break;
                    }
                    else if (ans13 == "2")
                    {
                        val13 = 72;
                        break;

                    }
                    else if (ans13 == "0")
                    {
                        val13 = 0;
                        break;
                    }
                    else if (ans13 == "3")
                    {
                        val13 = 10;
                        break;
                    }
                    else if (ans13 == "4")
                    {
                        val13 = 8;
                        break;
                    }
                    else if (ans13 == "5")
                    {
                        val13 = 15;
                        break;
                    }
                    else if (ans13 == "6")
                    {
                        val13 = 65;
                        break;
                    }
                    else if (ans13 == "7")
                    {
                        val13 = 130;
                        break;
                    }
                    else if (ans13 == "8")
                    {
                        val13 = 110;
                        break;
                    }
                    else if (ans13 == "9")
                    {
                        val13 = 35;
                        break;
                    }
                    else if (ans13 == "10")
                    {
                        val13 = 6;
                        break;
                    }
                    else if (ans13 == "11")
                    {
                        val13 = 55;
                        break;
                    }
                    else if (ans13 == "12")
                    {
                        val13 = 65;
                        break;
                    }
                    else if (ans13 == "13")
                    {
                        val13 = 75;
                        break;
                    }
                    else if (ans13 == "")
                    {
                        Console.WriteLine("Please select");
                        ans13 = Console.ReadLine();
                    }
                }

            //int total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8 + price9 + price10 + price11 + price12 + price13;
            int subtotal = val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9 + val10 + val11 + val12 + val13;

            Console.WriteLine("Amount to be paid: " + subtotal);
            double tax = subtotal * 0.10;
            Console.WriteLine("10% Tax: " + tax);
            double totalAmount = tax + subtotal;
            Console.WriteLine("Total Amount:  " + totalAmount);


           
            Console.WriteLine("Press M to go back to the menu, Q to quit");
            string valid = Console.ReadLine();
            while (true) {

                if (valid == "Q" || valid == "q")
                {
                    Environment.Exit(0);
                    break;

                } else if (valid == "M" || valid == "m") {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\n+----------------------------------------------------------------------+");
                    Console.WriteLine("\n\t\t\tLet's Start Again");
                    Console.Write("+----------------------------------------------------------------------+\n\n");


                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    for (int x = 0; x < items.Length; x++)
                    {
                        Console.WriteLine(items[x]);
                    }

                    //int price1,price2,price3,price4,price5,price6,price7,price8,price9,price10,price11,price12,price13;
                    //string ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10, ans11, ans12, ans13;
                    //int val1, val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13;

                    Console.WriteLine("Please choose 1");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    ans1 = Console.ReadLine();
                    while (true)
                    {
                        if (ans1 == "1")
                        {
                            val1 = 45;
                            break;
                        }
                        else if (ans1 == "2")
                        {
                            val1 = 72;
                            break;

                        }
                        else if (ans1 == "0")
                        {
                            val1 = 0;
                            break;
                        }
                        else if (ans1 == "3")
                        {
                            val1 = 10;
                            break;
                        }
                        else if (ans1 == "4")
                        {
                            val1 = 8;
                            break;
                        }
                        else if (ans1 == "5")
                        {
                            val1 = 15;
                            break;
                        }
                        else if (ans1 == "6")
                        {
                            val1 = 65;
                            break;
                        }
                        else if (ans1 == "7")
                        {
                            val1 = 130;
                            break;
                        }
                        else if (ans1 == "8")
                        {
                            val1 = 110;
                            break;
                        }
                        else if (ans1 == "9")
                        {
                            val1 = 35;
                            break;
                        }
                        else if (ans1 == "10")
                        {
                            val1 = 6;
                            break;
                        }
                        else if (ans1 == "11")
                        {
                            val1 = 55;
                            break;
                        }
                        else if (ans1 == "12")
                        {
                            val1 = 65;
                            break;
                        }
                        else if (ans1 == "13")
                        {
                            val1 = 75;
                            break;
                        }
                        else if (ans1 == "")
                        {
                            Console.WriteLine("Please select");
                            ans1 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");


                    ans2 = Console.ReadLine();
                    while (true)
                    {
                        if (ans2 == "1")
                        {
                            val2 = 45;
                            break;
                        }
                        else if (ans2 == "2")
                        {
                            val2 = 72;
                            break;

                        }
                        else if (ans2 == "0")
                        {
                            val2 = 0;
                            break;
                        }
                        else if (ans2 == "3")
                        {
                            val2 = 10;
                            break;
                        }
                        else if (ans2 == "4")
                        {
                            val2 = 8;
                            break;
                        }
                        else if (ans2 == "5")
                        {
                            val2 = 15;
                            break;
                        }
                        else if (ans2 == "6")
                        {
                            val2 = 65;
                            break;
                        }
                        else if (ans2 == "7")
                        {
                            val2 = 130;
                            break;
                        }
                        else if (ans2 == "8")
                        {
                            val2 = 110;
                            break;
                        }
                        else if (ans2 == "9")
                        {
                            val2 = 35;
                            break;
                        }
                        else if (ans2 == "10")
                        {
                            val2 = 6;
                            break;
                        }
                        else if (ans2 == "11")
                        {
                            val2 = 55;
                            break;
                        }
                        else if (ans2 == "12")
                        {
                            val2 = 65;
                            break;
                        }
                        else if (ans2 == "13")
                        {
                            val2 = 75;
                            break;
                        }
                        else if (ans2 == "")
                        {
                            Console.WriteLine("Please select");
                            ans2 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");


                    ans3 = Console.ReadLine();
                    while (true)
                    {
                        if (ans3 == "1")
                        {
                            val3 = 45;
                            break;
                        }
                        else if (ans3 == "2")
                        {
                            val3 = 72;
                            break;

                        }
                        else if (ans3 == "0")
                        {
                            val3 = 0;
                            break;
                        }
                        else if (ans3 == "3")
                        {
                            val3 = 10;
                            break;
                        }
                        else if (ans3 == "4")
                        {
                            val3 = 8;
                            break;
                        }
                        else if (ans3 == "5")
                        {
                            val3 = 15;
                            break;
                        }
                        else if (ans3 == "6")
                        {
                            val3 = 65;
                            break;
                        }
                        else if (ans3 == "7")
                        {
                            val3 = 130;
                            break;
                        }
                        else if (ans3 == "8")
                        {
                            val3 = 110;
                            break;
                        }
                        else if (ans3 == "9")
                        {
                            val3 = 35;
                            break;
                        }
                        else if (ans3 == "10")
                        {
                            val3 = 6;
                            break;
                        }
                        else if (ans3 == "11")
                        {
                            val3 = 55;
                            break;
                        }
                        else if (ans3 == "12")
                        {
                            val3 = 65;
                            break;
                        }
                        else if (ans3 == "13")
                        {
                            val3 = 75;
                            break;
                        }
                        else if (ans3 == "")
                        {
                            Console.WriteLine("Please select");
                            ans3 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans4 = Console.ReadLine();
                    while (true)
                    {
                        if (ans4 == "1")
                        {
                            val4 = 45;
                            break;
                        }
                        else if (ans4 == "2")
                        {
                            val4 = 72;
                            break;

                        }
                        else if (ans4 == "0")
                        {
                            val4 = 0;
                            break;
                        }
                        else if (ans4 == "3")
                        {
                            val4 = 10;
                            break;
                        }
                        else if (ans4 == "4")
                        {
                            val4 = 8;
                            break;
                        }
                        else if (ans4 == "5")
                        {
                            val4 = 15;
                            break;
                        }
                        else if (ans4 == "6")
                        {
                            val4 = 65;
                            break;
                        }
                        else if (ans4 == "7")
                        {
                            val4 = 130;
                            break;
                        }
                        else if (ans4 == "8")
                        {
                            val4 = 110;
                            break;
                        }
                        else if (ans4 == "9")
                        {
                            val4 = 35;
                            break;
                        }
                        else if (ans4 == "10")
                        {
                            val4 = 6;
                            break;
                        }
                        else if (ans4 == "11")
                        {
                            val4 = 55;
                            break;
                        }
                        else if (ans4 == "12")
                        {
                            val4 = 65;
                            break;
                        }
                        else if (ans4 == "13")
                        {
                            val4 = 75;
                            break;
                        }
                        else if (ans4 == "")
                        {
                            Console.WriteLine("Please select");
                            ans4 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");


                    ans5 = Console.ReadLine();
                    while (true)
                    {
                        if (ans5 == "1")
                        {
                            val5 = 45;
                            break;
                        }
                        else if (ans5 == "2")
                        {
                            val5 = 72;
                            break;

                        }
                        else if (ans5 == "0")
                        {
                            val5 = 0;
                            break;
                        }
                        else if (ans5 == "3")
                        {
                            val5 = 10;
                            break;
                        }
                        else if (ans5 == "4")
                        {
                            val5 = 8;
                            break;
                        }
                        else if (ans5 == "5")
                        {
                            val5 = 15;
                            break;
                        }
                        else if (ans5 == "6")
                        {
                            val5 = 65;
                            break;
                        }
                        else if (ans5 == "7")
                        {
                            val5 = 130;
                            break;
                        }
                        else if (ans5 == "8")
                        {
                            val5 = 110;
                            break;
                        }
                        else if (ans5 == "9")
                        {
                            val5 = 35;
                            break;
                        }
                        else if (ans5 == "10")
                        {
                            val5 = 6;
                            break;
                        }
                        else if (ans5 == "11")
                        {
                            val5 = 55;
                            break;
                        }
                        else if (ans5 == "12")
                        {
                            val5 = 65;
                            break;
                        }
                        else if (ans5 == "13")
                        {
                            val5 = 75;
                            break;
                        }
                        else if (ans5 == "")
                        {
                            Console.WriteLine("Please select");
                            ans5 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans6 = Console.ReadLine();
                    while (true)
                    {
                        if (ans6 == "1")
                        {
                            val6 = 45;
                            break;
                        }
                        else if (ans6 == "2")
                        {
                            val6 = 72;
                            break;

                        }
                        else if (ans6 == "0")
                        {
                            val6 = 0;
                            break;
                        }
                        else if (ans6 == "3")
                        {
                            val6 = 10;
                            break;
                        }
                        else if (ans6 == "4")
                        {
                            val6 = 8;
                            break;
                        }
                        else if (ans6 == "5")
                        {
                            val6 = 15;
                            break;
                        }
                        else if (ans6 == "6")
                        {
                            val6 = 65;
                            break;
                        }
                        else if (ans6 == "7")
                        {
                            val6 = 130;
                            break;
                        }
                        else if (ans6 == "8")
                        {
                            val6 = 110;
                            break;
                        }
                        else if (ans6 == "9")
                        {
                            val6 = 35;
                            break;
                        }
                        else if (ans6 == "10")
                        {
                            val6 = 6;
                            break;
                        }
                        else if (ans6 == "11")
                        {
                            val6 = 55;
                            break;
                        }
                        else if (ans6 == "12")
                        {
                            val6 = 65;
                            break;
                        }
                        else if (ans6 == "13")
                        {
                            val6 = 75;
                            break;
                        }
                        else if (ans6 == "")
                        {
                            Console.WriteLine("Please select");
                            ans6 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans7 = Console.ReadLine();
                    while (true)
                    {
                        if (ans7 == "1")
                        {
                            val7 = 45;
                            break;
                        }
                        else if (ans7 == "2")
                        {
                            val7 = 72;
                            break;

                        }
                        else if (ans7 == "0")
                        {
                            val7 = 0;
                            break;
                        }
                        else if (ans7 == "3")
                        {
                            val7 = 10;
                            break;
                        }
                        else if (ans7 == "4")
                        {
                            val7 = 8;
                            break;
                        }
                        else if (ans7 == "5")
                        {
                            val7 = 15;
                            break;
                        }
                        else if (ans7 == "6")
                        {
                            val7 = 65;
                            break;
                        }
                        else if (ans7 == "7")
                        {
                            val7 = 130;
                            break;
                        }
                        else if (ans7 == "8")
                        {
                            val7 = 110;
                            break;
                        }
                        else if (ans7 == "9")
                        {
                            val7 = 35;
                            break;
                        }
                        else if (ans7 == "10")
                        {
                            val7 = 6;
                            break;
                        }
                        else if (ans7 == "11")
                        {
                            val7 = 55;
                            break;
                        }
                        else if (ans7 == "12")
                        {
                            val7 = 65;
                            break;
                        }
                        else if (ans7 == "13")
                        {
                            val7 = 75;
                            break;
                        }
                        else if (ans7 == "")
                        {
                            Console.WriteLine("Please select");
                            ans7 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans8 = Console.ReadLine();
                    while (true)
                    {
                        if (ans8 == "1")
                        {
                            val8 = 45;
                            break;
                        }
                        else if (ans8 == "2")
                        {
                            val8 = 72;
                            break;

                        }
                        else if (ans8 == "0")
                        {
                            val8 = 0;
                            break;
                        }
                        else if (ans8 == "3")
                        {
                            val8 = 10;
                            break;
                        }
                        else if (ans8 == "4")
                        {
                            val8 = 8;
                            break;
                        }
                        else if (ans8 == "5")
                        {
                            val8 = 15;
                            break;
                        }
                        else if (ans8 == "6")
                        {
                            val8 = 65;
                            break;
                        }
                        else if (ans8 == "7")
                        {
                            val8 = 130;
                            break;
                        }
                        else if (ans8 == "8")
                        {
                            val8 = 110;
                            break;
                        }
                        else if (ans8 == "9")
                        {
                            val8 = 35;
                            break;
                        }
                        else if (ans8 == "10")
                        {
                            val8 = 6;
                            break;
                        }
                        else if (ans8 == "11")
                        {
                            val8 = 55;
                            break;
                        }
                        else if (ans8 == "12")
                        {
                            val8 = 65;
                            break;
                        }
                        else if (ans8 == "13")
                        {
                            val8 = 75;
                            break;
                        }
                        else if (ans8 == "")
                        {
                            Console.WriteLine("Please select");
                            ans8 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans9 = Console.ReadLine();
                    while (true)
                    {
                        if (ans9 == "1")
                        {
                            val9 = 45;
                            break;
                        }
                        else if (ans9 == "2")
                        {
                            val9 = 72;
                            break;

                        }
                        else if (ans9 == "0")
                        {
                            val9 = 0;
                            break;
                        }
                        else if (ans9 == "3")
                        {
                            val9 = 10;
                            break;
                        }
                        else if (ans9 == "4")
                        {
                            val9 = 8;
                            break;
                        }
                        else if (ans9 == "5")
                        {
                            val9 = 15;
                            break;
                        }
                        else if (ans9 == "6")
                        {
                            val9 = 65;
                            break;
                        }
                        else if (ans9 == "7")
                        {
                            val9 = 130;
                            break;
                        }
                        else if (ans9 == "8")
                        {
                            val9 = 110;
                            break;
                        }
                        else if (ans9 == "9")
                        {
                            val9 = 35;
                            break;
                        }
                        else if (ans9 == "10")
                        {
                            val9 = 6;
                            break;
                        }
                        else if (ans9 == "11")
                        {
                            val9 = 55;
                            break;
                        }
                        else if (ans9 == "12")
                        {
                            val9 = 65;
                            break;
                        }
                        else if (ans9 == "13")
                        {
                            val9 = 75;
                            break;
                        }
                        else if (ans9 == "")
                        {
                            Console.WriteLine("Please select");
                            ans9 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans10 = Console.ReadLine();
                    while (true)
                    {
                        if (ans10 == "1")
                        {
                            val10 = 45;
                            break;
                        }
                        else if (ans10 == "2")
                        {
                            val10 = 72;
                            break;

                        }
                        else if (ans10 == "0")
                        {
                            val10 = 0;
                            break;
                        }
                        else if (ans10 == "3")
                        {
                            val10 = 10;
                            break;
                        }
                        else if (ans10 == "4")
                        {
                            val10 = 8;
                            break;
                        }
                        else if (ans10 == "5")
                        {
                            val10 = 15;
                            break;
                        }
                        else if (ans10 == "6")
                        {
                            val10 = 65;
                            break;
                        }
                        else if (ans10 == "7")
                        {
                            val10 = 130;
                            break;
                        }
                        else if (ans10 == "8")
                        {
                            val10 = 110;
                            break;
                        }
                        else if (ans10 == "9")
                        {
                            val10 = 35;
                            break;
                        }
                        else if (ans10 == "10")
                        {
                            val10 = 6;
                            break;
                        }
                        else if (ans10 == "11")
                        {
                            val10 = 55;
                            break;
                        }
                        else if (ans10 == "12")
                        {
                            val10 = 65;
                            break;
                        }
                        else if (ans10 == "13")
                        {
                            val10 = 75;
                            break;
                        }
                        else if (ans10 == "")
                        {
                            Console.WriteLine("Please select");
                            ans10 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans11 = Console.ReadLine();
                    while (true)
                    {
                        if (ans11 == "1")
                        {
                            val11 = 45;
                            break;
                        }
                        else if (ans11 == "2")
                        {
                            val11 = 72;
                            break;

                        }
                        else if (ans11 == "0")
                        {
                            val11 = 0;
                            break;
                        }
                        else if (ans11 == "3")
                        {
                            val11 = 10;
                            break;
                        }
                        else if (ans11 == "4")
                        {
                            val11 = 8;
                            break;
                        }
                        else if (ans11 == "5")
                        {
                            val11 = 15;
                            break;
                        }
                        else if (ans11 == "6")
                        {
                            val11 = 65;
                            break;
                        }
                        else if (ans11 == "7")
                        {
                            val11 = 130;
                            break;
                        }
                        else if (ans11 == "8")
                        {
                            val11 = 110;
                            break;
                        }
                        else if (ans11 == "9")
                        {
                            val11 = 35;
                            break;
                        }
                        else if (ans11 == "10")
                        {
                            val11 = 6;
                            break;
                        }
                        else if (ans11 == "11")
                        {
                            val11 = 55;
                            break;
                        }
                        else if (ans11 == "12")
                        {
                            val11 = 65;
                            break;
                        }
                        else if (ans11 == "13")
                        {
                            val11 = 75;
                            break;
                        }
                        else if (ans11 == "")
                        {
                            Console.WriteLine("Please select");
                            ans11 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Select again");

                    ans12 = Console.ReadLine();
                    while (true)
                    {
                        if (ans12 == "1")
                        {
                            val12 = 45;
                            break;
                        }
                        else if (ans12 == "2")
                        {
                            val12 = 72;
                            break;

                        }
                        else if (ans12 == "0")
                        {
                            val12 = 0;
                            break;
                        }
                        else if (ans12 == "3")
                        {
                            val12 = 10;
                            break;
                        }
                        else if (ans12 == "4")
                        {
                            val12 = 8;
                            break;
                        }
                        else if (ans12 == "5")
                        {
                            val12 = 15;
                            break;
                        }
                        else if (ans12 == "6")
                        {
                            val12 = 65;
                            break;
                        }
                        else if (ans12 == "7")
                        {
                            val12 = 130;
                            break;
                        }
                        else if (ans12 == "8")
                        {
                            val12 = 110;
                            break;
                        }
                        else if (ans12 == "9")
                        {
                            val12 = 35;
                            break;
                        }
                        else if (ans12 == "10")
                        {
                            val12 = 6;
                            break;
                        }
                        else if (ans12 == "11")
                        {
                            val12 = 55;
                            break;
                        }
                        else if (ans12 == "12")
                        {
                            val12 = 65;
                            break;
                        }
                        else if (ans12 == "13")
                        {
                            val12 = 75;
                            break;
                        }
                        else if (ans12 == "")
                        {
                            Console.WriteLine("Please select");
                            ans12 = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("select 1 more");

                    ans13 = Console.ReadLine();
                    while (true)
                    {
                        if (ans13 == "1")
                        {
                            val13 = 45;
                            break;
                        }
                        else if (ans13 == "2")
                        {
                            val13 = 72;
                            break;

                        }
                        else if (ans13 == "0")
                        {
                            val13 = 0;
                            break;
                        }
                        else if (ans13 == "3")
                        {
                            val13 = 10;
                            break;
                        }
                        else if (ans13 == "4")
                        {
                            val13 = 8;
                            break;
                        }
                        else if (ans13 == "5")
                        {
                            val13 = 15;
                            break;
                        }
                        else if (ans13 == "6")
                        {
                            val13 = 65;
                            break;
                        }
                        else if (ans13 == "7")
                        {
                            val13 = 130;
                            break;
                        }
                        else if (ans13 == "8")
                        {
                            val13 = 110;
                            break;
                        }
                        else if (ans13 == "9")
                        {
                            val13 = 35;
                            break;
                        }
                        else if (ans13 == "10")
                        {
                            val13 = 6;
                            break;
                        }
                        else if (ans13 == "11")
                        {
                            val13 = 55;
                            break;
                        }
                        else if (ans13 == "12")
                        {
                            val13 = 65;
                            break;
                        }
                        else if (ans13 == "13")
                        {
                            val13 = 75;
                            break;
                        }
                        else if (ans13 == "")
                        {
                            Console.WriteLine("Please select");
                            ans13 = Console.ReadLine();
                        }
                    }

                    //int total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8 + price9 + price10 + price11 + price12 + price13;
                    subtotal = val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9 + val10 + val11 + val12 + val13;

                    Console.WriteLine("Amount to be paid: " + subtotal);
                    tax = subtotal * 0.10;
                    Console.WriteLine("10% Tax: " + tax);
                    totalAmount = tax + subtotal;
                    Console.WriteLine("Total Amount:  " + totalAmount);


                    valid = "";
                    Console.WriteLine("Press M to go back to the menu, Q to quit");
                    valid = Console.ReadLine();

                }

            }
            

            Console.ReadKey();
        }
    }
}