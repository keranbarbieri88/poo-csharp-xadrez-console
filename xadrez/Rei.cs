using tabuleiro;

namespace xadrez
{
    //Subclasse de Peça
    //
    class Rei : Peca
    {
        //construtor da peça Rei (objeto) que repassa as instruções, para a classe Peça
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }

        //método auxiliar, pego a peça que está em determinada posição, retornará nulo se não hover peça ou se tiver peça adversária.
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //verifica posição acima do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            //se a posição é válida e a peça pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição nordeste do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição direta do Rei
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição sudeste do Rei
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição abaixo do Rei
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição sudoeste do Rei
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição esquerda do Rei
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica posição noroeste do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            //se a posição está livre ou com a peça adversária pode se mover
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                //matriz na posição linha e coluna é verdadeira
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
