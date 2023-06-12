using Composite.Component;

namespace Composite.Composite
{
    public class Organizacao : HoraTrabalhada
    {
        private List<HoraTrabalhada> _horaTrabalhada = new();

        public override int GetHoraTrabalhada()
        {
            var horasDepartamento = 0;
            foreach (var horaTrabalhada in _horaTrabalhada)
            {
                horasDepartamento += horaTrabalhada.GetHoraTrabalhada();
            }
            
            Console.WriteLine($"Total de horas do departamento {Nome}: {horasDepartamento}");
            return horasDepartamento;
        }

        override public void Add(HoraTrabalhada component) =>_horaTrabalhada.Add(component);
        override public void Remove(HoraTrabalhada component) => _horaTrabalhada.Remove(component);
    }
}