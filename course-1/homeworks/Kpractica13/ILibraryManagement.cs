using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpractica13
{
    public interface ILibraryManagement
    {
        void AddBook(Book book);
        bool RemoveBook(Book book);
        List<Book> SearchByAuthor(string author);
        void ListBooks();
    }
}
