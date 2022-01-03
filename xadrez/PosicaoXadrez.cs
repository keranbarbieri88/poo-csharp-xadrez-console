using System;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        //variáveis
        public char coluna { get; set; }
        public int linha { get; set; }


        //construtor
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        
        //método que converte a posição do xadrez para uma posição interna da matriz
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
