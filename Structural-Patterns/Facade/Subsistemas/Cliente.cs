using System.ComponentModel.DataAnnotations;
namespace Facade.Subsistemas
{
    public class Cliente
    {
        public Cliente(string nome) 
        {
            Nome = nome;
        }

        public string Nome { get; set; } = string.Empty;
    }
}