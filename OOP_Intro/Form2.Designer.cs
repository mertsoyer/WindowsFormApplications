namespace OOP_Intro
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fiyati = new System.Windows.Forms.Label();
            this.nmrcUpFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpStokMiktar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrcUpGarantiSure = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePckUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDevamDurumu = new System.Windows.Forms.CheckBox();
            this.chckUzatilmisGarantiVarmi = new System.Windows.Forms.CheckBox();
            this.checkBoxTeshirUrunumu = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpStokMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpGarantiSure)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(142, 26);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(168, 22);
            this.txtUrunKodu.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(142, 58);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(168, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // Fiyati
            // 
            this.Fiyati.AutoSize = true;
            this.Fiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyati.Location = new System.Drawing.Point(23, 93);
            this.Fiyati.Name = "Fiyati";
            this.Fiyati.Size = new System.Drawing.Size(52, 20);
            this.Fiyati.TabIndex = 4;
            this.Fiyati.Text = "Fiyatı";
            // 
            // nmrcUpFiyat
            // 
            this.nmrcUpFiyat.Location = new System.Drawing.Point(142, 94);
            this.nmrcUpFiyat.Name = "nmrcUpFiyat";
            this.nmrcUpFiyat.Size = new System.Drawing.Size(168, 22);
            this.nmrcUpFiyat.TabIndex = 5;
            // 
            // nmrcUpStokMiktar
            // 
            this.nmrcUpStokMiktar.Location = new System.Drawing.Point(142, 132);
            this.nmrcUpStokMiktar.Name = "nmrcUpStokMiktar";
            this.nmrcUpStokMiktar.Size = new System.Drawing.Size(168, 22);
            this.nmrcUpStokMiktar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok Miktarı";
            // 
            // nmrcUpGarantiSure
            // 
            this.nmrcUpGarantiSure.Location = new System.Drawing.Point(142, 172);
            this.nmrcUpGarantiSure.Name = "nmrcUpGarantiSure";
            this.nmrcUpGarantiSure.Size = new System.Drawing.Size(168, 22);
            this.nmrcUpGarantiSure.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Garanti Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Üretim Tarihi";
            // 
            // dateTimePckUretimTarihi
            // 
            this.dateTimePckUretimTarihi.Location = new System.Drawing.Point(142, 210);
            this.dateTimePckUretimTarihi.Name = "dateTimePckUretimTarihi";
            this.dateTimePckUretimTarihi.Size = new System.Drawing.Size(168, 22);
            this.dateTimePckUretimTarihi.TabIndex = 11;
            // 
            // checkBoxDevamDurumu
            // 
            this.checkBoxDevamDurumu.AutoSize = true;
            this.checkBoxDevamDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDevamDurumu.Location = new System.Drawing.Point(27, 254);
            this.checkBoxDevamDurumu.Name = "checkBoxDevamDurumu";
            this.checkBoxDevamDurumu.Size = new System.Drawing.Size(131, 20);
            this.checkBoxDevamDurumu.TabIndex = 12;
            this.checkBoxDevamDurumu.Text = "Devam Durumu";
            this.checkBoxDevamDurumu.UseVisualStyleBackColor = true;
            // 
            // chckUzatilmisGarantiVarmi
            // 
            this.chckUzatilmisGarantiVarmi.AutoSize = true;
            this.chckUzatilmisGarantiVarmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckUzatilmisGarantiVarmi.Location = new System.Drawing.Point(164, 254);
            this.chckUzatilmisGarantiVarmi.Name = "chckUzatilmisGarantiVarmi";
            this.chckUzatilmisGarantiVarmi.Size = new System.Drawing.Size(207, 20);
            this.chckUzatilmisGarantiVarmi.TabIndex = 13;
            this.chckUzatilmisGarantiVarmi.Text = "Uzatılmış Garanti Var mı ? ";
            this.chckUzatilmisGarantiVarmi.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeshirUrunumu
            // 
            this.checkBoxTeshirUrunumu.AutoSize = true;
            this.checkBoxTeshirUrunumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxTeshirUrunumu.Location = new System.Drawing.Point(27, 290);
            this.checkBoxTeshirUrunumu.Name = "checkBoxTeshirUrunumu";
            this.checkBoxTeshirUrunumu.Size = new System.Drawing.Size(146, 20);
            this.checkBoxTeshirUrunumu.TabIndex = 14;
            this.checkBoxTeshirUrunumu.Text = "Teşhir Ürünü mü?";
            this.checkBoxTeshirUrunumu.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(27, 343);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 45);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(142, 343);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 45);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(256, 343);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 45);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.GridLines = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(409, 12);
            this.listViewUrunler.MultiSelect = false;
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(624, 607);
            this.listViewUrunler.TabIndex = 18;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            this.listViewUrunler.DoubleClick += new System.EventHandler(this.listViewUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Kodu";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Miktarı";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Üretim Tarihi";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uzatılmış Garanti";
            this.columnHeader6.Width = 114;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 685);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.checkBoxTeshirUrunumu);
            this.Controls.Add(this.chckUzatilmisGarantiVarmi);
            this.Controls.Add(this.checkBoxDevamDurumu);
            this.Controls.Add(this.dateTimePckUretimTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmrcUpGarantiSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrcUpStokMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrcUpFiyat);
            this.Controls.Add(this.Fiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpStokMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpGarantiSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fiyati;
        private System.Windows.Forms.NumericUpDown nmrcUpFiyat;
        private System.Windows.Forms.NumericUpDown nmrcUpStokMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrcUpGarantiSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePckUretimTarihi;
        private System.Windows.Forms.CheckBox checkBoxDevamDurumu;
        private System.Windows.Forms.CheckBox chckUzatilmisGarantiVarmi;
        private System.Windows.Forms.CheckBox checkBoxTeshirUrunumu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}