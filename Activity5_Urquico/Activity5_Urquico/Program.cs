using System;

namespace Activity5_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {

            double tempInput;

            Console.Write("Please Enter temperature: ");
            tempInput = Convert.ToDouble(Console.ReadLine());

            if (tempInput <= 0) {
                Console.WriteLine("It is a freezing weather");
            }
            else if (tempInput <= 10)
            {
                Console.WriteLine("It is a Very Cold weather");
            }
            else if (tempInput <= 20)
            {
                Console.WriteLine("It is a Cold weather");
            }
            else if (tempInput <= 30)
            {
                Console.WriteLine("It is a Normal weather");
            }
            else if (tempInput < 40)
            {
                Console.WriteLine("It is a hot weather");
            }
            else if (tempInput >= 40)
            {
                Console.WriteLine("It is a very hot weather");
            }



            Console.ReadKey();

        }
    }
}