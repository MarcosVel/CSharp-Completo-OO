using System;
using System.Globalization;

namespace _24_Exercicio_06 {
    class Program {
        static void Main(string[] args) {
            double a, b, c, areaTrianguloRet, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            areaTrianguloRet = (a * c) / 2;
            areaCirculo = pi * (Math.Pow(c, 2));
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRet.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
