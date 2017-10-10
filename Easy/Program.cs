using System;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number!");

                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 10)
                {
                    Console.WriteLine("This number is too small");
                }
                else if (userInput >= 10)
                {
                    Console.WriteLine("This number is big enough");
                    break;
                }
            }
        }
    }
}
