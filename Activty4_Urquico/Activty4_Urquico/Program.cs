using System;

namespace Activty4_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNum, fifthNum, sixthNum, seventhNum, eightNum, ninthNum, TenthNum,eleventhNum,twelveNum;

            Console.WriteLine("\t\tActivity 4 - Operators\n");

            Console.WriteLine("\n+-----------------------------------------------+");
            Console.WriteLine("Functions to compute for the sum of three numbers");
            Console.WriteLine("+-----------------------------------------------+\n");

            Console.Write("Please Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine()); 
            Console.Write("Please Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the third number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The sum of two numbers is " + sum);


            Console.WriteLine("\n+-----------------------------------------------+");
            Console.WriteLine("Functions to compute for the difference of three numbers");
            Console.WriteLine("+-----------------------------------------------+\n");

            Console.Write("Please Enter the first number: ");
            fourthNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the second number: ");
            fifthNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the third number: ");
            sixthNum = int.Parse(Console.ReadLine());

            int difference = fourthNum - fifthNum - sixthNum;
            Console.WriteLine("The difference of two numbers is " + difference);


            Console.WriteLine("\n+-----------------------------------------------+");
            Console.WriteLine("Functions to compute for the product of three numbers");
            Console.WriteLine("+-----------------------------------------------+\n");

            Console.Write("Please Enter the first number: ");
            seventhNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the second number: ");
            eightNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the third number: ");
            ninthNum = int.Parse(Console.ReadLine());

            int product = seventhNum * eightNum * ninthNum;
            Console.WriteLine("The product of two numbers is " + product);

            Console.WriteLine("\n+-----------------------------------------------+");
            Console.WriteLine("Functions to compute for the quotient of three numbers");
            Console.WriteLine("+-----------------------------------------------+\n");

            Console.Write("Please Enter the first number: ");
            TenthNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the second number: ");
            eleventhNum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the third number: ");
            twelveNum = int.Parse(Console.ReadLine());

            int quotient = TenthNum / eleventhNum / twelveNum;
            Console.WriteLine("The quotient of two numbers is " + quotient);


            /*
                Urquico,Kurt Jacob E.
                3180105
                ICT11-A
             */

            Console.ReadKey();

        }
    }
}