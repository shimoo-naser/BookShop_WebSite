using BookShop_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BookShop_Domain.Concrete
{
   public class EFDBContext
    {

        public DbSet<Book> Books { set; get; }

    }
}
