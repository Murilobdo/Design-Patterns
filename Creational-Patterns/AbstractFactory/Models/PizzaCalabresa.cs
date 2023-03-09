namespace AbstractFactory.Models
{
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base(TipoMassa.PIZZA , "Pizza de Calabresa")
        {
            
            Ingredientes.Add("Pizza de calabresa com cubos de tomate");
        }
    }
}