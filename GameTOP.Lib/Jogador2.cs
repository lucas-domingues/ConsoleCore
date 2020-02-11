using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string chutar()
        {
            return "Maradona estas pateando ";
        }

        public string correr()
        {
            return "Maradona estas corriendo";
        }

        public string passar()
        {
            return "Maradona estas pasando";
        }
    }
}