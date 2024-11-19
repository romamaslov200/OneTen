using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanLib;

namespace OneTen
{
    internal class Program
    {
        static Proverka proverkaType = new Proverka();
        static Switchs switchs = new Switchs();
        static void Main(string[] args)
        {
            while (true)
            {
                int number;

                Console.WriteLine("1. Вывод чисел от 0 до вашего значения.\n2. Вывод на экран всех чотных чисел от 0 до вашего значения.\n3. Вывод таблици умножения для вашего числа.\n4. Вывод факториала вашего числа.\n5. Вывод на экран всех нечотных чисел от 0 до вашего числа.\n6. Вывод простых чисел в вашем диапозоне.\n7. Переворачивание вашей строки.");
                number = proverkaType.Type<int>("Введите чило для выбора функции => ");
                switchs.cases(number);
            }
        }
    }
}
