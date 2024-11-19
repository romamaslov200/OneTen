using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanLib;

namespace OneTen
{
    internal class functions
    {
        Proverka proverkaType = new Proverka();
        public void OneTen()
        {
            int count;
            count = proverkaType.Type<int>("Введитн число => ");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void EvenNumbers() 
        {
            int count;
            count = proverkaType.Type<int>("Введитн число => ");

            for (int i = 0; i < count; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void NotEvenNumbers()
        {
            int count;
            count = proverkaType.Type<int>("Введитн число => ");

            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Multiplication()
        {
            int count;
            count = proverkaType.Type<int>("Введитн число => ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{count} x {i} = {count * i}");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void MyFactorial()
        {
            int count = 0;
            count = proverkaType.Type<int>("Введитн число => ");
            int FinalCount = count;


            for (int i = count; i > 0 && i != 0; i--)
            {
                FinalCount = FinalCount * (i - 1);
                Console.WriteLine(FinalCount);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void PrimeNumbers()
        {
            int MinCount;
            int MaxCount;
            
            MinCount = proverkaType.Type<int>("Введитн мин число => ");
            MaxCount = proverkaType.Type<int>("Введитн макс число => ");


            for (int i = MinCount; i <= MaxCount; i++)
            {
                if (Math.Sqrt(i) + 1 < i) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void ReverseText()
        {
            Console.Write("Введитн ваш текст => ");
            string text = Console.ReadLine();
            string FinalText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                FinalText += text[i];
            }
            Console.WriteLine(FinalText);
            Console.ReadKey();
            Console.Clear();
        }

        public void GameRandom()
        {
            Random rnd = new Random();

            rnd.Next(0,10);
        }

    }
}
