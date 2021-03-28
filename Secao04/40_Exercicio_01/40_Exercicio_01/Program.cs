using System;

namespace _40_Exercicio_01 {
    class Program {
        static void Main(string[] args) {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade) {
                Console.WriteLine("Pessoa mais velha: {0}", a.nome);
            } else {
                Console.WriteLine("Pessoa mais velha: {0}", b.nome);
            }

        }
    }
}
