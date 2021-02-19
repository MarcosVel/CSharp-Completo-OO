using System;

namespace _35_Exercicio_07 {
    class Program {
        static void Main(string[] args) {
            int valor;

            Console.Write("Entrada: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Saída:");

            for (int i = 1; i <= x; i++) {
                for (int j = 1; j <= 3; j++) {
                    valor = (int)Math.Pow(i, j);
                    Console.Write($"{valor} ");
                }
                Console.WriteLine();
            }
        }
    }
}
