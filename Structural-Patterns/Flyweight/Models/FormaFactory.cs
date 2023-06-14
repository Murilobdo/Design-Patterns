using Flyweight.Interfaces;

namespace Flyweight.Models
{
    public class FormaFactory
    {
        private static Dictionary<string, IForma> _formas = new Dictionary<string, IForma>();

        public static IForma GetForma(string chave)
        {
            IForma forma;

            if (_formas.ContainsKey(chave))
            {
                Console.WriteLine("Retornou da Cache...");
                return _formas[chave];
            }
            else
            {
                if (chave.Equals("Circulo"))
                {
                    forma = new Circulo();
                    _formas.Add(chave, forma);
                } else {
                    throw new Exception("Forma não encontrada.");
                }
            }

            Console.WriteLine("Criando uma instancia de Circulo...");
            return forma;
        }
    }
}