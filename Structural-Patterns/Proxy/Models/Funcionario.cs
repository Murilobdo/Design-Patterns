namespace Proxy.Models
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;

        public Funcionario(string nome, string senha, string perfil)
        {
            Nome = nome;
            Senha = senha;
            Perfil = perfil;
        }
    }
}