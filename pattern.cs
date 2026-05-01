using System;

namespace PatternSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input symbol: ");
            string symbol = Console.ReadLine();

            
            for (int y = 0; y <= 20; y++)
            {
                for (int x = 0; x <= 20; x++)
                {
                    
                    if ((Math.Abs(x - 10) + Math.Abs(y - 10)) <= n)
                    {
                        Console.Write(symbol + " ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}