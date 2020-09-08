using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Eletrodomestico geladeira = new Geladeira("Brastemp", "Branca");
            geladeira.Testar();
            Console.WriteLine(geladeira.Nome +" "+ geladeira.Cor);
        }
    }
}
