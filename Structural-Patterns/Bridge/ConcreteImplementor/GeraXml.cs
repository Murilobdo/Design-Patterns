using System.Xml.Serialization;
using System.Text.Json;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GeraXml : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionario));
        private FileStream fileStream;

        public void GravarArquivo(Funcionario funcionario)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, funcionario);

            Console.WriteLine($"Salario do funcionario {funcionario.Nome} gravado com sucesso no arquivo {nomeArquivo}");
        }
    }
}