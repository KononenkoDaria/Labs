using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int nn = -1,
                nk = 0;
            double result = 1;
            string answer;

            do
            {
                Console.WriteLine("Введіть перше число (воно має бути невід'ємне і менше або рівне другого числа):");
                answer = Console.ReadLine();
                nn = Convert.ToInt32(answer);
            } while (nn < 0);

            do
            {
                Console.WriteLine("Введіть друге число:");
                answer = Console.ReadLine();
                nk = Convert.ToInt32(answer);
            } while (nk < nn);

            for (int k = nn; k <= nk; k++)
            {
                result *= Math.Pow(-1, Math.Pow(k, 2.0) + k + 1) * Math.Pow(k, 2.0) / (2 * Math.Pow(k, 2.0) + 5);
            }

            Console.WriteLine($"Відповідь: {result}");

            Console.ReadLine();
        }
    }
}

