namespace KitapOtomosayonu
{
    partial class SifreUnuttum
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
            this.texEpostaYolla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.textKulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texEpostaYolla
            // 
            this.texEpostaYolla.Location = new System.Drawing.Point(124, 44);
            this.texEpostaYolla.Name = "texEpostaYolla";
            this.texEpostaYolla.Size = new System.Drawing.Size(189, 20);
            this.texEpostaYolla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Postanızı Girin";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(124, 95);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
             // 
            // textKulAdi
            // 
            this.textKulAdi.Location = new System.Drawing.Point(124, 70);
            this.textKulAdi.Name = "textKulAdi";
            this.textKulAdi.Size = new System.Drawing.Size(189, 20);
            this.textKulAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // SifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKulAdi);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texEpostaYolla);
            this.Name = "SifreUnuttum";
            this.Text = "SifreUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texEpostaYolla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox textKulAdi;
        private System.Windows.Forms.Label label2;
    }
}