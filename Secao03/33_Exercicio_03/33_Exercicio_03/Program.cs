using System;

namespace _33_Exercicio_03 {
    class Program {
        static void Main(string[] args) {
            int cod, alcool = 0, gasolina = 0, diesel = 0;

            cod = int.Parse(Console.ReadLine());

            while (cod != 4) {
                switch (cod) {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        break;
                }
                cod = int.Parse(Console.ReadLine());
            }                

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
