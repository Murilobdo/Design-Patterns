namespace AbstractFactory.Models
{
    public class Pizza : MassaBase
    {
        public Pizza(TipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
        {
        }
    }
}