using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int value = 0,
                number = 0,
                sum1 = 0,
                sum2 = 0;
            string answer;

            Console.WriteLine("Перевірка чи сума двох перших цифр чотиризначного числа рівна сумі двох його останніх цифр.");

            do
            {
                Console.WriteLine("Введіть 4-x значне число:");
                answer = Console.ReadLine();
                value = Convert.ToInt32(answer);
            } while (value <= 1000 || value >= 9999);

            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    number = value % 10;
                    value /= 10;
                    sum1 += number;
                }
                else
                {
                    number = value % 10;
                    value /= 10;
                    sum2 += number;
                }
            }

            Console.WriteLine("Результат:");

            if (sum1 == sum2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

