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
                //imprime os números-guias do tabuleiro
                Console.Write(8 - i + " ");
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
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }                    
                }
                //pula uma linha
                Console.WriteLine();
            }
            //imprime as letras-guias do tabuleiro
            Console.WriteLine(" a b c d e f g h");
        }

        //método estático que vai trocar a cor Preta das peças por Amarelo, pois o fundo do console é preto
        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                //tipo do C# que pega a cor do sistema, salvo na variável aux
                ConsoleColor aux = Console.ForegroundColor;
                //converto em Amarelo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                //imprimo Amarelo
                Console.ForegroundColor = aux;
            }
        }

    }
}
