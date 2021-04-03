using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _43_Exercicio_Exemplo {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;        

        // Adicionar ao estoque
        public void AdicionarProdutos(int attQtd) {
            Quantidade += attQtd;
        }

        // Remover do estoque
        public void RemoverProdutos(int attQtd) {
            Quantidade -= attQtd;
        }

        // Total
        public double Total() {
            return Quantidade * Preco;
        }

        public override string ToString() {
            return Nome
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade
                + " unidades, Total: $ "
                + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
