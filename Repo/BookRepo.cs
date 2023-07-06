using BooksWebApp.Contract;
using BooksWebApp.Model;
using BooksWebApp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Repo
{
    public class BookRepo : IBookRepo
    {
        private readonly IDapper _dapper;
        public BookRepo(IDapper dapper)
        {
            _dapper = dapper;
        }
        public async Task<List<Books>> GetAllBooks()
        {
            List<Books> books = null;
            try
            {                
                books = await Task.FromResult(_dapper.GetAll<Books>($"Select Id,Publisher,Title,AuthorFirstName,AuthorLastName from [dbo].[Books]", null, commandType: CommandType.Text));
            }
            catch(Exception ex)
            {
                books = null;
                throw ex;
            }

            return books;
        }

        public async Task<Books> GetBookWithPublisherById(Guid Id)
        {
            Books books = new Books();
            try
            {
                books = await Task.FromResult(_dapper.Get<Books>($"Select * from [Books] where Id = '{Id}'", null, commandType: CommandType.Text));
            }
            catch (Exception ex)
            {
                books = null;
                throw ex;
            }

            return books;
        }
    }
}
