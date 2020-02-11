using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogador1;

        private readonly IJogador _jogador2;
        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void iniciarJogo()
        {
            System.Console.WriteLine(_jogador1.correr());
            System.Console.WriteLine(_jogador1.chutar());
            System.Console.WriteLine(_jogador1.passar());
            System.Console.WriteLine();
            System.Console.WriteLine(_jogador2.correr());
            System.Console.WriteLine(_jogador2.chutar());
            System.Console.WriteLine(_jogador2.passar());
        }
    }
    
}