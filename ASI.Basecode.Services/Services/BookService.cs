using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ASI.Basecode.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        
        public BookService(IBookRepository bookRepository) 
        {
            _bookRepository = bookRepository;
        }

        public List<Book> ViewBooks()
        {
            return _bookRepository.ViewBooks();
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            var newBook = new Book
            {
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                CreatedBy = book.Author,
                CreatedTime = DateTime.Now,
                PublishedDate = book.PublishedDate
            };

            _bookRepository.AddBook(newBook);
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }

        public void UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }
}
