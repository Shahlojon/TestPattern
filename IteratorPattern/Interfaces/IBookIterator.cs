using IteratorPattern.Model;

namespace IteratorPattern.Interfaces;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}
