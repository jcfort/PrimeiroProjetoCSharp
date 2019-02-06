using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //programa ESTOQUE

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            TimeSpan t1 = new TimeSpan(12, 10, 10);
            TimeSpan t2 = new TimeSpan(12, 45, 20);
            TimeSpan dif = t2.Subtract(t1);
            Console.WriteLine("Tempo utilizado: {0}", dif);


            DateTime d3 = new DateTime(2019, 2, 6, 13, 2, 0, DateTimeKind.Local);
            Console.WriteLine("Hora local: {0}", d3.ToLocalTime());
            Console.WriteLine("Hora UTC: {0}", d3.ToUniversalTime());
            Console.WriteLine();

            TimeSpan tt0 = new TimeSpan(0, 0, 0);
            TimeSpan tt1 = new TimeSpan(0,18,30);
            TimeSpan tt2 = new TimeSpan(0,4,33);
            TimeSpan tt3 = new TimeSpan(0,5,21);
            TimeSpan tt4 = new TimeSpan(0,5,57);
            TimeSpan tt5 = new TimeSpan(0,22,45);
            TimeSpan tt6 = new TimeSpan(0,18,10);
            TimeSpan tt7 = new TimeSpan(0,19,55);
            TimeSpan tt8 = new TimeSpan(0,5,13);

            TimeSpan tempototal = tempototal.Add(tt1 + tt2 + tt3 + tt4 + tt5 + tt7 + tt7 + tt8);
            Console.WriteLine("Tempo total da seção 09 é: {0}",tempototal);
            








            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores das bases do triangulo X:");
            Console.Write("Digite o Vaor de A: ");
            x.A = double.Parse(Console.ReadLine());
            Console.Write("Digite o Vaor de B: ");
            x.B = double.Parse(Console.ReadLine());
            Console.Write("Digite o Vaor de C: ");
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores das bases do triangulo Y:");
            Console.Write("Digite o Vaor de A: ");
            y.A = double.Parse(Console.ReadLine());
            Console.Write("Digite o Vaor de B: ");
            y.B = double.Parse(Console.ReadLine());
            Console.Write("Digite o Vaor de C: ");
            y.C = double.Parse(Console.ReadLine());


            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine(areaX);
            Console.WriteLine(areaY);


            int n1 = 0;

            Console.WriteLine("INSTRUÇÕES");
            Console.WriteLine("Digite um numero negativo para finalzar o programa.");
            Console.WriteLine("");
            Console.WriteLine("===================================================");
            Console.WriteLine("");

            while (n1 >= 0)
            {
                Console.Write("Digite o numero base DECIMAL: ");
                n1 = int.Parse(Console.ReadLine());

                if (n1 >= 0)
                {
                    Console.WriteLine($"O numero digitado convertido para HEXA é:        =====> {n1.ToString("X")} <=====");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Fim do programa. Obrigado!");
                }
            }
        }
    }
}
