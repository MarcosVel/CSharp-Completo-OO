using System;

namespace _48_Exercicio_Proposto {
    class Program {
        static void Main(string[] args) {
            double cotacao, valor, resultado;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares vc vai comprar? ");
            valor = double.Parse(Console.ReadLine());

            resultado = ConversorDeMoeda.ValorSerPago(cotacao, valor);

            Console.WriteLine($"Valor a ser pago em reais = {resultado:F2}");
        }
    }
}
