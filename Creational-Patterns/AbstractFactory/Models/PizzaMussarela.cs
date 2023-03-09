namespace AbstractFactory.Models
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base(TipoMassa.PIZZA, "Pizza de Mussarela")
        {
            Ingredientes.Add("Pizza de mussarela com cubos de tomate.");
        }
    }
}