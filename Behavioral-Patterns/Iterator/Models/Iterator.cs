using Iterator.Interfaces;

namespace Iterator.Models
{
    public class IteratorCollection : IAbstractIterator
    {
        private ConcreteCollection _collection;
        private int _current = 0;
        private int _step = 1;

        public IteratorCollection(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public Cliente First()
        {
            _current = 0;
            return _collection.GetCliente(_current);
        }

        public Cliente Next()
        {
            _current += _step;
            if(!IsDone)
                return _collection.GetCliente(_current);

            return null;
        }

        public bool IsDone => _current >= _collection.Count;
    }
}