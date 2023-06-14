using Facade.Subsistemas;

namespace Facade.Facade
{

    public class CreditoFacade
    {
        private LimiteCredito limiteCredito;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public CreditoFacade()
        {
            limiteCredito = new();
            serasa = new();
            cadin = new();
            cadastro = new();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"Iniciando análise de crédito para o cliente {cliente.Nome} no valor de {valor}...");
            cadastro.CadastrarCliente(cliente);

            bool concederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA.");
                concederEmprestimo = false;
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no CADIN.");
                concederEmprestimo = false;
            }
            else if (!limiteCredito.PossuiLimiteCredito(cliente, valor))
            {
                Console.WriteLine($"Validando empréstimo para o {cliente.Nome} no valor de R${valor}...");
                concederEmprestimo = false;
            }

            return concederEmprestimo;
        }
    }
}