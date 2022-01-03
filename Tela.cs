using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Tela
    {
        //método estático (não precisam de objetos para serem chamados, são chamados
        //a partir do próprio nome da classe) que imprime o tabuleiro na tela e não retorna nenhum valor (void).
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            //contador inicia em 0, enquanto contrato menor que linhas do tabuleiro, contrato incrementa.
            for (int i = 0; i < tab.linhas; i++)
            {
                //imprime os números-guias do tabuleiro
                Console.Write(8 - i + " ");
                //contador inicia em 0, enquanto contrato menor que colunas do tabuleiro, contrato incrementa.
                for (int j = 0; j < tab.colunas; j++)
                {
                    //acesso a peça, chamando o método peça no objeto tab, linha i, coluna j.
                    imprimirPeca(tab.peca(i, j));
                }
                //pula uma linha
                Console.WriteLine();
            }
            //imprime as letras-guias do tabuleiro
            Console.WriteLine(" a b c d e f g h");
        }



        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoePossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            //contador inicia em 0, enquanto contrato menor que linhas do tabuleiro, contrato incrementa.
            for (int i = 0; i < tab.linhas; i++)
            {
                //imprime os números-guias do tabuleiro
                Console.Write(8 - i + " ");
                //contador inicia em 0, enquanto contrato menor que colunas do tabuleiro, contrato incrementa.
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoePossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    //acesso a peça, chamando o método peça no objeto tab, linha i, coluna j.
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                //pula uma linha
                Console.WriteLine();
            }
            //imprime as letras-guias do tabuleiro
            Console.WriteLine(" a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;

        }

        //método que irá ler do teclado o que o usuário digitar
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        //método estático que vai trocar a cor Preta das peças por Amarelo, pois o fundo do console é preto
        public static void imprimirPeca(Peca peca)
        {
            //se peça for nula, imprimirá um traço.
            if (peca == null)
            {
                Console.Write("- ");
            }
            // se não, acessará o método e imprimirá a peça.   
            else
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
                Console.Write(" ");
            }
        }
    }
}
