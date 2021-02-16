using System;
using System.Globalization;

namespace _29_Exercicio_05 {
    class Program {
        static void Main(string[] args) {
            int qtd, cod;
            double preco, total = 0.0;

            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            switch (cod){
                case 1:
                    preco = 4.00;
                    total = qtd * preco;
                    break;
                case 2:
                    preco = 4.50;
                    total = qtd * preco;
                    break;
                case 3:
                    preco = 5.00;
                    total = qtd * preco;
                    break;
                case 4:
                    preco = 2.00;
                    total = qtd * preco;
                    break;
                case 5:
                    preco = 1.50;
                    total = qtd * preco;
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
