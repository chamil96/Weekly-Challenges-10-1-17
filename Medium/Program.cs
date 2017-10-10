using System;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = "*";
            for (var i = 0; i < 5; i++)
            {
                for (var x = 0; x < 10; x++)
                {
                    Console.Write(symbol);
                }

                Console.Write("\n");
            }
        }
    }
}
