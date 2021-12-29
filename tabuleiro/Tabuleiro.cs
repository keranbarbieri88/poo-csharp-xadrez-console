using System;
using System.Collections.Generic;
using System.Text;

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
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
