using Proxy.Interfaces;

namespace Proxy.Models
{
    //RealSubject
    //Objeto que queremos usar de forma mais eficiente usando a classe Proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            Console.WriteLine("Lendo e gravando dados na pasta compartilhada...");
        }
    }
}