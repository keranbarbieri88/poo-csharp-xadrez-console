using tabuleiro;

namespace xadrez
{
    //Subclasse de Peça (herança)
    class Rei : Peca
    {
        //construtor da peça Rei (objeto) que repassa as instruções, para a classe Peça
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
