using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
    public class BoloFactory : MassaAbstractFactory
    {
        public BoloFactory()
        {
            
        }
        
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.LARANJA: return new BoloLaranja();
                case TipoBolo.CHOCOLATE: return new BoloChocolate();
                default: throw new ArgumentOutOfRangeException(nameof(tipoBolo));
            }       
        }
    }
}