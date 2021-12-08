//10.Даний масив розміру N і число k до (0 < k < N). Здійснити циклічне зсув елементів масиву ліворуч (праворуч) на k позицій. 

using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] array;
            int[] array_2;
            int N = 0,
                k = 0;
            string answer;

            do
            {
                Console.WriteLine("Введіть к-ть елементів масива:");
                answer = Console.ReadLine();
                N = Convert.ToInt32(answer);
            } while (N <= 0);

            array = new int[N];
            array_2 = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine("Початковий масив: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine("Введіть на яку к-ть елементів зсунути масив:");
                k = int.Parse(Console.ReadLine());
            } while (k <= 0 || k >= N);

            for (int i = 0, j = k; i < N - k; i++, j++)
            {
                array_2[i] = array[j];
            }

            for (int i = N - k, j = 0; i < N; i++, j++)
            {
                array_2[i] = array[j];
            }

            Console.WriteLine("Масив після зсуву: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write(array_2[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

