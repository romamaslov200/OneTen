using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTen
{
    internal class Switchs
    {
        functions functions = new functions();
        public void cases(int i) 
        {
            switch(i)
            {
                case 1:
                    functions.OneTen();
                    break;
                case 2:
                    functions.EvenNumbers();
                    break;
                case 3:
                    functions.Multiplication();
                    break;
                case 4:
                    functions.MyFactorial();
                    break;
                case 5:
                    functions.NotEvenNumbers();
                    break;
                case 6:
                    functions.PrimeNumbers();
                    break;
                case 7:
                    functions.ReverseText();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Вы ввели не допустимое число!!!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}
