using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Soma simples de dois valores
             * int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Soma = " + c);
            */

            /* // Raio de um circulos com um print em 4 casas decimais
            double R, a, pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = pi * R * R;
            Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));
            */

            /* // diferenca de (a * b - c * d)
            int a, b, c, d, diferenca;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
            */

            /* // Ler número do funcionario, horas trabalhadas e o preço da hora trabalhada
            // printar o número do funcionario, e o salario dele
            int num, horas;
            float preco_hora,salario;

            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            preco_hora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + (horas*preco_hora).ToString("F2", CultureInfo.InvariantCulture));
            */

            /*// Ler codigo de peça, num de peças e o valor da peça, printar valor total a pagar
            // multiplas leituras em uma linha
            int cod1,cod2,qtd1,qtd2;
            float valor1,valor2;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            valor1 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            valor2 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("VALOR A PAGAR: R$ " + (qtd1*valor1+qtd2*valor2).ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //Ler A,B,C de dupla precisão e calcular:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B

            double A, B, C, pi = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("a) Triangulo → " + ((A*C)/2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("b) Circulo → " + (pi*C*C).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("c) Trapezio → " + (((A + B) * C) / 2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("d) Quadrado → " + (B*B).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("e) Retangulo → " + (A*B).ToString("F3", CultureInfo.InvariantCulture));
            */
        }
    }
}