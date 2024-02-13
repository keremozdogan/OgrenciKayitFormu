namespace OgrenciKayitFormu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblOKulNo = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.combobox1Cinsiyet = new System.Windows.Forms.ComboBox();
            this.combobox2Bolum = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(26, 110);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(73, 17);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblOKulNo
            // 
            this.lblOKulNo.AutoSize = true;
            this.lblOKulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOKulNo.Location = new System.Drawing.Point(26, 168);
            this.lblOKulNo.Name = "lblOKulNo";
            this.lblOKulNo.Size = new System.Drawing.Size(63, 17);
            this.lblOKulNo.TabIndex = 1;
            this.lblOKulNo.Text = "Okul No:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(26, 228);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(97, 17);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(356, 113);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(61, 17);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(356, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınıf:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(356, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bölüm:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(129, 110);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Location = new System.Drawing.Point(129, 168);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(100, 20);
            this.txtOkulNo.TabIndex = 2;
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(445, 167);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(121, 20);
            this.txtSinif.TabIndex = 5;
            // 
            // combobox1Cinsiyet
            // 
            this.combobox1Cinsiyet.FormattingEnabled = true;
            this.combobox1Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız",
            "Belirtmek istemiyorum"});
            this.combobox1Cinsiyet.Location = new System.Drawing.Point(445, 113);
            this.combobox1Cinsiyet.Name = "combobox1Cinsiyet";
            this.combobox1Cinsiyet.Size = new System.Drawing.Size(121, 21);
            this.combobox1Cinsiyet.TabIndex = 4;
            // 
            // combobox2Bolum
            // 
            this.combobox2Bolum.FormattingEnabled = true;
            this.combobox2Bolum.Items.AddRange(new object[] {
            "Bilgisayar M.",
            "Endüstri M.",
            "Yazılım M."});
            this.combobox2Bolum.Location = new System.Drawing.Point(445, 224);
            this.combobox2Bolum.Name = "combobox2Bolum";
            this.combobox2Bolum.Size = new System.Drawing.Size(121, 21);
            this.combobox2Bolum.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(76, 288);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 48);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(445, 288);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 48);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.Location = new System.Drawing.Point(12, 363);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(636, 173);
            this.lstGoster.TabIndex = 14;
            this.lstGoster.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(151, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "ÖĞRENCİ KAYIT FORMU";
            // 
            // maskedTextBoxDogumTarihi
            // 
            this.maskedTextBoxDogumTarihi.Location = new System.Drawing.Point(130, 228);
            this.maskedTextBoxDogumTarihi.Mask = "00/00/0000";
            this.maskedTextBoxDogumTarihi.Name = "maskedTextBoxDogumTarihi";
            this.maskedTextBoxDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDogumTarihi.TabIndex = 3;
            this.maskedTextBoxDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(660, 553);
            this.Controls.Add(this.maskedTextBoxDogumTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstGoster);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.combobox2Bolum);
            this.Controls.Add(this.combobox1Cinsiyet);
            this.Controls.Add(this.txtSinif);
            this.Controls.Add(this.txtOkulNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblOKulNo);
            this.Controls.Add(this.lblAdSoyad);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Formu (ÖKF)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblOKulNo;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.ComboBox combobox1Cinsiyet;
        private System.Windows.Forms.ComboBox combobox2Bolum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lstGoster;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDogumTarihi;
    }
}

