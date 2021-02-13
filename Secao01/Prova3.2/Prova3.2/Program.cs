using System;

namespace Prova3._2 {
    class Program {
        static void Main(string[] args) {
            int N, X, 
                qtdIn = 0, 
                qtdOut = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) {
                    qtdIn += 1;
                } else {
                    qtdOut += 1;
                }
            }

            Console.WriteLine("{0} in", qtdIn);
            Console.WriteLine("{0} out", qtdOut);
        }
    }
}
