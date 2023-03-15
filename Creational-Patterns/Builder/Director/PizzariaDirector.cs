using Builder.Builder;
using Builder.Models;

namespace Builder.Director
{
    public class PizzariaDirector
    {
        private readonly PizzaBuilder _builder;

        public PizzariaDirector(PizzaBuilder builder)
        {
            _builder = builder;
        }

        public void MontarPizza()
        {
            _builder.CriarPizza();
            _builder.PrepararMassa();
            _builder.IncluirIngredientes();
        }

        public Pizza GetPizza() => _builder.GetPizza();
    }
}