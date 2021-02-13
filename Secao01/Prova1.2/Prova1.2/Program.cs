using System;

namespace Prova1._2 {
    class Program {
        static void Main(string[] args) {
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o raio do círculo:");
            raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A={0}", area.ToString("F4"));
        }
    }
}
