namespace Facade.Subsistemas
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            
            Console.WriteLine($"Verificando o limite de crédito para o cliente {cliente.Nome}...");
            Thread.Sleep(1300);
            return valor <= 200.00;
        }
    }
}