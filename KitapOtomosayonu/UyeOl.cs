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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        BookDal _bookDal = new BookDal();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (texSifre.Text == texSifreTekrar.Text)
            {
                _bookDal.Add(new LoginUser
                {

                    KulAdi = textKulAdi.Text,
                    Sifre = texSifre.Text,
                    SifreTekrar = texSifreTekrar.Text,
                    Email = texEmail.Text,
                    AdiSoyadi = texAdiveSoyadi.Text
                });
                MessageBox.Show("Kayıt başarılı...");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor. Lütfen dikkat edin");
            }
           
        }

        private void anasayfayaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 kitaplar = new Form1();
            kitaplar.Show();
            this.Hide();
        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
