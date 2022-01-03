using tabuleiro;

namespace xadrez
{
    //Subclasse de Peça (herança)
    class Torre : Peca
    {
        //construtor da peça Torre (objeto) que repassa as instruções, para a classe Peça
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }

        //método auxiliar, pego a peça que está em determinada posição, retornará nulo se não hover peça ou se tiver peça adversária.
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        //método subescrito que possuí a lógica de peça
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //verifica posição acima da Torre
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            //enquanto tiver casa livre ou peça adversária
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
                //se houver peça e essa peça for diferente da cor da Torre eu paro o while
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //verifica posição abaixo da Torre
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            //enquanto tiver casa livre ou peça adversária
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
                //se houver peça e essa peça for diferente da cor da Torre eu paro o while
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //verifica posição direita da Torre
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            //enquanto tiver casa livre ou peça adversária
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
                //se houver peça e essa peça for diferente da cor da Torre eu paro o while
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //verifica posição esquerda da Torre
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            //enquanto tiver casa livre ou peça adversária
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
                //se houver peça e essa peça for diferente da cor da Torre eu paro o while
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }
            return mat;
        }

    }
}
