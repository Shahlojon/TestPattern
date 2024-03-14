using IteratorPattern.Model;

namespace IteratorPattern.Interfaces;

public interface IBookNumerable
{
    IBookIterator CreateNumerator();
    int Count { get; }
    Book this[int index] { get; }
}
