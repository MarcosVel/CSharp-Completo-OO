using System;
using System.Collections.Generic;
using System.Text;

namespace _45_Exercicio_03 {
    class NotasAluno {
        public string NomeAluno;
        public double TotalNotas;
        double media = 60.0;

        public void NotaFinal(double nota) {
            TotalNotas += nota;
        }

        public bool Aprovado() {
            if (TotalNotas >= media) {
                return true;
            }
            return false;
        }
        
        public double PontosRestantes() {
            if (TotalNotas < media) {
                media -= TotalNotas;
            }
            return media;
        }
    }
}
