using Factory.product;

namespace Factory.concreteProduct
{
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Name = "Pizza de Mussarela de SP";
            massa = "Massa fina";
            molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");
            ingredientes.Add("Orégano");
        }   
    }
}