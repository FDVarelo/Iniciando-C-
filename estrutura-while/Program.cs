using System;
using System.Globalization;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x ; i++)
            {
                if (i % 2 != 0) { Console.WriteLine(i); }
            }*/

            /*int inside = 0, outside = 0, num, x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                num = int.Parse(Console.ReadLine());
                if(num >=10 && num <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }
            Console.WriteLine($"{inside} in\n{outside} out");*/


            /*int x = int.Parse(Console.ReadLine());
            float a, b, c;
            for(int i = 0; i < x; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                a = float.Parse(values[0], CultureInfo.InvariantCulture);
                b = float.Parse(values[1], CultureInfo.InvariantCulture);
                c = float.Parse(values[2], CultureInfo.InvariantCulture);

                Console.WriteLine(((a*2+b*3+c*5)/10).ToString("F1", CultureInfo.InvariantCulture));
            }*/

            /*int x = int.Parse(Console.ReadLine());
            float a, b;
            for(int i = 0; i < x; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                a = float.Parse(values[0], CultureInfo.InvariantCulture);
                b = float.Parse(values[1], CultureInfo.InvariantCulture);
                if(b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((a / b).ToString("F1", CultureInfo.InvariantCulture));
                }
            }*/

            /*int soma=1,x = int.Parse(Console.ReadLine());
            for (int i = x; i >= 1; i--)
            {
                soma *= i;
            }
            Console.WriteLine(soma);*/


            /*int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/


            /*int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }*/


        }
    }
}