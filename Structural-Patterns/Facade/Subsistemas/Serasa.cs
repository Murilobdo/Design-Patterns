namespace Facade.Subsistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine($"Verificando o SERASA para o cliente {cliente.Nome}...");
            Thread.Sleep(1300);
            return false;
        }
    }
}