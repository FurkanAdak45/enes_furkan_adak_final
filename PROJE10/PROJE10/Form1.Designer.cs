
namespace PROJE10
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPersonel = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.MusteriListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SatisListesi = new System.Windows.Forms.DataGridView();
            this.PersonelListesi = new System.Windows.Forms.DataGridView();
            this.UrunListesi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txturunadet = new System.Windows.Forms.MaskedTextBox();
            this.txturunfiyat = new System.Windows.Forms.MaskedTextBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btnmusteriguncelle = new System.Windows.Forms.Button();
            this.txtmusteritelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmusterisoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmusteriek = new System.Windows.Forms.Button();
            this.txtmusteriad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnpersonelguncelle = new System.Windows.Forms.Button();
            this.txtpersoneltc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpersonelsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpersonelekle = new System.Windows.Forms.Button();
            this.txtpersonelad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btnsatissil = new System.Windows.Forms.Button();
            this.txtsatisfiyat = new System.Windows.Forms.MaskedTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSatiis = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtMusteriId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtpersonelId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtsatisıd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunListesi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.BtnPersonel);
            this.panel1.Controls.Add(this.BtnUrun);
            this.panel1.Controls.Add(this.BtnMusteri);
            this.panel1.Controls.Add(this.BtnSatis);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 209);
            this.panel1.TabIndex = 2;
            // 
            // BtnPersonel
            // 
            this.BtnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPersonel.Location = new System.Drawing.Point(9, 113);
            this.BtnPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPersonel.Name = "BtnPersonel";
            this.BtnPersonel.Size = new System.Drawing.Size(146, 48);
            this.BtnPersonel.TabIndex = 12;
            this.BtnPersonel.Text = "Personel Listesi";
            this.BtnPersonel.UseVisualStyleBackColor = false;
            this.BtnPersonel.Click += new System.EventHandler(this.BtnPersonel_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnUrun.Location = new System.Drawing.Point(9, 61);
            this.BtnUrun.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(146, 48);
            this.BtnUrun.TabIndex = 11;
            this.BtnUrun.Text = "Ürün Listesi";
            this.BtnUrun.UseVisualStyleBackColor = false;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnMusteri.Location = new System.Drawing.Point(9, 9);
            this.BtnMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(146, 48);
            this.BtnMusteri.TabIndex = 10;
            this.BtnMusteri.Text = "Müsteri Listesi";
            this.BtnMusteri.UseVisualStyleBackColor = false;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSatis.Location = new System.Drawing.Point(9, 165);
            this.BtnSatis.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(146, 48);
            this.BtnSatis.TabIndex = 0;
            this.BtnSatis.Text = "Satış Listesi";
            this.BtnSatis.UseVisualStyleBackColor = false;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // MusteriListesi
            // 
            this.MusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusteriListesi.Location = new System.Drawing.Point(2, 15);
            this.MusteriListesi.Margin = new System.Windows.Forms.Padding(2);
            this.MusteriListesi.Name = "MusteriListesi";
            this.MusteriListesi.RowHeadersWidth = 51;
            this.MusteriListesi.RowTemplate.Height = 24;
            this.MusteriListesi.Size = new System.Drawing.Size(1304, 424);
            this.MusteriListesi.TabIndex = 0;
            this.MusteriListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriListesi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SatisListesi);
            this.groupBox1.Controls.Add(this.PersonelListesi);
            this.groupBox1.Controls.Add(this.UrunListesi);
            this.groupBox1.Controls.Add(this.MusteriListesi);
            this.groupBox1.Location = new System.Drawing.Point(2, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1308, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste";
            // 
            // SatisListesi
            // 
            this.SatisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SatisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SatisListesi.Enabled = false;
            this.SatisListesi.Location = new System.Drawing.Point(2, 15);
            this.SatisListesi.Margin = new System.Windows.Forms.Padding(2);
            this.SatisListesi.Name = "SatisListesi";
            this.SatisListesi.RowHeadersWidth = 51;
            this.SatisListesi.RowTemplate.Height = 24;
            this.SatisListesi.Size = new System.Drawing.Size(1304, 424);
            this.SatisListesi.TabIndex = 3;
            this.SatisListesi.Visible = false;
            this.SatisListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SatisListesi_CellContentClick);
            // 
            // PersonelListesi
            // 
            this.PersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonelListesi.Enabled = false;
            this.PersonelListesi.Location = new System.Drawing.Point(2, 15);
            this.PersonelListesi.Margin = new System.Windows.Forms.Padding(2);
            this.PersonelListesi.Name = "PersonelListesi";
            this.PersonelListesi.RowHeadersWidth = 51;
            this.PersonelListesi.RowTemplate.Height = 24;
            this.PersonelListesi.Size = new System.Drawing.Size(1304, 424);
            this.PersonelListesi.TabIndex = 2;
            this.PersonelListesi.Visible = false;
            this.PersonelListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonelListesi_CellContentClick);
            // 
            // UrunListesi
            // 
            this.UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrunListesi.Enabled = false;
            this.UrunListesi.Location = new System.Drawing.Point(2, 15);
            this.UrunListesi.Margin = new System.Windows.Forms.Padding(2);
            this.UrunListesi.Name = "UrunListesi";
            this.UrunListesi.RowHeadersWidth = 51;
            this.UrunListesi.RowTemplate.Height = 24;
            this.UrunListesi.Size = new System.Drawing.Size(1304, 424);
            this.UrunListesi.TabIndex = 1;
            this.UrunListesi.Visible = false;
            this.UrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunListesi_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtUrunId);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txturunadet);
            this.groupBox3.Controls.Add(this.txturunfiyat);
            this.groupBox3.Controls.Add(this.btnUrunGuncelle);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(468, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 197);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girişi";
            // 
            // txturunadet
            // 
            this.txturunadet.Location = new System.Drawing.Point(85, 93);
            this.txturunadet.Mask = "00000";
            this.txturunadet.Name = "txturunadet";
            this.txturunadet.Size = new System.Drawing.Size(142, 20);
            this.txturunadet.TabIndex = 13;
            this.txturunadet.ValidatingType = typeof(int);
            // 
            // txturunfiyat
            // 
            this.txturunfiyat.Location = new System.Drawing.Point(85, 66);
            this.txturunfiyat.Mask = "00000";
            this.txturunfiyat.Name = "txturunfiyat";
            this.txturunfiyat.Size = new System.Drawing.Size(142, 20);
            this.txturunfiyat.TabIndex = 12;
            this.txturunfiyat.ValidatingType = typeof(int);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(85, 149);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(142, 26);
            this.btnUrunGuncelle.TabIndex = 11;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(85, 122);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(142, 23);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fiyat:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(85, 39);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(142, 20);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMusteriId);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Btnmusteriguncelle);
            this.groupBox2.Controls.Add(this.txtmusteritelefon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmusterisoyad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnmusteriek);
            this.groupBox2.Controls.Add(this.txtmusteriad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(172, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 197);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Oluştur";
            // 
            // Btnmusteriguncelle
            // 
            this.Btnmusteriguncelle.Location = new System.Drawing.Point(95, 153);
            this.Btnmusteriguncelle.Name = "Btnmusteriguncelle";
            this.Btnmusteriguncelle.Size = new System.Drawing.Size(142, 26);
            this.Btnmusteriguncelle.TabIndex = 17;
            this.Btnmusteriguncelle.Text = "Müşteri Güncelle";
            this.Btnmusteriguncelle.UseVisualStyleBackColor = true;
            this.Btnmusteriguncelle.Click += new System.EventHandler(this.Btnmusteriguncelle_Click);
            // 
            // txtmusteritelefon
            // 
            this.txtmusteritelefon.Location = new System.Drawing.Point(96, 101);
            this.txtmusteritelefon.Mask = "(999) 000-0000";
            this.txtmusteritelefon.Name = "txtmusteritelefon";
            this.txtmusteritelefon.Size = new System.Drawing.Size(141, 20);
            this.txtmusteritelefon.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefon:";
            // 
            // txtmusterisoyad
            // 
            this.txtmusterisoyad.Location = new System.Drawing.Point(95, 75);
            this.txtmusterisoyad.Name = "txtmusterisoyad";
            this.txtmusterisoyad.Size = new System.Drawing.Size(142, 20);
            this.txtmusterisoyad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soyad:";
            // 
            // btnmusteriek
            // 
            this.btnmusteriek.Location = new System.Drawing.Point(95, 128);
            this.btnmusteriek.Name = "btnmusteriek";
            this.btnmusteriek.Size = new System.Drawing.Size(142, 23);
            this.btnmusteriek.TabIndex = 10;
            this.btnmusteriek.Text = "Müşteri Ekle";
            this.btnmusteriek.UseVisualStyleBackColor = true;
            this.btnmusteriek.Click += new System.EventHandler(this.btnmusteriek_Click);
            // 
            // txtmusteriad
            // 
            this.txtmusteriad.Location = new System.Drawing.Point(95, 49);
            this.txtmusteriad.Name = "txtmusteriad";
            this.txtmusteriad.Size = new System.Drawing.Size(142, 20);
            this.txtmusteriad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtpersonelId);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnpersonelguncelle);
            this.groupBox4.Controls.Add(this.txtpersoneltc);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtpersonelsoyad);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnpersonelekle);
            this.groupBox4.Controls.Add(this.txtpersonelad);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(714, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 197);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel Oluştur";
            // 
            // btnpersonelguncelle
            // 
            this.btnpersonelguncelle.Location = new System.Drawing.Point(104, 146);
            this.btnpersonelguncelle.Name = "btnpersonelguncelle";
            this.btnpersonelguncelle.Size = new System.Drawing.Size(142, 26);
            this.btnpersonelguncelle.TabIndex = 17;
            this.btnpersonelguncelle.Text = "Personel Güncelle";
            this.btnpersonelguncelle.UseVisualStyleBackColor = true;
            this.btnpersonelguncelle.Click += new System.EventHandler(this.btnpersonelguncelle_Click);
            // 
            // txtpersoneltc
            // 
            this.txtpersoneltc.Location = new System.Drawing.Point(105, 94);
            this.txtpersoneltc.Mask = "00000000000";
            this.txtpersoneltc.Name = "txtpersoneltc";
            this.txtpersoneltc.Size = new System.Drawing.Size(141, 20);
            this.txtpersoneltc.TabIndex = 16;
            this.txtpersoneltc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "TC Kimlik:";
            // 
            // txtpersonelsoyad
            // 
            this.txtpersonelsoyad.Location = new System.Drawing.Point(104, 68);
            this.txtpersonelsoyad.Name = "txtpersonelsoyad";
            this.txtpersonelsoyad.Size = new System.Drawing.Size(142, 20);
            this.txtpersonelsoyad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Soyad:";
            // 
            // btnpersonelekle
            // 
            this.btnpersonelekle.Location = new System.Drawing.Point(104, 121);
            this.btnpersonelekle.Name = "btnpersonelekle";
            this.btnpersonelekle.Size = new System.Drawing.Size(142, 23);
            this.btnpersonelekle.TabIndex = 10;
            this.btnpersonelekle.Text = "Personel Ekle";
            this.btnpersonelekle.UseVisualStyleBackColor = true;
            this.btnpersonelekle.Click += new System.EventHandler(this.btnpersonelekle_Click);
            // 
            // txtpersonelad
            // 
            this.txtpersonelad.Location = new System.Drawing.Point(104, 42);
            this.txtpersonelad.Name = "txtpersonelad";
            this.txtpersonelad.Size = new System.Drawing.Size(142, 20);
            this.txtpersonelad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ad:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtsatisıd);
            this.groupBox5.Controls.Add(this.Btnsatissil);
            this.groupBox5.Controls.Add(this.txtsatisfiyat);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.BtnSatiis);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(1018, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 197);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satış Oluştur";
            // 
            // Btnsatissil
            // 
            this.Btnsatissil.Location = new System.Drawing.Point(148, 125);
            this.Btnsatissil.Name = "Btnsatissil";
            this.Btnsatissil.Size = new System.Drawing.Size(142, 23);
            this.Btnsatissil.TabIndex = 23;
            this.Btnsatissil.Text = "Satış Sil";
            this.Btnsatissil.UseVisualStyleBackColor = true;
            this.Btnsatissil.Click += new System.EventHandler(this.Btnsatissil_Click);
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Location = new System.Drawing.Point(76, 92);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(206, 20);
            this.txtsatisfiyat.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(76, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(206, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Fiyat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Personel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Müşteri:";
            // 
            // BtnSatiis
            // 
            this.BtnSatiis.Location = new System.Drawing.Point(6, 125);
            this.BtnSatiis.Name = "BtnSatiis";
            this.BtnSatiis.Size = new System.Drawing.Size(142, 23);
            this.BtnSatiis.TabIndex = 10;
            this.BtnSatiis.Text = "Satış Gerçekleştir";
            this.BtnSatiis.UseVisualStyleBackColor = true;
            this.BtnSatiis.Click += new System.EventHandler(this.BtnSatiis_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ürün Adı:";
            // 
            // TxtMusteriId
            // 
            this.TxtMusteriId.Enabled = false;
            this.TxtMusteriId.Location = new System.Drawing.Point(96, 24);
            this.TxtMusteriId.Name = "TxtMusteriId";
            this.TxtMusteriId.Size = new System.Drawing.Size(142, 20);
            this.TxtMusteriId.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Müşteri Numarası:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Enabled = false;
            this.TxtUrunId.Location = new System.Drawing.Point(85, 13);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(142, 20);
            this.TxtUrunId.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Ürün Numarası:";
            // 
            // txtpersonelId
            // 
            this.txtpersonelId.Enabled = false;
            this.txtpersonelId.Location = new System.Drawing.Point(104, 15);
            this.txtpersonelId.Name = "txtpersonelId";
            this.txtpersonelId.Size = new System.Drawing.Size(142, 20);
            this.txtpersonelId.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "PersonelNumarası:";
            // 
            // txtsatisıd
            // 
            this.txtsatisıd.Enabled = false;
            this.txtsatisıd.Location = new System.Drawing.Point(123, 157);
            this.txtsatisıd.Name = "txtsatisıd";
            this.txtsatisıd.Size = new System.Drawing.Size(64, 20);
            this.txtsatisıd.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1312, 655);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SatisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunListesi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.DataGridView MusteriListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmusterisoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmusteriek;
        private System.Windows.Forms.TextBox txtmusteriad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtmusteritelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txturunadet;
        private System.Windows.Forms.MaskedTextBox txturunfiyat;
        private System.Windows.Forms.Button Btnmusteriguncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnpersonelguncelle;
        private System.Windows.Forms.MaskedTextBox txtpersoneltc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpersonelsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpersonelekle;
        private System.Windows.Forms.TextBox txtpersonelad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSatiis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btnsatissil;
        private System.Windows.Forms.MaskedTextBox txtsatisfiyat;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnPersonel;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.DataGridView UrunListesi;
        private System.Windows.Forms.DataGridView PersonelListesi;
        private System.Windows.Forms.DataGridView SatisListesi;
        private System.Windows.Forms.TextBox TxtMusteriId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtpersonelId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtsatisıd;
    }
}

