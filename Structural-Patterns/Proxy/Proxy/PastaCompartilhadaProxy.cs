using Proxy.Interfaces;
using Proxy.Models;

namespace Proxy.Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada _pasta;
        private Funcionario _funcionario;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public void OperacaoDeLeituraGravacao()
        {
            if (_funcionario.Perfil.ToUpper() == "CEO")
            {
                _pasta = new PastaCompartilhada();
                Console.WriteLine("CEO: Acesso liberado para leitura e gravação.");
            }
            else
            {
                Console.WriteLine("Acesso negado.");
            }
        }
    }
}