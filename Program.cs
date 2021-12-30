﻿using System;
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

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));


                Tela.imprimirTabuleiro(tab);
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
