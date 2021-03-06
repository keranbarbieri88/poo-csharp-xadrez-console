using System;
using xadrez;


namespace tabuleiro
{
    abstract class Peca
    {
        //uma peça possui uma posição que pode ser acessada e alterada por outras classes,
        //uma cor, quantidade de movimentos e Tabuleiro que podem ser acessados por outras classes, mas
        //só podem ser alterados pela classe Peca ou suas subclasses.
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //construtor que recebe por parâmentro Posicao, Tabuleiro, Cor e autorreferência (palavra this é uma referência
        //para o próprio objeto) que armazena nas variáveis o valor informado como argumento.
        //posição inicia-se nula e qteMovimentos inicia-se em 0 por isso não foram passadas como parâmentro.
        //associação - a peça tem um tabuleiro.
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        //método que incrementa a quantidade de movimentos executados por uma peça
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        //método que não tem implementação nesta classe, e sim em cada classe de peça, pois representará os movimentos que
        //cada peça pode fazer.
        public abstract bool[,] movimentosPossiveis();
    }
}
