using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        //variáveis.
        public int linha { get; set; }
        public int coluna { get; set; }

        //construtor que recebe por parâmentro linha e coluna.
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //método ToString converte um objeto em sua representação de cadeia de caracteres
        //para que ele seja adequado para exibição.
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
