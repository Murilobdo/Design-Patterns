using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
    public abstract class MassaAbstractFactory
    {
        public abstract MassaBase CriarMassa(TipoMassa tipoMassa);

        public static MassaAbstractFactory CriarFabricaMassa(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.PIZZA: return new PizzaFactory();
                case TipoMassa.BOLO: return new BoloFactory();
                default: throw new ArgumentOutOfRangeException(nameof(tipoMassa));
            }
        }
    }
}