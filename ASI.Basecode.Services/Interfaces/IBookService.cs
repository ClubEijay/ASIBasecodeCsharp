using ASI.Basecode.Data.Models;
using System.Collections.Generic;

namespace ASI.Basecode.Services.Interfaces
{
    public interface IBookService
    {
        List<Book> ViewBooks();
        void AddBook(Book book);
        Book GetBook(int id);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
