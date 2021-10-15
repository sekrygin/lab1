using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число с плавающей запятой: ");
            double x = Convert.ToDouble(Console.ReadLine());
            int d = (int)((x - (int)x) * 10);
            Console.WriteLine(d);





        }
    }
}