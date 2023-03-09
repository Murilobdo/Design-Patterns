namespace AbstractFactory.Models
{
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base(TipoMassa.BOLO, "Bolo de Laranja")
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}