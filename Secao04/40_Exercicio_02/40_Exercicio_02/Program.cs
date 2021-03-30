using System;
using System.Globalization;

namespace _40_Exercicio_02 {
    class Program {
        static void Main(string[] args) {

            Funcionario primFunc = new Funcionario();
            Funcionario secFunc = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            primFunc.nome = Console.ReadLine();
            Console.Write("Salário: ");
            primFunc.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            secFunc.nome = Console.ReadLine();
            Console.Write("Salário: ");
            secFunc.salario = double.Parse(Console.ReadLine());

            double mediaSalario = (double) (primFunc.salario + secFunc.salario) / 2;

            Console.WriteLine("Salário médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}