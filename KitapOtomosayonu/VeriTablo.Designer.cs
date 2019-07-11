namespace KitapOtomosayonu
{
    partial class VeriTablo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblVeriAl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblVeriAl
            // 
            this.lblVeriAl.AutoSize = true;
            this.lblVeriAl.Location = new System.Drawing.Point(264, 52);
            this.lblVeriAl.Name = "lblVeriAl";
            this.lblVeriAl.Size = new System.Drawing.Size(97, 13);
            this.lblVeriAl.TabIndex = 1;
            this.lblVeriAl.TabStop = true;
            this.lblVeriAl.Text = "Verileri Excelden Al";
            this.lblVeriAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVeriAl_LinkClicked);
            // 
            // VeriTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVeriAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VeriTablo";
            this.Text = "VeriTablo";
            this.Load += new System.EventHandler(this.VeriTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lblVeriAl;
    }
}