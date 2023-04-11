using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.RefinedAbstraction
{
    public class CalculaSalario : AbstractionGeraArquivo
    {
        public CalculaSalario(IGeraArquivo implementor) : base(implementor)
        {

        }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = (funcionario.SalarioBase + funcionario.Incentivo) * (decimal)0.8;

            Console.WriteLine($"Salario do funcionario {funcionario.Nome} -> {funcionario.SalarioTotal}");

            _implementor.GravarArquivo(funcionario);
        }
    }
}