using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidade sistema = new();

        public AlunoAdapter()
        {
            
        }

        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            int id = 0;
            string nome = string.Empty;
            string curso = string.Empty;
            string mensalidade = string.Empty;

            List<Aluno> alunos = new();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        id = Convert.ToInt32(alunosArray[i, j]);
                    }
                    else if(j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else if(j == 2)
                    {
                        curso = alunosArray[i, j];
                    }
                    else
                    {
                        mensalidade = alunosArray[i, j];
                    }

                }
                alunos.Add(new Aluno(id, nome, curso, mensalidade));
            }

            sistema.CalcularMensalidade(alunos);
        }
    }
}