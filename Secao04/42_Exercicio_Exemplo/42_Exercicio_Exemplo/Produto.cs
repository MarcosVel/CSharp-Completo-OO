using System;
using System.Collections.Generic;
using System.Text;

namespace _42_Exercicio_Exemplo {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public int AttQtd;

        // Adicionar ao estoque
        public double AdicionarProdutos() {
            return Quantidade += AttQtd;
        }

        // Remover do estoque
        public double RemoverProdutos() {
            return Quantidade -= AttQtd;
        }

        // Total
        public double Total() {
            return Quantidade * Preco;
        }
    }
}
