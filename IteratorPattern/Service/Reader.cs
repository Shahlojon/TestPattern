using IteratorPattern.Interfaces;
using IteratorPattern.Model;

namespace IteratorPattern.Service;

public class Reader
{
    public void SeeBooks(Library library)
    {
        IBookIterator iterator = library.CreateNumerator();
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book.Name);
        }
    }
}
