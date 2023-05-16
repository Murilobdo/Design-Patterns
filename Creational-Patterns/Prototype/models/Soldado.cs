namespace Prototype.models
{
    public class Soldado : ICloneable
    {
        public Soldado()
        {
        }

        public Soldado(Soldado s)
        {
            Nome = s.Nome;
            Arma = s.Arma;
            Acessorio = s.Acessorio;
        }

        public string Nome { get; set; } = string.Empty;       
        public string Arma { get; set; } = string.Empty;
        public Acessorio Acessorio { get; set; } = new();

        public object Clone()
        {
            Soldado clone = (Soldado)this.MemberwiseClone();
            clone.Acessorio = (Acessorio)this.Acessorio.Clone();

            return clone;
        }

        public void Mostra()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Arma: {this.Arma}");
            Console.WriteLine($"Acessorio: {this.Acessorio.Nome}");
            Console.WriteLine("--------------------------------------");
        }
    }
}