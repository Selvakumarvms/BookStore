using BooksWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Contract
{
    public interface IBookRepo
    {
        Task<List<Books>> GetAllBooks();
        Task<Books> GetBookWithPublisherById(Guid Id);
    }
}
