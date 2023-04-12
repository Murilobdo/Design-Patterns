using Factory.product;

namespace Factory.concreteProduct
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Name = "Pizza de Calabresa do RJ";
            massa = "Massa grossa";
            molho = "Molho de tomate";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Calabresa");
            ingredientes.Add("Orégano");
        }
    }
}