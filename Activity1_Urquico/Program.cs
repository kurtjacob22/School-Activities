using System;

namespace Activity1_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, result;

            Console.WriteLine("Hello User");
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first number: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", num1,num2,num3,num4,result);

            Console.ReadKey();
        }
    }
}