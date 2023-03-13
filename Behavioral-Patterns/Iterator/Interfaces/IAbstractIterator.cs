using Iterator.Models;

namespace Iterator.Interfaces
{
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        public bool IsDone { get; }
    }
}