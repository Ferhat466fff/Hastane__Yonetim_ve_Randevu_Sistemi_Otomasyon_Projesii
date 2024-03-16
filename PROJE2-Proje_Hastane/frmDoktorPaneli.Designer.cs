namespace PROJE2_Proje_Hastane
{
    partial class frmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.cmbBRANŞ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            this.btnGÜNCELLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(115, 26);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(185, 36);
            this.txtAD.TabIndex = 1;
            // 
            // cmbBRANŞ
            // 
            this.cmbBRANŞ.FormattingEnabled = true;
            this.cmbBRANŞ.Location = new System.Drawing.Point(115, 110);
            this.cmbBRANŞ.Name = "cmbBRANŞ";
            this.cmbBRANŞ.Size = new System.Drawing.Size(185, 36);
            this.cmbBRANŞ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Soyad:";
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(115, 68);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(185, 36);
            this.txtSOYAD.TabIndex = 2;
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(114, 194);
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(185, 36);
            this.txtŞİFRE.TabIndex = 5;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(115, 152);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(185, 36);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 305);
            this.dataGridView1.TabIndex = 10;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEKLE.Location = new System.Drawing.Point(114, 242);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(75, 38);
            this.btnEKLE.TabIndex = 11;
            this.btnEKLE.Text = "Ekle";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.Color.Brown;
            this.btnSİL.Location = new System.Drawing.Point(207, 242);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(75, 38);
            this.btnSİL.TabIndex = 12;
            this.btnSİL.Text = "Sil";
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // btnGÜNCELLE
            // 
            this.btnGÜNCELLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGÜNCELLE.Location = new System.Drawing.Point(115, 286);
            this.btnGÜNCELLE.Name = "btnGÜNCELLE";
            this.btnGÜNCELLE.Size = new System.Drawing.Size(168, 45);
            this.btnGÜNCELLE.TabIndex = 13;
            this.btnGÜNCELLE.Text = "Güncelle";
            this.btnGÜNCELLE.UseVisualStyleBackColor = false;
            this.btnGÜNCELLE.Click += new System.EventHandler(this.btnGÜNCELLE_Click);
            // 
            // frmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1205, 347);
            this.Controls.Add(this.btnGÜNCELLE);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBRANŞ);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmDoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.frmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.ComboBox cmbBRANŞ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtŞİFRE;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.Button btnGÜNCELLE;
    }
}