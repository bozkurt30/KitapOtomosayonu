using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapOtomosayonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BookDal _bookDal = new BookDal();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //login işlemleri
            BookContext db = new BookContext();
            LoginUser loginUser = db.loginUsers.Where(p=>p.KulAdi == tbxKullanici.Text && p.Sifre==tbxSifre.Text).SingleOrDefault();
            if (loginUser == null)
            {
                MessageBox.Show("Giriş hatalı....");
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
         
        }

        private void linkSifreUnut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttum sifreUnuttum = new SifreUnuttum();
            sifreUnuttum.Show();
            this.Hide();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatılmadı.");
            }
        }
    }
}
