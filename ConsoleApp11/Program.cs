using System;

namespace ConsoleApp11
{
    class program
    {
        static void Main(string[] arg)
        {

            Console.WriteLine("enter the your number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a%3 == 0 && a%7 == 0)
            {
                Console.WriteLine("Multiple of 3 and 7");
            }

            else
            {
                Console.WriteLine("not Multiple of any given  digits");
            }
            Console.ReadLine();


        }
    }
}
