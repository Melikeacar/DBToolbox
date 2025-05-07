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
using System.Data.Common;

namespace sql_DENEME
{
    public partial class Form1 : Form
    {
        SqlConnection baglantı;
        SqlCommand komut;
        SqlDataAdapter da;



        public Form1()
        {
            InitializeComponent();
            MusteriGetir();
        }


        void MusteriGetir()
        {
            baglantı = new SqlConnection("Server = LAPTOP-558BI1BU\\MSSQLSERVER02;Initial Catalog=okul; Integrated Security=SSPI");
            da = new SqlDataAdapter("SELECT *FROM MÜŞTERİ", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO MÜŞTERİ(ad,soyad,dtarih,tel)VALUES (@ad,@soyad,@dtarih,@tel)";
            komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@dtarih",dateTimePicker1.Value );
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MusteriGetir();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM MÜŞTERİ WHERE MNO=@mno";
            komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(txtNo.Text));
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MusteriGetir();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE MÜŞTERİ SET ad=@ad, soyad=@soyad,dtarih=@dtarih,tel=@tel WHERE MNO=@mno";
            komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("ad", txtad.Text);
            komut.Parameters.AddWithValue("soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("dtarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("tel", txttelefon.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MusteriGetir();
        }
    }
}


