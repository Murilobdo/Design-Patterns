using Builder.Models;

namespace Builder.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public void CriarPizza() => _pizza = new();
        public Pizza GetPizza() => _pizza;

        public abstract void PrepararMassa();
        public abstract void IncluirIngredientes();
    }
}