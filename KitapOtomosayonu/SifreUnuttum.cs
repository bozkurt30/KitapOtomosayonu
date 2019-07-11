using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace KitapOtomosayonu
{
    public partial class SifreUnuttum : Form
    {
        public SifreUnuttum()
        {
            InitializeComponent();
        }

        //public bool Gonder(string konu, string icerik)
        //{
        //    MailMessage ePosta = new MailMessage();
        //    ePosta.From = new MailAddress("chnbzkrt30@gmail.com");
        //    ePosta.To.Add(texEpostaYolla.Text);
        //    ePosta.Subject = konu;
        //    ePosta.Body = icerik;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Credentials = new System.Net.NetworkCredential("chnbzkrt30@gmail.com","Birdendokuzakadar1-*");
        //    smtp.Port = 587;
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.EnableSsl = true;
        //    object userState = ePosta;
        //    bool kontrol = true;
        //    try
        //    {
        //        smtp.SendAsync(ePosta, (object)ePosta);
        //    }
        //    catch (SmtpException ex)
        //    {
        //        kontrol=false;
        //        System.Windows.Forms.MessageBox.Show(ex.Message,"Mail Gönderme Hatası");
        //    }
        //    return kontrol;
        //}
        //BookDal _bookDal = new BookDal();
        //private void btnGonder_Click(object sender, EventArgs e)
        //{
            
        //    BookContext db = new BookContext();
        //    LoginUser loginUser = db.loginUsers.Where(p => p.KulAdi == textKulAdi.Text && p.Email==texEpostaYolla.Text).SingleOrDefault();
            

        //}
    }
}
