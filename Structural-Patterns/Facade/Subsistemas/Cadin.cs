namespace Facade.Subsistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine($"Verificando o CADIN para o cliente {cliente.Nome}...");
            Thread.Sleep(1300);
            return false;
        }
    }
}