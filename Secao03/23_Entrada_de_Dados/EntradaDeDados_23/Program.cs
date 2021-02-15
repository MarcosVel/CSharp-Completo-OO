using System;
using System.Globalization;

namespace EntradaDeDados_23 {
    class Program {
        static void Main(string[] args) {
            string nomeCompleto, lastName;
            int qtdQuartos, idade;
            double preçoProd, altura;

            Console.WriteLine("Entre com seu nome completo:");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            preçoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            lastName = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preçoProd.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

        }
    }
}
