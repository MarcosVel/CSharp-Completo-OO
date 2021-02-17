using System;

namespace _33_Exercicio_02 {
    class Program {
        static void Main(string[] args) {
            int X, Y;

            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != 0 || Y != 0) {
                if (X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                }
                else if (X > 0 && Y < 0) {
                    Console.WriteLine("quarto");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }            
        }
    }
}
