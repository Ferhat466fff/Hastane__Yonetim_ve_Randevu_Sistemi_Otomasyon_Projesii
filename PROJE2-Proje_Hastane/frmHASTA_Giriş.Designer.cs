namespace PROJE2_Proje_Hastane
{
    partial class frmHASTA_Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHASTA_Giriş));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.btnGİRİŞYAP = new System.Windows.Forms.Button();
            this.linkÜYEOL = new System.Windows.Forms.LinkLabel();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(160, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(221, 114);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(129, 29);
            this.mskTC.TabIndex = 1;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // btnGİRİŞYAP
            // 
            this.btnGİRİŞYAP.Location = new System.Drawing.Point(251, 204);
            this.btnGİRİŞYAP.Name = "btnGİRİŞYAP";
            this.btnGİRİŞYAP.Size = new System.Drawing.Size(99, 39);
            this.btnGİRİŞYAP.TabIndex = 3;
            this.btnGİRİŞYAP.Text = "Giriş Yap";
            this.btnGİRİŞYAP.UseVisualStyleBackColor = true;
            this.btnGİRİŞYAP.Click += new System.EventHandler(this.btnGİRİŞYAP_Click);
            // 
            // linkÜYEOL
            // 
            this.linkÜYEOL.AutoSize = true;
            this.linkÜYEOL.Location = new System.Drawing.Point(408, 159);
            this.linkÜYEOL.Name = "linkÜYEOL";
            this.linkÜYEOL.Size = new System.Drawing.Size(60, 22);
            this.linkÜYEOL.TabIndex = 9;
            this.linkÜYEOL.TabStop = true;
            this.linkÜYEOL.Text = "Üye Ol";
            this.linkÜYEOL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkÜYEOL_LinkClicked);
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(221, 156);
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(129, 29);
            this.txtŞİFRE.TabIndex = 2;
            this.txtŞİFRE.UseSystemPasswordChar = true;
            // 
            // frmHASTA_Giriş
            // 
            this.AcceptButton = this.btnGİRİŞYAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(540, 298);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.linkÜYEOL);
            this.Controls.Add(this.btnGİRİŞYAP);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHASTA_Giriş";
            this.Text = "Hasta_Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Button btnGİRİŞYAP;
        private System.Windows.Forms.LinkLabel linkÜYEOL;
        private System.Windows.Forms.TextBox txtŞİFRE;
    }
}