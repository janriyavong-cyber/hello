using System;

namespace PatternSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            // รับค่าจากผู้ใช้
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input symbol: ");
            string symbol = Console.ReadLine();

            // ลูปวาดรูป
            for (int y = 0; y <= 20; y++)
            {
                for (int x = 0; x <= 20; x++)
                {
                    // เงื่อนไขในการวาดรูป (เปลี่ยนสมการตรงนี้เพื่อให้เป็นรูปเพชร)
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
