using System;
using System.Globalization;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Verificar se o número é negativo ou positivo

            int X;
            X = int.Parse(Console.ReadLine());

            if(X >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }*/

            /*// Verificar se número é impar ou par
            int num,verify;
            num = int.Parse(Console.ReadLine());
            verify = num % 2;
            if( verify == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }*/

            /*//Verificar se é mutiplo ou não
            int A, B;
            double verify, verify2;

            string[] values = Console.ReadLine().Split(' ');
            A = int.Parse(values[0]);
            B = int.Parse(values[1]);

            verify = A % B;
            verify2 = B % A;

            if(verify == 0.0 || verify2 == 0.0)
            {
                Console.WriteLine($"{A} e {B} São Multiplos");
            }
            else
            {
                Console.WriteLine($"{A} e {B} Não são Mulitplos");
            }*/

            /*// Ler dois valores, inicio e fim de um jogo e calcular o tempo decorrido
            int inicio, fim;
            string[] values = Console.ReadLine().Split(' ');
            inicio = int.Parse(values[0]);
            fim = int.Parse(values[1]);

            if(inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                if(inicio > fim)
                {
                    fim += 24;
                    Console.WriteLine($"O JOGO DUROU {fim-inicio} HORA(S)");
                }
                else
                {
                    Console.WriteLine($"O JOGO DUROU {fim-inicio} HORA(S)");
                }
            }*/

            /*// Cardapio
            double total = 0;
            string[] values = Console.ReadLine().Split(' ');
            int value = int.Parse(values[0]);
            int qtd = int.Parse(values[1]);

            if (value == 1)
            {
                total = qtd * 4.0;
            }
            else if (value == 2)
            {
                total = qtd * 4.5;
            }
            else if (value == 3)
            {
                total = qtd * 5.0;
            }
            else if (value == 4)
            {
                total = qtd * 2.0;
            }
            else if (value == 5)
            {
                total = qtd * 1.5;
            }

            Console.WriteLine("Total = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*// Verificar se esta no intervalo [0,25][25,50][50,75][75,100]

            double num = double.Parse(Console.ReadLine());
            if (num >= 0 && num <= 25)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (num > 25 && num <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (num > 50 && num <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (num > 75 && num <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo");
            }
            */

            /*// Verificação de quadrante
            string[] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem XY");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x == 0)
            {
                Console.WriteLine("Origem X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Origem Y");
            }*/

            /*//Imposto 0 ~ 2k - isento / 2k ~ 3k 8% / 3k ~ 4.5k - 18% / 4.5k ou mais - 28%
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double i2, i3, i4, i5, imposto = 0;
            if(salario > 2000)
            {
                if(salario > 3000)
                {
                    if(salario > 4500)
                    {
                        i2 = 1000;
                        imposto += i2 * 0.08;
                        i3 = 1500;
                        imposto += i3 * 0.18;
                        i4 = salario - 4500;
                        imposto += i4 * 0.28;
                    }
                    else
                    {
                        i2 = 1000;
                        imposto += i2 * 0.08;
                        i3 = salario - 3000;
                        imposto += i3 * 0.18;
                    }
                }
                else
                {
                    i2 = salario - 2000;
                    imposto += i2 * 0.08;
                }
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Isento");
            }*/

        }
    }
}