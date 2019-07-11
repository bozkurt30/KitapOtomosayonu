using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapOtomosayonu
{
    public class BookInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TelNo { get; set; }
        public string BookName { get; set; }
        public int RafNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ReturnDate { get; set; }
        public string State { get; set; }
        public string Yazar { get; set; }
        public string ResimEkle { get; set; }
    }
}
