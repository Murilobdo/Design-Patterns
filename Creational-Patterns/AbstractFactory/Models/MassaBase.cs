using System.Collections;

namespace AbstractFactory.Models
{
    public abstract class MassaBase
    {
        protected MassaBase(TipoMassa tipoMassa, string nome)
        {
            TipoMassa = tipoMassa;
            Nome = nome;
        }

        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ArrayList Ingredientes { get; set; } = new();
    }
}