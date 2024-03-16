namespace PROJE2_Proje_Hastane
{
    partial class frmBRANŞ
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
            this.btnSİL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.btnGÜNCELLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.Color.Brown;
            this.btnSİL.Location = new System.Drawing.Point(206, 143);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(75, 38);
            this.btnSİL.TabIndex = 26;
            this.btnSİL.Text = "Sil";
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 220);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(113, 80);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(185, 36);
            this.txtAD.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Branş Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 36);
            this.txtID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branş id:";
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEKLE.Location = new System.Drawing.Point(112, 143);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(75, 38);
            this.btnEKLE.TabIndex = 25;
            this.btnEKLE.Text = "Ekle";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnGÜNCELLE
            // 
            this.btnGÜNCELLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGÜNCELLE.Location = new System.Drawing.Point(113, 187);
            this.btnGÜNCELLE.Name = "btnGÜNCELLE";
            this.btnGÜNCELLE.Size = new System.Drawing.Size(168, 45);
            this.btnGÜNCELLE.TabIndex = 27;
            this.btnGÜNCELLE.Text = "Güncelle";
            this.btnGÜNCELLE.UseVisualStyleBackColor = false;
            this.btnGÜNCELLE.Click += new System.EventHandler(this.btnGÜNCELLE_Click);
            // 
            // frmBRANŞ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(764, 244);
            this.Controls.Add(this.btnGÜNCELLE);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBRANŞ";
            this.Text = "BRANŞ_Paneli";
            this.Load += new System.EventHandler(this.frmBRANŞ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnGÜNCELLE;
    }
}