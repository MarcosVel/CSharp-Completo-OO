using System;
using System.Collections.Generic;
using System.Text;

namespace _42_Exercicio_Exemplo {
    class Produto {
        public string nome;
        public double preco;
        public int quantidade;
        public int attQtd;

        // Adicionar ao estoque
        public double AddEstoque() {
            return quantidade += attQtd;
        }

        // Total
        public double Total() {
            return quantidade * preco;
        }
    }
}
