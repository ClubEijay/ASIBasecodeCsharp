using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AsiBasecodeDBContext _dbContext;

        public BookRepository(AsiBasecodeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Book> ViewBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public Book GetBook(int id)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _dbContext.Books.Find(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Description = book.Description;
                existingBook.Author = book.Author;
                existingBook.PublishedDate = book.PublishedDate;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.Find(id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }
    }
}
