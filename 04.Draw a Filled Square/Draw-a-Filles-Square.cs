using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void PrintMiddleRow(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }
    }
}
