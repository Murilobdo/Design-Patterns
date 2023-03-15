using Builder.Builder;
using Builder.Models;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public PizzaMussarela()
        {
            
        }

        public override void IncluirIngredientes()
        {
            _pizza.Ingredientes = new List<string>{"Mussarela", "Molho de Tomate", "Oregano"};
        }

        public override void PrepararMassa()
        {
            _pizza.TipoBoarda = TipoBorda.Normal;
            _pizza.TipoMassa = TipoMassa.Grossa;
            _pizza.Tamanho = Tamanho.Media;
        }
    }
}