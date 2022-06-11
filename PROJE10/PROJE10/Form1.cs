using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8078DE1;Initial Catalog=Proje;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriListesi.Enabled = false;
            MusteriListesi.Visible = false;
            UrunListesi.Enabled = false;
            UrunListesi.Visible = false;
            PersonelListesi.Enabled = false;
            PersonelListesi.Visible = false;
            SatisListesi.Enabled = false;
            SatisListesi.Visible = false;

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Musteri ", baglanti);
            da.Fill(dt);
            MusteriListesi.DataSource = dt;

            baglanti.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from Urunler", baglanti);
            urun.Fill(dt1);
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Ad";
            comboBox1.DataSource = dt1;

            SqlDataAdapter musteri = new SqlDataAdapter("select Id,(Ad+' '+Soyad) As Isim from Musteri", baglanti);
            musteri.Fill(dt2);
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Isim";
            comboBox2.DataSource = dt2;

            SqlDataAdapter personel = new SqlDataAdapter("select Id,(Ad+' '+Soyad) As Isim from Personel", baglanti);
            personel.Fill(dt3);
            comboBox3.ValueMember = "Id";
            comboBox3.DisplayMember = "Isim";
            comboBox3.DataSource = dt3;
            baglanti.Close();
        }

        void urunlerigetir()
        {
            MusteriListesi.Enabled = false;
            MusteriListesi.Visible = false;
            UrunListesi.Enabled = true;
            UrunListesi.Visible = true;
            PersonelListesi.Enabled = false;
            PersonelListesi.Visible = false;
            SatisListesi.Enabled = false;
            SatisListesi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("execute ProUrun", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UrunListesi.DataSource = dt;
        }

        void Musterilerigetir()
        {
            MusteriListesi.Enabled = true;
            MusteriListesi.Visible = true;
            UrunListesi.Enabled = false;
            UrunListesi.Visible = false;
            PersonelListesi.Enabled = false;
            PersonelListesi.Visible = false;
            SatisListesi.Enabled = false;
            SatisListesi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("execute ProMusteri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MusteriListesi.DataSource = dt;
        }
        void PersonelleriGetir()
        {
            MusteriListesi.Enabled = false;
            MusteriListesi.Visible = false;
            UrunListesi.Enabled = false;
            UrunListesi.Visible = false;
            PersonelListesi.Enabled = true;
            PersonelListesi.Visible = true;
            SatisListesi.Enabled = false;
            SatisListesi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("execute ProPersonel", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PersonelListesi.DataSource = dt;
        }
        void SatislariGetir()
        {
            MusteriListesi.Enabled = false;
            MusteriListesi.Visible = false;
            UrunListesi.Enabled = false;
            UrunListesi.Visible = false;
            PersonelListesi.Enabled = false;
            PersonelListesi.Visible = false;
            SatisListesi.Enabled = true;
            SatisListesi.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("execute Hareketler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SatisListesi.DataSource = dt;
        }
        private void MusteriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = MusteriListesi.SelectedCells[0].RowIndex;
            txtmusteriad.Text = MusteriListesi.Rows[secilen].Cells[1].Value.ToString();
            txtmusterisoyad.Text = MusteriListesi.Rows[secilen].Cells[2].Value.ToString();
            txtmusteritelefon.Text = MusteriListesi.Rows[secilen].Cells[3].Value.ToString();
            TxtMusteriId.Text = MusteriListesi.Rows[secilen].Cells[0].Value.ToString();
        }

        private void UrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = UrunListesi.SelectedCells[0].RowIndex;
            txtUrunAd.Text = UrunListesi.Rows[secilen].Cells[1].Value.ToString();
            txturunfiyat.Text = UrunListesi.Rows[secilen].Cells[3].Value.ToString();
            txturunadet.Text = UrunListesi.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunId.Text = UrunListesi.Rows[secilen].Cells[0].Value.ToString();
        }

        private void PersonelListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = PersonelListesi.SelectedCells[0].RowIndex;
            txtpersonelad.Text = PersonelListesi.Rows[secilen].Cells[1].Value.ToString();
            txtpersonelsoyad.Text = PersonelListesi.Rows[secilen].Cells[2].Value.ToString();
            txtpersoneltc.Text = PersonelListesi.Rows[secilen].Cells[3].Value.ToString();
            txtpersonelId.Text = PersonelListesi.Rows[secilen].Cells[0].Value.ToString();
        }

        private void SatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = SatisListesi.SelectedCells[0].RowIndex;
            txtsatisıd.Text = SatisListesi.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            Musterilerigetir();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            urunlerigetir();
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }
        private void BtnSatis_Click(object sender, EventArgs e)
        {
            SatislariGetir();
        }
        private void btnmusteriek_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteri (Ad, Soyad,Telefon) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmusteriad.Text);
            komut.Parameters.AddWithValue("@p2", txtmusterisoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtmusteritelefon.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi");
            baglanti.Close();
            Musterilerigetir();
        }

        private void Btnmusteriguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri set Ad=@p1, Soyad=@p2, Telefon=@p3 where Id=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmusteriad.Text);
            komut.Parameters.AddWithValue("@p2", txtmusterisoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtmusteritelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtMusteriId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri bilgisi güncellendi");
            baglanti.Close();
            Musterilerigetir();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler (Ad, Fiyat,Adet) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txturunfiyat.Text);
            komut.Parameters.AddWithValue("@p3", txturunadet.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Eklendi");
            baglanti.Close();
            urunlerigetir();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Urunler set Ad=@p1, Fiyat=@p2, Adet=@p3 where Id=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txturunfiyat.Text);
            komut.Parameters.AddWithValue("@p3", txturunadet.Text);
            komut.Parameters.AddWithValue("@p4", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün bilgisi güncellendi");
            baglanti.Close();
            urunlerigetir();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (Ad, Soyad,TC) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtpersoneltc.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");
            baglanti.Close();
            PersonelleriGetir();
        }

        private void btnpersonelguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set Ad=@p1, Soyad=@p2, TC=@p3 where Id=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtpersoneltc.Text);
            komut.Parameters.AddWithValue("@p4", txtpersonelId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel bilgisi güncellendi");
            baglanti.Close();
            PersonelleriGetir();
        }

        private void BtnSatiis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Hareket (UrunId, MusteriId,PersonelId,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
            komut.Parameters.AddWithValue("@p4", txtsatisfiyat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Satış Eklendi");
            baglanti.Close();
            SatislariGetir();
        }

        private void Btnsatissil_Click(object sender, EventArgs e)
        {
            if (txtsatisıd.Text == "")
            {
                MessageBox.Show("Lütfen Silmek istediğiniz satıra tıklayınız ve kutucuktaki numarayla karşılaştırınız!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Hareket where Id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtsatisıd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Satış Silindi");
                baglanti.Close();
                SatislariGetir();
            }
        }
    }
}
