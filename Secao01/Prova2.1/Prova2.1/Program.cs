using System;

namespace Prova2._1 {
    class Program {
        static void Main(string[] args) {
            int cod, qtd;
            double total;

            Console.WriteLine("Digite um código e a qtd:");
            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            switch (cod) {
                case 1:
                    total = qtd * 4.00;
                    break;
                case 2:
                    total = qtd * 4.50;
                    break;
                case 3:
                    total = qtd * 5.00;
                    break;
                case 4:
                    total = qtd * 2.00;
                    break;
                default:
                    total = qtd * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2"));
        }
    }
}
