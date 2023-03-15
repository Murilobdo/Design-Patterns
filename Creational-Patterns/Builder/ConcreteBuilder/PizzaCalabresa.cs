using Builder.Builder;
using Builder.Models;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaCalabresa : PizzaBuilder
    {
        public PizzaCalabresa()
        {
        }

        public override void IncluirIngredientes()
        {
            _pizza.Ingredientes = new List<string>{"Calabresa em fatias", "Molho de Tomate"};
        }

        public override void PrepararMassa()
        {
            _pizza.TipoBoarda = TipoBorda.Normal;
            _pizza.TipoMassa = TipoMassa.Grossa;
            _pizza.Tamanho = Tamanho.Media;
        }
    }
}