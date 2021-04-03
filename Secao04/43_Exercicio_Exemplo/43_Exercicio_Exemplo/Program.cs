using System;

namespace _43_Exercicio_Exemplo {
    class Program {
        static void Main(string[] args) {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // total
            double total = produto.Total();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            // Quantidade a adicionar
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            // Quantidade a retirar
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
