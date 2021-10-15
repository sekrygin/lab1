using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, matrixdet; double x, y, z, determinant_x, determinant_y, determinant_z;
            string a, b, c, d;
            Console.Write("Введите а1 "); a = Console.ReadLine(); a1 = Convert.ToInt32(a);
            Console.Write("Введите b1 "); b = Console.ReadLine(); b1 = Convert.ToInt32(b);
            Console.Write("Введите c1 "); c = Console.ReadLine(); c1 = Convert.ToInt32(c);
            Console.Write("Введите d1 "); d = Console.ReadLine(); d1 = Convert.ToInt32(d);
            while (d1 == 0)
            {
                Console.WriteLine("d1 не может равнятся 0 " + " Введите его снова");
                d = Console.ReadLine(); d1 = Convert.ToInt32(d);
                Console.WriteLine("d1 = " + d1);
            }
            Console.Write("Введите а2 "); a = Console.ReadLine(); a2 = Convert.ToInt32(a);
            Console.Write("Введите b2 "); b = Console.ReadLine(); b2 = Convert.ToInt32(b);
            Console.Write("Введите c2 "); c = Console.ReadLine(); c2 = Convert.ToInt32(c);
            Console.Write("Введите d2 "); d = Console.ReadLine(); d2 = Convert.ToInt32(d);
            while (d2 == 0)
            {
                Console.WriteLine("d2 не может равнятся 0 " + " Введите его снова");
                d = Console.ReadLine(); d2 = Convert.ToInt32(d);
                Console.WriteLine("d2 = " + d2);
            }
            Console.Write("Введите а3 "); a = Console.ReadLine(); a3 = Convert.ToInt32(a);
            Console.Write("Введите b3 "); b = Console.ReadLine(); b3 = Convert.ToInt32(b);
            Console.Write("Введите c3 "); c = Console.ReadLine(); c3 = Convert.ToInt32(c);
            Console.Write("Введите d3 "); d = Console.ReadLine(); d3 = Convert.ToInt32(d);
            while (d3 == 0)
            {
                Console.WriteLine("d3 не может равнятся 0 " + " Введите его снова");
                d = Console.ReadLine(); d3 = Convert.ToInt32(d);
                Console.WriteLine("d3 = " + d3);
            }
            matrixdet = a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2 - a1 * b3 * c2 - a2 * b1 * c3 - a3 * b2 * c1;
            Console.WriteLine("Определите матрицы равен = " + matrixdet);
            if (matrixdet == 0)
            {
                Console.WriteLine("Определитель матрицы = 0");
            }
            else
            {
                determinant_x = d1 * b2 * c3 + d2 * b3 * c1 + d3 * b1 * c2 - d1 * b3 * c2 - d2 * b1 * c3 - d3 * b2 * c1;
                x = determinant_x / matrixdet;
                determinant_y = a1 * d2 * c3 + a2 * d3 * c1 + a3 * d1 * c2 - a1 * d3 * c2 - a2 * d1 * c3 - a3 * d2 * c1;
                y = determinant_y / matrixdet;
                determinant_z = a1 * b2 * d3 + a2 * b3 * d1 + a3 * b1 * d2 - a1 * b3 * d2 - a2 * b1 * d3 - a3 * b2 * d1;
                z = determinant_z / matrixdet;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
            }

        }
    }
}