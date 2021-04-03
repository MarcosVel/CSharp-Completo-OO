namespace _48_Exercicio_Proposto {
    class ConversorDeMoeda {
        public static double Iof = 1.06; // 6%
        public static double ValorSerPago(double cotacao, double valor) {
            return (cotacao * valor) * Iof;
        }
    }
}
