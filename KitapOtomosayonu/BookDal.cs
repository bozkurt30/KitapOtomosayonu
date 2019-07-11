using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapOtomosayonu
{
   public class BookDal
    {
          public List<Books> GetAll()
        {
          using(BookContext context = new BookContext())
            {
                return context.Books.ToList();
          
            }
        }
        
        //Kitap Ekle için
        public List<Books> GetByName(string key)
        {
            using (BookContext context = new BookContext())
            {
                //contains =içeren, anahtar kelimeyi içern veriyi getir
                return context.Books.Where(p=>p.BookName.Contains(key)).ToList();
            }
        }

        //liste için arama
        public List<BookInfo> GetByName2(string key)
        {
            using (BookContext context = new BookContext())
            {
                //contains =içeren, anahtar kelimeyi içern veriyi getir
                return context.BookSend.Where(p => p.BookName.Contains(key)).ToList();
            }
        }
        //liste
        public List<BookInfo> GetAll2()
        {
            using (BookContext context = new BookContext())
            {
                //hata burada bak sonra
                return context.BookSend.ToList();
            }
        }

        public List<LoginUser> GetAll3()
        {
            using (BookContext context = new BookContext())
            {
                return context.loginUsers.ToList();

            }
        }

        //üyelik
        public void Add(LoginUser loginUser)
        {
            using(BookContext context = new BookContext())
            {
                var entity = context.Entry(loginUser);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Add(Books books)
        {
           using(BookContext context = new BookContext())
            {
                
                var entity = context.Entry(books);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Added;
                context.SaveChanges();

            }
        }
        //kitap listesi için
        public void Add(BookInfo bookInfo)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(bookInfo);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Added;
                context.SaveChanges();

            }
        }
        public void Update(Books books)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(books);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        //kitap listesi için
        public void Update(BookInfo bookInfo)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(bookInfo);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Books book)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(book);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        //kitap listesi için
        public void Delete(BookInfo bookInfo)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(bookInfo);//context üzerine abone ol, gönderdiğimiz kitap bilgilerini veri tabanı iile eşitliyor
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
