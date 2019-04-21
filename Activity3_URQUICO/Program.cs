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
            Console.Write("\n\n\nStudents' name: \n");
            
            
            

            Console.Write("Student ID No.: \n");
            

            Console.Write("Section: \n");

            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");

            Console.WriteLine("What math operation do you want to do to your data ? ");
            
            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");
                for(int x = 0; x < operators.Length; x++){
                    Console.WriteLine("\t" + operators[x]);
                }
            Console.WriteLine("+-----------------------------------------------------------------------------------+");
            Console.WriteLine("+***********************************************************************************+");
            Console.WriteLine("\nExit ? Press Y to exit, Press N to return to menu");
            
            
            
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
