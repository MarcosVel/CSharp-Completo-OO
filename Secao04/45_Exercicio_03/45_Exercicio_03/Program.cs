using System;
using System.Globalization;

namespace _45_Exercicio_03 {
    class Program {
        static void Main(string[] args) {
            NotasAluno a = new NotasAluno();           

            Console.Write("Nome do aluno: ");
            a.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            for (int i = 0; i < 3; i++) {
                double nota = double.Parse(Console.ReadLine());
                a.NotaFinal(nota);
            }

            Console.WriteLine("NOTA FINAL = " + a.TotalNotas.ToString("F2", CultureInfo.InvariantCulture));

            if(a.Aprovado() == true) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.PontosRestantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
