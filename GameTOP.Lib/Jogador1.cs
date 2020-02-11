using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;


        public Jogador1(string nome = "Lucas")
        {
            _Nome = nome;
        }
        public string chutar()
        {
            return $"{_Nome} esta chutando";
        }

        public string correr()
        {
            return $"{_Nome} esta correndo";
        }

        public string passar()
        {
            return $"{_Nome} esta passando";
        }
    }
}