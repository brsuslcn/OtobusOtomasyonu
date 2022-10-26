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
    public partial class SifreSifirlama : Form
    {
        SqlConnection DataBase = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Command = new SqlCommand();
        SqlDataReader dr;

        public SifreSifirlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 4 && textBox2.Text!= "")
            {
                DataBase.Open();
                Command = new SqlCommand("UPDATE YonetimPanel SET Sifre='" + textBox2.Text + "'", DataBase);
                dr = Command.ExecuteReader();
                MessageBox.Show("Şifre Değiştirme Başarılı!", "Şifre Güncellendi");
                DataBase.Close();
            }

            else
            {
                MessageBox.Show("En az 4 karakterli bir şifre giriniz.", "Şifre Değiştirilemedi!");
            }
        }

        private void SifreSifirlama_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
