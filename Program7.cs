using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, Reverse = null;
            Console.Write("Введите трехзначное число "); num = Console.ReadLine();
            while (num.Length != 3)
            {
                Console.WriteLine("Введите трехзначное число"); num = Console.ReadLine();
                continue;
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Reverse = Reverse + num[i];
            }
            Console.WriteLine("Число " + num + " в обратном порядке -> " + Reverse);
        }
    }
}