using System;

namespace _24_Exercicio_05 {
    class Program {
        static void Main(string[] args) {
            int codPeca1, numPeca1, codPeca2, numPeca2;
            double valorUnit1, valorUnit2, totalPeca1, totalPeca2, total;

            string[] peca1 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(peca1[0]);
            numPeca1 = int.Parse(peca1[1]);
            valorUnit1 = double.Parse(peca1[2]);

            string[] peca2 = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(peca2[0]);
            numPeca2 = int.Parse(peca2[1]);
            valorUnit2 = double.Parse(peca2[2]);

            totalPeca1 = numPeca1 * valorUnit1;
            totalPeca2 = numPeca2 * valorUnit2;
            total = totalPeca1 + totalPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total:f2}");

        }
    }
}
