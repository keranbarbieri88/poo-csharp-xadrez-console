using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        //variáveis encapsuladas.
        public int linha { get; set; }
        public int coluna { get; set; }

        //construtor que recebe por parâmentro linha e coluna e autorreferência (palavra this é uma referência
        //para o próprio objeto) que armazena nas variáveis o valor informado como argumento.
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //método que define valores da posição
        public void definirValores(int linha, int coluna)
        {

        }

        //método ToString converte um objeto em sua representação de cadeia de caracteres
        //para que ele seja adequado para exibição (sobreposição).
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
