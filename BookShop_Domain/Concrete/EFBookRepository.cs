using BookShop_Domain.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Domain.Entities;

namespace BookShop_Domain.Concrete
{
public class EFBookRepository : IBookRepository

    {
       public EFDBContext Context = new EFDBContext();

        public IEnumerable<Book> Books
        {
            get
            {
                return Context.Books;
            }
        }
    }
}
