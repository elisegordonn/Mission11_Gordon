namespace Mission11_Gordon.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}