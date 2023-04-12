using System.Text;
using System.Collections;

namespace Factory.product
{
    public class Pizza
    {
        protected string Name { get; set; }
        protected string massa;
        protected string molho;
        protected IList ingredientes = new ArrayList(); 
        
        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Preparando {Name}");
            sb.AppendLine($"{massa}");
            sb.AppendLine($"{molho}");
            sb.AppendLine("Adicionando ingredientes: ");
            foreach (var ingrediente in ingredientes)
            {
                sb.AppendLine($"  {ingrediente}");
            }

            sb.AppendLine(Cozinhar());
            sb.AppendLine(Fatiar());
            sb.AppendLine(Embalar());

            return sb.ToString();
        }

        private string Embalar() => "Embalando a pizza";
        private string Fatiar() => "Fatiando a pizza";
        private string Cozinhar() => "Cozinhando a pizza";
    }
}