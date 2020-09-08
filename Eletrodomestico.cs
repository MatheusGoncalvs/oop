namespace oop
{
    abstract class Eletrodomestico
    {
        public string Nome { get; set; }
        public string Cor { get; set; }

        public Eletrodomestico(string nome, string cor)
        {
            this.Nome = nome;
            this.Cor = cor;
        }

        public void Ligar() {
            //Operação para ligar
        }
        public abstract void Testar(); 
    }
}