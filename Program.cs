/*Написати програму, що виконує наступні функції 
1.	Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
4.	Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
5.	Виконати пункт 4 з використанням ключових слів ref i out
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("1. Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)");
            Console.WriteLine(Reverse(1234));

            Console.WriteLine("2. Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)");
            Console.WriteLine(Reverse("АБВ"));

            Console.WriteLine("3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)");
            Console.WriteLine(Reverse(123.456));

            Console.WriteLine("4. Реалізувати метод, що буде масив повертати задом навпаки використовуючи ref чи out (Використання Array.Reverse() заборонено!)");
            string[] strArr = { "big", "brown", "fox", "or", "maybe", "even", "bear" };
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

            Console.WriteLine("Before:");
            foreach (var element in intArr)
            {
                Console.Write(element + " ");
            }

            ReverseArray(ref intArr);
            Console.WriteLine("\nReversed:");
            foreach (var element in intArr)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\nBefore:");
            foreach (var element in strArr)
            {
                Console.Write(element + " ");
            }
            ReverseArray(ref strArr);

            Console.WriteLine("\nReversed:");
            foreach (var element in strArr)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }

        public static string Reverse(string str)
        {
            string answer = "";
            foreach (char character in str)
            {
                answer = character + answer;
            }
            return answer;
        }
        public static string Reverse(int number)
        {
            string numberInString = number.ToString();
            string answer = Reverse(numberInString);
            return answer;
        }
        public static string Reverse(double doubledNum)
        {
            string integer = ((int)doubledNum).ToString();
            string wholeFraction = doubledNum.ToString().Substring(integer.Length + 1);
            string answer = Reverse(integer) + "." + Reverse(wholeFraction);
            return answer;
        }

        public static void ReverseArray<T>(ref T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int secondBorder = length - 1 - i;
                var temp = array.GetValue(secondBorder);
                array.SetValue(array.GetValue(i), secondBorder);
                array.SetValue(temp, i);
            }

        }
    }
}
