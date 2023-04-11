

using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstraction;

Funcionario funcionario = new Funcionario
{
    Id = 1,
    Nome = "João",
    SalarioBase = 1000,
    Incentivo = 500
};

var salarioJson = new CalculaSalario(new GeraJson());
var salarioXml = new CalculaSalario(new GeraXml());

salarioJson.ProcessaSalarioFuncionario(funcionario);

funcionario.Incentivo = 750;
salarioXml.ProcessaSalarioFuncionario(funcionario);
