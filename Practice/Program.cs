using System.Text;

namespace Practice
{
    internal class Solution
    {
        public static string Solution1(decimal initialDeposit, int years, double interestRate)
        {
            var procent = interestRate / 100 + 1;
            var resultLines = new StringBuilder();

            for (int year = 0; year < years; year++)
            {
                resultLines.Append($"Год {year + 1}: {initialDeposit * (decimal)Math.Pow(procent, year + 1):F2}\n");
            }
            return resultLines.ToString();
        }

        public static void Solution2(int n)
        {
            if (n % 2 == 0) throw new ArgumentException("Length must be odd");
            int mid = n / 2;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == Math.Abs(mid - row) || col == n - 1 - Math.Abs(mid - row)) Console.Write("X");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution1(1000, 3, 10));

            Solution2(7); 
        }
    }
}
