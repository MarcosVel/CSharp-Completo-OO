using System;

namespace Prova2._2 {
    class Program {
        static void Main(string[] args) {
            double a, b, c, X1, X2, delta;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            delta = Math.Pow(b, 2.0) - (4.0 * a * c);

            if (a == 0 || delta < 0) {
                Console.WriteLine("Impossível calcular");
            } 
            else {
                X1 = (- b + Math.Sqrt(delta)) / (2.0 * a);
                X2 = (- b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = {0}", X1.ToString("F5"));
                Console.WriteLine("X2 = {0}", X2.ToString("F5"));
            }
            
        }
    }
}
