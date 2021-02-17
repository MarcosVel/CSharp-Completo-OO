using System;

namespace _29_Exercicio_08 {
    class Program {
        static void Main(string[] args) {
            double salario, imposto = 0.0;

            salario = double.Parse(Console.ReadLine());

            if (salario <= 2000.0) {
                Console.WriteLine("Isento");
            } else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;                
            } else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            } else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            
            if (salario > 2000.0) {
                Console.WriteLine($"R$ {imposto:F2}");
            }
        }
    }
}
