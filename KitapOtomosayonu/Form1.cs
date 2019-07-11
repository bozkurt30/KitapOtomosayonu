using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using Application = System.Windows.Forms.Application;

namespace KitapOtomosayonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        BookDal _bookDal = new BookDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
           
        }

        private void LoadBooks()
        {
            dgwKitaplar.DataSource = _bookDal.GetAll();
            dgw.DataSource = _bookDal.GetAll2();
        }
        public void SearchBooks(string key)
        {
            var result = _bookDal.GetByName(key);
            dgwKitaplar.DataSource = result;
        }
        public void SearchBookInfo(string key)
        {
            //kitap listesi için
            var result2 = _bookDal.GetByName2(key);
            dgw.DataSource=result2;
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbxKitapEkleAdi.Text == "" || tbxEkleRafNo.Text == "" || tbxYazar.Text == "" || texResimEkle.Text =="")
            {
                MessageBox.Show("Alanları Doldurun");
            }else
            {
                if (tbxEkleRafNo.TextLength<10)
                {
                    _bookDal.Add(new Books
                    {

                        BookName = tbxKitapEkleAdi.Text,
                        RafNo = tbxEkleRafNo.Text,
                        Yazar = tbxYazar.Text,
                        ResimEkle = texResimEkle.Text

                    });

                    tbxEkleRafNo.ForeColor = Color.Black;
                    LoadBooks();
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    if (tbxEkleRafNo.Text!=null)
                    {
                        tbxEkleRafNo.ForeColor = Color.Red;
                    }

                    //MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                    MessageBox.Show("Hatalı giriş Raf bilgilerini düzgün girin", "Uyarı", MessageBoxButtons.OK);
                }
               
              
            }
           
        }
        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                tbxUpdateBookName.Text = dgwKitaplar.CurrentRow.Cells[1].Value.ToString();
                tbxUpdateRaf.Text = dgwKitaplar.CurrentRow.Cells[2].Value.ToString();
                tbxUpdateYazar.Text = dgwKitaplar.CurrentRow.Cells[3].Value.ToString();
                tbxBookName.Text = dgwKitaplar.CurrentRow.Cells[1].Value.ToString();
                tbxRafNo.Text = dgwKitaplar.CurrentRow.Cells[2].Value.ToString();
                tbxYazarKitapBilgi.Text = dgwKitaplar.CurrentRow.Cells[3].Value.ToString();
                texResimUpdate.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                picBox.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                tbxResimYoluGoruntule.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                picBoxUpdate.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();




        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Books books = new Books
            {
                Id = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[0].Value),
                BookName = tbxUpdateBookName.Text,
                RafNo = tbxUpdateRaf.Text,
                Yazar=tbxUpdateYazar.Text,
                ResimEkle = texResimUpdate.Text
            };
            _bookDal.Update(books);
            LoadBooks();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bookDal.Delete(new Books
            {
                Id = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[0].Value),
            });
            LoadBooks();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void tbxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            SearchBooks(tbxSearchBooks.Text);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            

            if (tbxUserName.Text == "" || tbxTel.Text == "" || cbState.Text=="")
            {
                MessageBox.Show("Alanları Dolduurun");
            }
            else
            {   _bookDal.Add(new BookInfo
                    {
                        UserName = tbxUserName.Text,
                        TelNo = tbxTel.Text,
                        BookName = tbxBookName.Text,
                        RafNumber = Convert.ToInt32(tbxRafNo.Text),
                        DateOfIssue = Convert.ToDateTime(dtVerilisTarihi.Text),
                        ReturnDate = Convert.ToDateTime(dtIadeTarihi.Text),
                        State = cbState.Text,
                        Yazar = tbxYazarKitapBilgi.Text,
                        ResimEkle = tbxResimYoluGoruntule.Text
                    });
                    LoadBooks();
                    MessageBox.Show("Bilgiler Eklendi");
                }
             
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            tbxUserName.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            tbxRafNo.Text = dgw.CurrentRow.Cells[4].Value.ToString();
            dtVerilisTarihi.Text = dgw.CurrentRow.Cells[5].Value.ToString();
            dtIadeTarihi.Text = dgw.CurrentRow.Cells[6].Value.ToString();
            cbState.Text = dgw.CurrentRow.Cells[7].Value.ToString();
            tbxYazarKitapBilgi.Text = dgw.CurrentRow.Cells[8].Value.ToString();
            tbxTel.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            
           
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBookInfo(tbxSearch.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (tbxUserName.Text == "" && tbxTel.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else
            {
                BookInfo bookInfo = new BookInfo
                {
                
                Id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value),
                UserName = tbxUserName.Text,
                TelNo = tbxTel.Text,
                BookName = tbxBookName.Text,
                RafNumber = Convert.ToInt32(tbxRafNo.Text),
                DateOfIssue = Convert.ToDateTime(dtVerilisTarihi.Text),
                ReturnDate = Convert.ToDateTime(dtIadeTarihi.Text),
                State = Convert.ToString(cbState.Text),
                Yazar = tbxYazarKitapBilgi.Text,
                ResimEkle = tbxResimYoluGoruntule.Text

        };
                _bookDal.Update(bookInfo);
                LoadBooks();
                MessageBox.Show("Güncelleme Başarılı");
                
            }
          
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _bookDal.Delete(new BookInfo
            {
                Id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value),
            });
            LoadBooks();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TumListe tumListe = new TumListe();
            tumListe.Show();
            this.Hide();
        }

     
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgwKitaplar.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgwKitaplar.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgwKitaplar.Rows.Count; i++)
            {
                for (int j = 0; j < dgwKitaplar.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgwKitaplar[j, i].Value == null ? "" : dgwKitaplar[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void lblExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgw.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgw.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                for (int j = 0; j < dgw.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgw[j, i].Value == null ? "" : dgw[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Hide();
        }
        

        private void linkDosyaYoluEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image |*.png;*.nef;*.jpg;| Tüm Dosyalar|*.*";
            openFileDialog.ShowDialog();
            string dosyayolu = openFileDialog.FileName;
            texResimEkle.Text = dosyayolu;
            picBoxAdd.ImageLocation = dosyayolu;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image |*.jpg;*.nef;*.png | Tüm Dosyalar|*.*";
            openFileDialog.ShowDialog();
            string dosyayolu = openFileDialog.FileName;
            texResimUpdate.Text = dosyayolu;
            picBoxUpdate.ImageLocation = dosyayolu;
        }

        private void kitapDurumunuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumListe tumListe = new TumListe();
            tumListe.Show();
            this.Hide();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();
        }

        private void dgwKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış Yapılsın mı ? Sizi Giriş Sayfasına Yönlendirecektir.", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            

            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatılmadı.");
            }
           
        }

       
    }
 }
