using System;

namespace _35_Exercicio_06 {
    class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (x % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
