using System;
using System.Globalization;

namespace Exerc_Proposto_24 {
    class Program {
        static void Main(string[] args) {
            int codFunc, horas;
            double valor, salario;

            codFunc = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine());

            salario = horas * valor;

            Console.WriteLine($"NUMBER  = {codFunc}");
            Console.WriteLine("SALARY = U$" + salario.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
