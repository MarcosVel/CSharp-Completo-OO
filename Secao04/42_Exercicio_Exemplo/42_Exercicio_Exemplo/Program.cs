using System;

namespace _42_Exercicio_Exemplo {
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
            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco:F2}, {produto.Quantidade} unidades, Total: {total:F2}");

            Console.WriteLine();

            // leitura da Quantidade a adicionar
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AttQtd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Quantidade atualizada
            double qtdAtualizada = produto.AdicionarProdutos();
            total = produto.Total();
            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco:F2}, {qtdAtualizada} unidades, Total: {total:F2}");

            Console.WriteLine();

            // leitura da Quantidade a retirar
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.AttQtd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Quantidade atualizada
            qtdAtualizada = produto.RemoverProdutos();
            total = produto.Total();
            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco:F2}, {qtdAtualizada} unidades, Total: {total:F2}");

        }
    }
}
