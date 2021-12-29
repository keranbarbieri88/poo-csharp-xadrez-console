using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {   
        //variáveis
        public int linhas { get; set; }
        public int colunas { get; set; }

        //matriz - arranjos bidimensionais
        private Peca[,] pecas;

        //construtor que recebe por parâmentro linhas, colunas e autorreferência (palavra this é uma referência
        //para o próprio objeto) que armazena nas variáveis o valor informado como argumento.
        //pecas instãncia uma nova matriz com a quatidade de linhas e colunas que foi passada como parâmentro.
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
