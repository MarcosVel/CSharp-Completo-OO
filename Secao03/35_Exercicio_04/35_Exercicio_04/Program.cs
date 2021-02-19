using System;

namespace _35_Exercicio_04 {
    class Program {
        static void Main(string[] args) {
            int num1, num2;
            double divisão;

            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                num1 = int.Parse(vet[0]);
                num2 = int.Parse(vet[1]);

                if (num2 == 0) {
                    Console.WriteLine("divisão impossivel");
                } else {
                    divisão = (double)num1 / num2;
                    Console.WriteLine($"{divisão:f1}");
                }
            }
        }
    }
}
