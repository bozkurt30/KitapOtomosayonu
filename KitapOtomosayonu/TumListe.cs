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

namespace KitapOtomosayonu
{
    public partial class TumListe : Form
    {
        public TumListe()
        {
            InitializeComponent();
        }
        BookDal _bookDal = new BookDal();
        private void TumListe_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgwBigList.DataSource = _bookDal.GetAll();
            dgwBigList.DataSource = _bookDal.GetAll2();
        }

        private void dgwBigList_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            tbxUserName.Text = dgwBigList.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwBigList.CurrentRow.Cells[3].Value.ToString();
            tbxRafNo.Text = dgwBigList.CurrentRow.Cells[4].Value.ToString();
            dtVerilisTarihi.Text = dgwBigList.CurrentRow.Cells[5].Value.ToString();
            dtIadeTarihi.Text = dgwBigList.CurrentRow.Cells[6].Value.ToString();
            cbState.Text = dgwBigList.CurrentRow.Cells[7].Value.ToString();
            tbxYazarKitapBilgi.Text = dgwBigList.CurrentRow.Cells[8].Value.ToString();
            tbxTel.Text = dgwBigList.CurrentRow.Cells[2].Value.ToString();
            picTumList.ImageLocation = dgwBigList.CurrentRow.Cells[9].Value.ToString();
            tbxPicUpdate.Text = dgwBigList.CurrentRow.Cells[9].Value.ToString();
            picBoxUpdate.ImageLocation = dgwBigList.CurrentRow.Cells[9].Value.ToString();
            /*
               texResimUpdate.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                picBox.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                tbxResimYoluGoruntule.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
                picBoxUpdate.ImageLocation = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
             */

        }


        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 tumListe = new Form1();
            tumListe.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookInfo bookInfo = new BookInfo
            {
                Id = Convert.ToInt32(dgwBigList.CurrentRow.Cells[0].Value),
                UserName = tbxUserName.Text,
                TelNo =tbxTel.Text,
                BookName = tbxBookName.Text,
                RafNumber = Convert.ToInt32(tbxRafNo.Text),
                DateOfIssue = Convert.ToDateTime(dtVerilisTarihi.Text),
                ReturnDate = Convert.ToDateTime(dtIadeTarihi.Text),
                State = Convert.ToString(cbState.Text),
                Yazar = tbxYazarKitapBilgi.Text,
                ResimEkle = tbxPicUpdate.Text
                

            };
            _bookDal.Update(bookInfo);
            LoadBooks();
            MessageBox.Show("Güncelleme Başarılı");
        }
        public void TumListeArama(string key)
        {
            var result = _bookDal.GetByName2(key);
            dgwBigList.DataSource = result;
        }

        private void tbxTumListeArama_TextChanged(object sender, EventArgs e)
        {
            TumListeArama(tbxTumListeArama.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bookDal.Delete(new BookInfo
            {
                Id = Convert.ToInt32(dgwBigList.CurrentRow.Cells[0].Value),
            });
            LoadBooks();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgwBigList.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgwBigList.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgwBigList.Rows.Count; i++)
            {
                for (int j = 0; j < dgwBigList.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgwBigList[j, i].Value == null ? "" : dgwBigList[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgwBigList.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgwBigList.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgwBigList.Rows.Count; i++)
            {
                for (int j = 0; j < dgwBigList.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgwBigList[j, i].Value == null ? "" : dgwBigList[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void picTumList_Click(object sender, EventArgs e)
        {

        }
    }
}
