using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double g = 9.8;
            double time;
            double height;
            string answer;

            Console.WriteLine("Обчислення часу вільного падіння тіла...");
            Console.WriteLine("Введіть висоту (в метрах): ");

            answer = Console.ReadLine();

            height = Convert.ToDouble(answer);

            time = Math.Sqrt(2 * height / g);

            Console.WriteLine($"Час вільного падіння тіла {time} с.");
        }
    }
}
