namespace Builder.Models
{
    public class Pizza
    {
        public Pizza()
        {
            
        }

        public TipoMassa TipoMassa { get; set; }
        public TipoBorda TipoBoarda { get; set; }
        public Tamanho Tamanho { get; set; }
        public List<string> Ingredientes { get; set; } = new();

        public void ExibirConteudo()
        {
            Console.WriteLine($"Pizza com massa: {TipoMassa}");
            Console.WriteLine($"Pizza com borda: {TipoBoarda}");
            Console.WriteLine($"Tamanho: {Tamanho}");

            Ingredientes.ForEach(ingrediente => Console.WriteLine($" {ingrediente}"));
        }
    }
}