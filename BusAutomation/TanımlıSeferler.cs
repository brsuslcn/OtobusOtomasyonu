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

namespace OtobusFirmasi
{
    public partial class TanımlıSeferler : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;");
        SqlDataAdapter dataadapter;
        DataTable tbl = new DataTable();
        public TanımlıSeferler()
        {
            InitializeComponent();
        }

        void GuncelTablo()
        {
            tbl.Clear();
            dataadapter = new SqlDataAdapter("SELECT *FROM Arac", data);
            dataadapter.Fill(tbl);
            grdTanımlı.DataSource = tbl;
        }

        private void TanımlıSeferler_Load(object sender, EventArgs e)
        {

            GuncelTablo();
           // dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/MM/yyyy";

            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
        }



        private void OzelKayitlar_Click(object sender, EventArgs e)
        {
            data.Open();
            SqlCommand Ara = new SqlCommand("SELECT * from Arac where Adres like '%" + Sehirler.Text + " - " + Sehirler2.Text + "%'", data);
            SqlDataReader dr = Ara.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            grdTanımlı.DataSource = dt;
            data.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;

            try
            {

                data.Close();
                data.Open();
                SqlCommand edt1 = new SqlCommand("SELECT *FROM Arac WHERE Seans='" + grdTanımlı.CurrentRow.Cells[0].Value.ToString() + "'", data);
                SqlDataReader dr = edt1.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                DataRow row = dt.Rows[0];
                comboBox1.Text = row["Seans"].ToString();
                dr.Close();


                SqlCommand edt2 = new SqlCommand("SELECT * FROM Arac WHERE Plaka='" + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "'", data);
                dr = edt2.ExecuteReader();

                dt.Load(dr);
                row = dt.Rows[1];
                label4.Text = row["Plaka"].ToString();
                dr.Close();


                SqlCommand edt3 = new SqlCommand("SELECT * FROM Arac WHERE Adres='" + grdTanımlı.CurrentRow.Cells[2].Value.ToString() + "'", data);
                dr = edt2.ExecuteReader();

                dt.Load(dr);
                row = dt.Rows[2];
                label6.Text = row["Adres"].ToString();
                dr.Close();

                SqlCommand edt4 = new SqlCommand("SELECT * FROM Arac WHERE Tarih='" + grdTanımlı.CurrentRow.Cells[4].Value.ToString() + "'", data);
                dr = edt2.ExecuteReader();

                dt.Load(dr);
                row = dt.Rows[3];
                dateTimePicker1.Text = row["Tarih"].ToString();
                dr.Close();

                data.Close();
            }

            catch
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!", "İşlem Başarısız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

              if (comboBox1.SelectedIndex != -1 && dateTimePicker1.Text != "")
              {
                    data.Open();
                    SqlCommand Guncelle2 = new SqlCommand("UPDATE Arac Set Seans='" + comboBox1.Text + "' WHERE Plaka='" + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "'", data);
                    Guncelle2.ExecuteNonQuery();
                    data.Close();

                    data.Open();
                    SqlCommand Guncelle3 = new SqlCommand("UPDATE Arac Set Tarih='" + dateTimePicker1.Text + "' WHERE Plaka='" + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "'", data);
                    Guncelle3.ExecuteNonQuery();
                    data.Close();

                    data.Open();
                    SqlCommand Guncelle4 = new SqlCommand("UPDATE Arac Set IDP='" + grdTanımlı.CurrentRow.Cells[2].Value.ToString() + " - " + dateTimePicker1.Text  + " - " + comboBox1.Text + " - " + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "' WHERE Plaka='" + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "'", data);
                    Guncelle4.ExecuteNonQuery();
                    data.Close();

                    GuncelTablo();
                    dateTimePicker1.Enabled = false;
                    comboBox1.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Bilgileri Eksiksiz Doldurunuz!", "Hata");
                }


        }

        void SeferiSifirla()
        {
            SqlCommand srch, delete1;
            SqlDataReader datareader2;

            try
            {

                srch = new SqlCommand();
                data.Open();
                srch.Connection = data;
                srch.CommandText = "Select *From Arac Where IDP='" + grdTanımlı.CurrentRow.Cells[3].Value.ToString() + "'";
                datareader2 = srch.ExecuteReader();
                if (datareader2.Read())
                {
                    data.Close();
                    data.Open();
                    for (int i = 1; i <= 32; i++)
                    {
                        delete1 = new SqlCommand();
                        delete1.Connection = data;
                        delete1.CommandText = "DELETE FROM SatisVeRezerve WHERE ID2 Like'%" + i + " " + grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "%'";
                        delete1.ExecuteNonQuery();
                    }
                    data.Close();
                }
            }

            catch
            {
               
            }

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand srch, delete1;
            SqlDataReader datareader2;
      

            try
            {

                DialogResult dr = MessageBox.Show("Seferi Sıfırlamak İstediğinize Emin misiniz?", "Sıfırlama Onayı", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    srch = new SqlCommand();
                    data.Open();
                    srch.Connection = data;
                    srch.CommandText = "Select *FROM Arac Where IDP='" + grdTanımlı.CurrentRow.Cells[3].Value.ToString() + "'";
                    datareader2 = srch.ExecuteReader();
                    if (datareader2.Read())
                    {
                        data.Close();
                        data.Open();
                       
                        for (int i = 1; i <= 32; i++)
                        {
                            delete1 = new SqlCommand();
                            delete1.Connection = data;
                            delete1.CommandText = "DELETE FROM SatisVeRezerve WHERE ID2 Like'%" + i + " " +grdTanımlı.CurrentRow.Cells[1].Value.ToString() + "%'";
                            delete1.ExecuteNonQuery();
                        }
                        MessageBox.Show("Sıfırlama Başarılı!", "Sıfırlandı");
                        data.Close();
                    }

                }
            }

            catch
            {
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand delete2;
            SqlDataReader datareader3;

            SeferiSifirla();

            try
            {

                DialogResult A = MessageBox.Show("Seferi Kaldırmak İstediğinize Emin misiniz?", "Kaldırma Onayı", MessageBoxButtons.YesNo);
                if (A == DialogResult.Yes)
                {
                    delete2 = new SqlCommand();
                    data.Close();
                    data.Open();
                    delete2.Connection = data;
                    delete2.CommandText = "SELECT *FROM Arac WHERE IDP='" + grdTanımlı.CurrentRow.Cells[3].Value.ToString() + "'";
                    datareader3 = delete2.ExecuteReader();
                    if (datareader3.Read())
                    {
                        data.Close();
                        data.Open();
                        delete2 = new SqlCommand();
                        delete2.Connection = data;
                        delete2.CommandText = "DELETE From Arac WHERE IDP='" + grdTanımlı.CurrentRow.Cells[3].Value.ToString() + "'";
                        delete2.ExecuteNonQuery();
                        MessageBox.Show("Sefer Kaldırıldı!", "İşlem Başarılı");
                        data.Close();
                    }

                }
            }

            catch
            {
                MessageBox.Show("Kaldırılacak Sefer Seçilmedi!","Hata");
            }
                     

            GuncelTablo();
        }
    }
}
