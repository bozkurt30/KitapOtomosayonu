namespace KitapOtomosayonu
{
    partial class TumListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxTumListeArama = new System.Windows.Forms.TextBox();
            this.dgwBigList = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxYazarKitapBilgi = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRafNo = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picTumList = new System.Windows.Forms.PictureBox();
            this.tbxPicUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkResimYolu = new System.Windows.Forms.LinkLabel();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBigList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTumList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnasayfa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbxTumListeArama);
            this.groupBox1.Controls.Add(this.dgwBigList);
            this.groupBox1.Location = new System.Drawing.Point(283, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Durumu";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Navy;
            this.btnAnasayfa.Location = new System.Drawing.Point(444, 22);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(276, 23);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "Anasayfa\'ya Dön...";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(726, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxTumListeArama
            // 
            this.tbxTumListeArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxTumListeArama.Location = new System.Drawing.Point(6, 22);
            this.tbxTumListeArama.Name = "tbxTumListeArama";
            this.tbxTumListeArama.Size = new System.Drawing.Size(432, 20);
            this.tbxTumListeArama.TabIndex = 1;
            this.tbxTumListeArama.TextChanged += new System.EventHandler(this.tbxTumListeArama_TextChanged);
            // 
            // dgwBigList
            // 
            this.dgwBigList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBigList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBigList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBigList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwBigList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwBigList.Location = new System.Drawing.Point(6, 48);
            this.dgwBigList.Name = "dgwBigList";
            this.dgwBigList.Size = new System.Drawing.Size(923, 663);
            this.dgwBigList.TabIndex = 0;
            this.dgwBigList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBigList_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Telefon:";
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(82, 67);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(169, 20);
            this.tbxTel.TabIndex = 40;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "İade Edildi",
            "Dışarda"});
            this.cbState.Location = new System.Drawing.Point(82, 530);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(169, 21);
            this.cbState.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Yazar :";
            // 
            // tbxYazarKitapBilgi
            // 
            this.tbxYazarKitapBilgi.Enabled = false;
            this.tbxYazarKitapBilgi.Location = new System.Drawing.Point(82, 152);
            this.tbxYazarKitapBilgi.Name = "tbxYazarKitapBilgi";
            this.tbxYazarKitapBilgi.Size = new System.Drawing.Size(169, 20);
            this.tbxYazarKitapBilgi.TabIndex = 37;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(163, 557);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 42);
            this.btnYazdir.TabIndex = 36;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtIadeTarihi
            // 
            this.dtIadeTarihi.Location = new System.Drawing.Point(82, 504);
            this.dtIadeTarihi.Name = "dtIadeTarihi";
            this.dtIadeTarihi.Size = new System.Drawing.Size(169, 20);
            this.dtIadeTarihi.TabIndex = 33;
            // 
            // dtVerilisTarihi
            // 
            this.dtVerilisTarihi.Location = new System.Drawing.Point(82, 469);
            this.dtVerilisTarihi.Name = "dtVerilisTarihi";
            this.dtVerilisTarihi.Size = new System.Drawing.Size(169, 20);
            this.dtVerilisTarihi.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "İade Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Veriliş Tarihi:";
            // 
            // tbxRafNo
            // 
            this.tbxRafNo.Enabled = false;
            this.tbxRafNo.Location = new System.Drawing.Point(82, 125);
            this.tbxRafNo.Name = "tbxRafNo";
            this.tbxRafNo.Size = new System.Drawing.Size(169, 20);
            this.tbxRafNo.TabIndex = 28;
            // 
            // tbxBookName
            // 
            this.tbxBookName.Enabled = false;
            this.tbxBookName.Location = new System.Drawing.Point(82, 95);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(169, 20);
            this.tbxBookName.TabIndex = 27;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(82, 35);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(169, 20);
            this.tbxUserName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Raf No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kişi Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBoxUpdate);
            this.groupBox2.Controls.Add(this.linkResimYolu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxPicUpdate);
            this.groupBox2.Controls.Add(this.btnYazdir);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxTel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbState);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxUserName);
            this.groupBox2.Controls.Add(this.tbxYazarKitapBilgi);
            this.groupBox2.Controls.Add(this.tbxBookName);
            this.groupBox2.Controls.Add(this.tbxRafNo);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtIadeTarihi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtVerilisTarihi);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 614);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Düzenle";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(2, 735);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1366, 16);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(62, 629);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 20);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Excel\'e aktarmak için tıkla";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picTumList
            // 
            this.picTumList.Location = new System.Drawing.Point(1224, 12);
            this.picTumList.Name = "picTumList";
            this.picTumList.Size = new System.Drawing.Size(134, 711);
            this.picTumList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTumList.TabIndex = 45;
            this.picTumList.TabStop = false;
            this.picTumList.Click += new System.EventHandler(this.picTumList_Click);
            // 
            // tbxPicUpdate
            // 
            this.tbxPicUpdate.Location = new System.Drawing.Point(82, 179);
            this.tbxPicUpdate.Name = "tbxPicUpdate";
            this.tbxPicUpdate.Size = new System.Drawing.Size(169, 20);
            this.tbxPicUpdate.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Resim Yolu";
            // 
            // linkResimYolu
            // 
            this.linkResimYolu.AutoSize = true;
            this.linkResimYolu.Location = new System.Drawing.Point(82, 206);
            this.linkResimYolu.Name = "linkResimYolu";
            this.linkResimYolu.Size = new System.Drawing.Size(84, 13);
            this.linkResimYolu.TabIndex = 44;
            this.linkResimYolu.TabStop = true;
            this.linkResimYolu.Text = "Resim Yolu Ekle";
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.Location = new System.Drawing.Point(82, 223);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(169, 240);
            this.picBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpdate.TabIndex = 45;
            this.picBoxUpdate.TabStop = false;
            // 
            // TumListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.picTumList);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "TumListe";
            this.Text = "Tüm Liste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TumListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBigList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTumList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwBigList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxTumListeArama;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxYazarKitapBilgi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtIadeTarihi;
        private System.Windows.Forms.DateTimePicker dtVerilisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRafNo;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picTumList;
        private System.Windows.Forms.LinkLabel linkResimYolu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPicUpdate;
        private System.Windows.Forms.PictureBox picBoxUpdate;
    }
}