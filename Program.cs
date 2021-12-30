using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //tendo executar
            try 
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                //enquanto a partida não estiver terminada
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executeMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            //se der algum erro, informo por mensagem
            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
