using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelenProject
{
    class Program
    {


        public static void Main(string[] args)

        {
            int num1, opt;

            Console.WriteLine("Select your Planets!");
            Console.WriteLine("\n1-Mercury. \n2-Venus. \n3-Mars");
            Console.WriteLine("\nChose your Planet");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("Enter your weight");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Your weight on Mercury would be: {2}\n", num1, 0.37, num1 * 0.37);

                    break;
            }
        }
    }
}
