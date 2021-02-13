using System;

namespace Prova3._1 {
    class Program {
        static void Main(string[] args) {
            int digitos, senha = 2002;

            digitos = int.Parse(Console.ReadLine());

            while (digitos != senha) {
                Console.WriteLine("Senha Invalida");
                digitos = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
