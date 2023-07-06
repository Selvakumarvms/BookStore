using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Model
{
    public class Books
    {
        public Guid Id { get; set; }
        public String Publisher { get; set; }
        public String Title { get; set; }
        public String AuthorFirstName { get; set; }
        public String AuthorLastName { get; set; }
    }
}
