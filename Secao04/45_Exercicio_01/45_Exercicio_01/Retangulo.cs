using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _45_Exercicio_01 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
