using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        private static int GetSumOfOddsDigits(int n)
        {
            int sumOddsDigits = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOddsDigits += lastDigit;
                }
                n = n / 10;
            }
            return sumOddsDigits;
        }
        private static int GetSumOfEvensDigits(int n)
        {
            int sumEvensDigits = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvensDigits += lastDigit;
                }
                n = n / 10;
            }
            return sumEvensDigits;
        }
        private static int GetProductOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvensDigits(n);
            int sumOdds = GetSumOfOddsDigits(n);

            return sumEvens * sumOdds;
        }
        
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetProductOfEvensAndOdds(n));
        }
    }
}
