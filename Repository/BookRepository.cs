using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private BookContext _context;

        public BookRepository(BookContext bookContext)
        {
            this._context = bookContext;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }
        public Book GetBookByID(int id)
        {
            return _context.Books.Find(id);
        }
        public void InsertBook(Book book)
        {
            _context.Books.Add(book);
        }

        public void DeleteBook(int bookID)
        {
            Book book = _context.Books.Find(bookID);
            _context.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
