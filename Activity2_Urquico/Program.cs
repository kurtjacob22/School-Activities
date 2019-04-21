using System;

namespace Activity2_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            double math,science,english,filipino,PE,computer,socialScience,result;

            Console.WriteLine("Hello User");
            Console.WriteLine("Please Enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Please Enter your Grade in Math: ");
            math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in science: ");
            science = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in english: ");2

            english = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in filipino: ");
            filipino = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in PE: ");
            PE = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in computer: ");
            computer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter your Grade in socialScience: ");
            socialScience = Convert.ToDouble(Console.ReadLine());

            result = (math + science + english + filipino + PE + computer + socialScience) / 7;




            Console.WriteLine("The Average grade of " + name + " is " + result);


            Console.ReadKey();
        }
    }
}