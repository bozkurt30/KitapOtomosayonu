using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapOtomosayonu
{
    public class BookContext : DbContext
    {

        public DbSet<Books> Books { get; set; }
        public DbSet<BookInfo> BookSend{ get; set; }
        public DbSet<LoginUser> loginUsers { get; set; }
    }
}
