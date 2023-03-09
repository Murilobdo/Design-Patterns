using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
    public class PizzaFactory : MassaAbstractFactory
    {
        public PizzaFactory()
        {
        }

        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.CALABRESA: return new PizzaCalabresa();
                case TipoPizza.MUSSARELA: return new PizzaMussarela();
                default: throw new ArgumentOutOfRangeException(nameof(tipoPizza));
            }
        }
    }
}