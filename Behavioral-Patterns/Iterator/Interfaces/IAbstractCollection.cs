using Iterator.Models;

namespace Iterator.Interfaces
{
    public interface IAbstractCollection
    {
        IteratorCollection CreateIterator();
    }
}