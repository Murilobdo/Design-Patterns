using Adapter.Domain;

namespace Adapter.Adaptee
{
    public class SistemaMensalidade
    {
        public void CalcularMensalidade(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome} - Valor Mensalidade R$ {aluno.Mensalidade}");
                Console.WriteLine("");              
            }
        }
    }
}