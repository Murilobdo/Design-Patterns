namespace AbstractFactory.Models
{
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base(TipoMassa.BOLO, "Bolo de Chocolate")
        {
            Ingredientes.Add("Com cobertura de calda de chocolate");
        }
    }
}