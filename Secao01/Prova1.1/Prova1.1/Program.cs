using System;

namespace Prova1._1 {
    class Program {
        static void Main(string[] args) {

            int codPeca1, codPeca2, qtdPeca1, qtdPeca2;
            double precoPeca1, precoPeca2, totalPeca1, totalPeca2, valorPagar;

            Console.WriteLine("Digite o cod, qtd e preço");
            string[] vet = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(vet[0]);
            qtdPeca1 = int.Parse(vet[1]);
            precoPeca1 = double.Parse(vet[2]);

            Console.WriteLine("Digite o cod2, qtd2 e preço2");
            string[] vet2 = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(vet2[0]);
            qtdPeca2 = int.Parse(vet2[1]);
            precoPeca2 = double.Parse(vet2[2]);

            totalPeca1 = (double) qtdPeca1 * precoPeca1;
            totalPeca2 = (double) qtdPeca2 * precoPeca2;
            valorPagar = totalPeca1 + totalPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorPagar.ToString("F2"));
        }
    }
}
