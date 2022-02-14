using BookStore.Models;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(int id);
        void DeleteBook(int id);
        void UpdateBook(Book book);
        void InsertBook(Book book);
        void Save();
    }
}