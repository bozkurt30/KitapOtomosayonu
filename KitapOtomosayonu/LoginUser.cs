using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapOtomosayonu
{
   public class LoginUser
    {
        public int Id { get; set; }
        public string KulAdi { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }
        public string Email { get; set; }
        public string AdiSoyadi { get; set; }
    }
}
