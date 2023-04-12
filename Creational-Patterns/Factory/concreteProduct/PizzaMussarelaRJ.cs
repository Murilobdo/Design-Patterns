using Factory.product;

namespace Factory.concreteProduct
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Name = "Pizza de Mussarela do RJ";
            massa = "Massa grossa";
            molho = "Molho de tomate";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Orégano");
        }
    }
}