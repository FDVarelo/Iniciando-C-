using System;
using System.Globalization;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Verificar senha
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");*/

            /*//Verificar quadrante até ser nulo no x ou no y
            static void VerificarQuadrante(int x, int y)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
            }

            int x, y;
            string[] values = Console.ReadLine().Split(' ');
            x = int.Parse(values[0]);
            y = int.Parse(values[1]);
            VerificarQuadrante(x, y);

            while (x != 0 && y != 0)
            {
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
                VerificarQuadrante(x, y);
            }*/


            /*//Verificar qual combustivl é o favorito dos clientes
            int a = 0, g = 0, d = 0;
            int x = int.Parse(Console.ReadLine());
            while (x != 4)
            {
                if (x == 1)
                {
                    a += 1;
                }
                else if (x == 2)
                {
                    g += 1;
                }
                else if (x == 3)
                {
                    d += 1;
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {a}\nGasolina: {g}\nDiesel: {d}");*/


        }
    }
}