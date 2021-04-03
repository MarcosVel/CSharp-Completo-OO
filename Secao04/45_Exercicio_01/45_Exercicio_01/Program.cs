using System;
using System.Globalization;

namespace _45_Exercicio_01 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("L: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("A: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
