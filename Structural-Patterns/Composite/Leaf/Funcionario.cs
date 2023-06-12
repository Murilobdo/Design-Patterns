using Composite.Component;

namespace Composite.Leaf
{
    public class Funcionario : HoraTrabalhada
    {
        public int Id { get; set; }
        public int Horas { get; set; }

        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"Funcionário: {Nome} - Horas: {Horas}");
            return Horas;
        }
    }
}