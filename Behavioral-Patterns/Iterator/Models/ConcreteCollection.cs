using Iterator.Interfaces;

namespace Iterator.Models
{
    public class ConcreteCollection : IAbstractCollection
    {
        List<Cliente> listaClientes = new();

        public IteratorCollection CreateIterator()
        {
            return new IteratorCollection(this);
        }

        internal int Count => listaClientes.Count;

        public Cliente GetCliente(int current) => listaClientes[current];

        public void AddCliente(Cliente cliente) => listaClientes.Add(cliente);
    }
}