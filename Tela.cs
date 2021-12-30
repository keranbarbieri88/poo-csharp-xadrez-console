using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        //método estático (não precisam de objetos para serem chamados, são chamados
        //a partir do próprio nome da classe) que imprime o tabuleiro na tela e não retorna nenhum valor (void).
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            //contador inicia em 0, enquanto contrato menor que linhas do tabuleiro, contrato incrementa.
            for (int i=0; i<tab.linhas; i++)
            {
                //contador inicia em 0, enquanto contrato menor que colunas do tabuleiro, contrato incrementa.
                for (int j=0; j<tab.colunas; j++)
                {
                    //se linha e coluna forem nulos, imprimirá um traço.
                    if (tab.peca(i,j)==null)
                    {
                        Console.Write("- ");
                    } // se não, acessará o método e imprimirá a peça.                   
                    else
                    {
                        //acesso a peça, chamando o método peça no objeto tab, linha i, coluna j.
                        Console.Write(tab.peca(i, j) + " ");
                    }                    
                }
                //pula uma linha
                Console.WriteLine();
            }
        }
    }
}
