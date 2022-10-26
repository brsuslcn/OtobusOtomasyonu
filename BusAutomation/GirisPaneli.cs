using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace OtobusOtomasyonuBaris
{
    public partial class GirisPaneli : Form
    {
        SqlConnection DataBase = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Command = new SqlCommand();
        SqlDataReader dr;

        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            Pass.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.Open();
            Command = new SqlCommand("SELECT *FROM YonetimPanel where KullaniciAdi='" + KAd.Text + "'AND Sifre='" + Pass.Text + "'", DataBase);
            dr = Command.ExecuteReader();

            if(dr.Read())
            {
                OtobusOtomasyonuBaris.MainMenu Ac = new OtobusOtomasyonuBaris.MainMenu();
                Ac.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girildi.","Hatalı Giriş");
            }

            DataBase.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
