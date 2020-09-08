using System;
namespace oop
{
    class Geladeira : Eletrodomestico
    {
        public Geladeira(string nome, string cor) : base(nome, cor)
        {

        }

        public override void Testar()
        {
            Console.WriteLine("Geladeira");
        }
    }
}