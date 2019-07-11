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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
           
        }
        BookDal _bookDal = new BookDal();

        private void btnKitapAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbxEkleRafNo.TextLength < 10)
            {
                _bookDal.Add(new Books
                {
                    BookName = tbxKitapEkleAdi.Text,
                    RafNo = tbxEkleRafNo.Text,
                    Yazar = tbxYazar.Text,
                    ResimEkle = picImage.Text


                });
                tbxEkleRafNo.ForeColor = Color.Black;
                LoadBooks();
                MessageBox.Show("Kitap Eklendi");
            }
            else
            {
                if (tbxEkleRafNo.Text != null)
                {
                    tbxEkleRafNo.ForeColor = Color.Red;
                }

                MessageBox.Show("Hatalı giriş Raf bilgilerini düzgün girin");
            }
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            LoadBooks();
           // picImage.SizeMode = PictureBoxSizeMode.CenterImage;
            picImage.BorderStyle = BorderStyle.FixedSingle;

        }

        private void LoadBooks()
        {
            dgwKitaplar.DataSource = _bookDal.GetAll();
        }

        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateBookName.Text = dgwKitaplar.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateRaf.Text = dgwKitaplar.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateYazar.Text = dgwKitaplar.CurrentRow.Cells[3].Value.ToString();
            pbImage.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
            picImageUpdate.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
            picBoxUpdate.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Books books = new Books
            {
                Id=Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[0].Value),
                BookName=tbxUpdateBookName.Text,
                RafNo=tbxUpdateRaf.Text,
                Yazar=tbxUpdateYazar.Text,
                ResimEkle = picImageUpdate.Text

            };
            _bookDal.Update(books);
            LoadBooks();
            MessageBox.Show("Güncelleme başarılı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image |*.jpg;*.nef;*.png | Tüm Dosyalar|*.*";
            openFileDialog.ShowDialog();
            string dosyayolu = openFileDialog.FileName;
            picImage.Text = dosyayolu;
            picBox.ImageLocation = dosyayolu;
            
        }

        private void linkAddUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image |*.jpg;*.nef;*.png | Tüm Dosyalar|*.*";
            openFileDialog.ShowDialog();
            string dosyayolu = openFileDialog.FileName;
            picImageUpdate.Text = dosyayolu;
            picBoxUpdate.ImageLocation = dosyayolu;
        }

    
    }
}
