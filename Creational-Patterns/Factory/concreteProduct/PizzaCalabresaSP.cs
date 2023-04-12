using Factory.product;

namespace Factory.concreteProduct
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Name = "Pizza de Calabresa de SP";
            massa = "Massa fina";
            molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");
            ingredientes.Add("Calabresa");
            ingredientes.Add("Orégano");
        }
    }
}