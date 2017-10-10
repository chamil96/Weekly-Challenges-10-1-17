using System;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            var space = " ";
            var symbol = "*";

            //Creates total number of rows
            for (var i = 1; i < 6; i++)
            {
                //Decreases spaces by one
                for (var x = 5; x > i; x--)
                {
                    Console.Write(space);
                }
                //takes row number multiply by 2 and subtracts one, the answer is how many symbols we put in that particular row
                for (var a = 1; a <= (2 * i - 1); a++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
    }
}
