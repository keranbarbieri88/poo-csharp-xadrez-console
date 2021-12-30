using tabuleiro;

namespace xadrez
{
    //Subclasse de Peça (herança)
    class Torre : Peca
    {
        //construtor da peça Torre (objeto) que repassa as instruções, para a classe Peça
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }

    }
}
