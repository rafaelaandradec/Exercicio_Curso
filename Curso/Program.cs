using System;
//exercícios em C#
namespace Curso
{
    class Program
    {   
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine("O valor de x é " + x);
            Console.WriteLine("O valor de y é " + y);

            

            int m;
            double n;

            m = 5;
            n = 2 * m;

            Console.WriteLine("O valor de m é " + m);
            Console.WriteLine("O valor de n é " + n + " sendo ele um double.");

            //sempre indicar o tipo do número, se a expressão for de ponto flutuante
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
            Console.WriteLine("O tamanho da area de um trapézio é de " + area);

            //casting
            int a, c;
            double resultado;
            a = 5;
            c = 2;

            resultado = (double) a / c;
            Console.WriteLine("Resultado do casting é " + resultado);


            double d;
            int e;

            d = 5.0;
            e = (int) d;
            Console.WriteLine("Resultado do casting é " + e);


            Console.ReadLine();

        }
    }
}
