using BookShop_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Domain.Abstruct
{
  public  interface IBookRepository
    {

        IEnumerable<Book> Books { get; }

    }
}
