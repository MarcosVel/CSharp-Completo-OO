using System;

namespace _42_Exercicio_Exemplo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");

            Produto produto = new Produto();

            Console.Write("Nome: ");
            produto.nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // total
            double total = produto.Total();
            Console.WriteLine($"Dados do produto: {produto.nome}, $ {produto.preco:F2}, {produto.quantidade} unidades, Total: {total:F2}");

            Console.WriteLine();

            // leitura da quantidade a adicionar
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.attQtd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // quantidade atualizada
            double qtdAtualizada = produto.AddEstoque();
            total = produto.Total();
            Console.WriteLine($"Dados atualizados: {produto.nome}, $ {produto.preco:F2}, {qtdAtualizada} unidades, Total: {total:F2}");

        }
    }
}
