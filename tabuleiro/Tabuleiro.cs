using System;

namespace tabuleiro
{
    class Tabuleiro
    {   
        //variáveis.
        public int linhas { get; set; }
        public int colunas { get; set; }

        //matriz - arranjos bidimensionais, estrutura de dados.
        private Peca[,] pecas;

        //construtor que recebe por parâmentro linhas, colunas e autorreferência (palavra this é uma referência
        //para o próprio objeto) que armazena nas variáveis o valor informado como argumento.
        //pecas instancia uma nova matriz com a quatidade de linhas e colunas que foi passada como parâmentro.
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //método que permite acesso a uma peça indivídual, recebe como parâmentro/argumento linha e coluna.
        //associação - o tabuleiro tem várias peças.
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
         
        //método de sobrecarga
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        // método que verifica se há peça na posição, caso não, coloca uma peça no tabuleiro,
        // acesso a matriz peças passando a linha e a coluna que recebe a peça p e peça p recebe a posição pos.
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //método que retira peça de uma dada posição
        public Peca retirarPeca(Posicao pos)
        {
            //se não houver peça, não retira nada e retornará nulo
            if (peca(pos) == null)
            {
                return null;
            }
            //variável auxiliar que recebe a peça que está na posição informada, e retira a peça, retornando nulo
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;

        }
               
        //método que testa se a posição é válida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        //método que verifica se há peça na posição escolhida e antes passa pelo método que testa se a poisção é válida.
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //método de tratamento de exceção
        public void validarPosicao(Posicao pos)
        { 
            //se a posição não for válida é lançada a exceção
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }

        }
    }
}
