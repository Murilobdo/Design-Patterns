using System.Text.Json;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravarArquivo(Funcionario funcionario)
        {
            var serializacao = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, serializacao);

            Console.WriteLine($"Salario do funcionario {funcionario.Nome} gravado com sucesso no arquivo {nomeArquivo}");
        }
    }
}