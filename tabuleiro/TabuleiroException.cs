using System;


namespace tabuleiro
{
    //classe herda da classe Exception do C#
    class TabuleiroException : Exception
    {
        //construtor que recebe a mensagem e repassa para a classe Exception do C#
        public TabuleiroException(string msg): base(msg)
        {

        }
    }
}
