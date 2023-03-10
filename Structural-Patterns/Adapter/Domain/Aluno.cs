namespace Adapter.Domain
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Curso { get; set; } = string.Empty;
        public string Mensalidade { get; set; } = string.Empty;

        public Aluno(int id, string nome, string curso, string mensalidade)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            Mensalidade = mensalidade;
        }

        public Aluno()
        {
            
        }
    }
}