using System;

namespace _35_Exercicio_01 {
    class Program {
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i <= X; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
