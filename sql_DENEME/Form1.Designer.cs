namespace sql_DENEME
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
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(123, 72);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(24, 16);
            this.ad.TabIndex = 1;
            this.ad.Text = "Ad";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(100, 103);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(47, 16);
            this.soyad.TabIndex = 2;
            this.soyad.Text = "Soyad";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(65, 142);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(85, 16);
            this.tarih.TabIndex = 3;
            this.tarih.Text = "Doğum Tarih";
            this.tarih.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(227, 31);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(183, 22);
            this.txtNo.TabIndex = 5;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(227, 186);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(183, 22);
            this.txttelefon.TabIndex = 7;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(227, 103);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(183, 22);
            this.txtsoyad.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(227, 66);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(183, 22);
            this.txtad.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEkle.Location = new System.Drawing.Point(486, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 34);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSil.Location = new System.Drawing.Point(486, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 34);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGüncelle.Location = new System.Drawing.Point(486, 130);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(111, 34);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 202);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

