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
    public partial class OtobusTanimla : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        public OtobusTanimla()
        {
            InitializeComponent();
        }

        private void OtobusT_Click(object sender, EventArgs e)
        {

            bool Check = true;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr;


            data.Open();
            cmd2.Connection = data;
            cmd2.CommandText = "SELECT * FROM Otobus where OPlaka='" + OtoPlaka.Text + "'";
            dr = cmd2.ExecuteReader();

            if (dr.Read())
            {
                Check = true;
            }

            else
            {
                Check = false;
            }

            data.Close();



            if (OtoPlaka.Text != "" && OtoMarka.SelectedIndex != -1 && OtoWifi.SelectedIndex != -1 && OtoKoltuk.SelectedIndex != -1 && OtoEkS.SelectedIndex != -1)
            {
                if (Check == false)
                {

                    data.Open();
                    cmd.Connection = data;
                    cmd.CommandText = "Insert Into Otobus(OPlaka, OModel, Wifi, EkranSarjS, KoltukS) values (@OPlaka1, @OModel1, @Wifi1, @EkranSarjS1, @KoltukS1)";
                    cmd.Parameters.AddWithValue("@OPlaka1", OtoPlaka.Text);
                    cmd.Parameters.AddWithValue("@OModel1", OtoMarka.Text);
                    cmd.Parameters.AddWithValue("@Wifi1", OtoWifi.Text);
                    cmd.Parameters.AddWithValue("@EkranSarjS1", OtoEkS.Text);
                    cmd.Parameters.AddWithValue("@KoltukS1", OtoKoltuk.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Tanımlama Başarılı!", "İşlem Gerçekleştirildi");
                    data.Close();
                }

                else
                {
                    MessageBox.Show("Bu plakaya sahip araç zaten filoda mevcut.", "Plaka Hatası");
                }

                Check = true;
            }
            else
            {
                MessageBox.Show("Bilgileri Eksiksiz Doldurunuz!", "Hata");
            }
        }

        private void OtobusTanimla_Load(object sender, EventArgs e)
        {

        }
    }
}
