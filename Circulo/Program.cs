using System;
using System.Globalization;

namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Voludme: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
