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
    public partial class TumKayitlar : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;");
        SqlDataAdapter dataAdapter;
        DataTable Tablo = new DataTable();
        public TumKayitlar()
        {
            InitializeComponent();
        }
        void Search()
        {
            dataAdapter = new SqlDataAdapter("SELECT *FROM SatisVeRezerve", data);
            dataAdapter.Fill(Tablo);
            grdKayıtlar.DataSource = Tablo;
        }
        private void TumKayitlar_Load(object sender, EventArgs e)
        {
            Search();
            KoltukNo.Text = " ";
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTel.Enabled = false;
            cmbCinsiyet.Enabled = false;
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
            txtTC.MaxLength = 11;
            txtTel.MaxLength = 10;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                data.Open();
                SqlCommand sil = new SqlCommand("DELETE FROM SatisVeRezerve WHERE ID='" + grdKayıtlar.CurrentRow.Cells[0].Value.ToString() + "'", data);
                sil.ExecuteNonQuery();
                data.Close();
                Tablo.Clear();
                Search();

            }

            catch
            {
                MessageBox.Show("Herhangi bir kayıt seçmediniz.", "Hata");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtTC.Enabled = true;         
                    if (txtAd.Text != null && txtAd.Text != "")
                    {
                        data.Open();
                        SqlCommand Guncelle2 = new SqlCommand("Update SatisVeRezerve Set Ad='" + txtAd.Text + "' where TC='" + grdKayıtlar.CurrentRow.Cells[3].Value.ToString() + "'", data);
                        Guncelle2.ExecuteNonQuery();
                        data.Close();
                    }

                    if (txtSoyad.Text != null && txtSoyad.Text != "")
                    {
                        data.Open();
                        SqlCommand Guncelle2 = new SqlCommand("Update SatisVeRezerve Set Soyad='" + txtSoyad.Text + "' where TC='" + grdKayıtlar.CurrentRow.Cells[3].Value.ToString() + "'", data);
                        Guncelle2.ExecuteNonQuery();
                        data.Close();
                    }
                   

                    if (txtTel.Text != null && txtTel.Text != "")
                    {
                        data.Open();
                        SqlCommand Guncelle2 = new SqlCommand("Update SatisVeRezerve Set Tel='" + txtTel.Text + "' where TC='" + grdKayıtlar.CurrentRow.Cells[3].Value.ToString() + "'", data);
                        Guncelle2.ExecuteNonQuery();
                        data.Close();
                    }

                    if (cmbCinsiyet.Text != null && cmbCinsiyet.Text != "")
                    {
                        data.Open();
                        SqlCommand Guncelle2 = new SqlCommand("Update SatisVeRezerve Set Cinsiyet='" + cmbCinsiyet.Text + "' where TC='" + grdKayıtlar.CurrentRow.Cells[3].Value.ToString() + "'", data);
                        Guncelle2.ExecuteNonQuery();
                        data.Close();
                    }
                    Tablo.Clear();
                    Search();
               
            }

            catch
            {
                MessageBox.Show("Herhangi bir kayıt seçmendiniz.", "Hata");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txtTC.Enabled = false;
                txtAd.Enabled = true;
                txtSoyad.Enabled = true;
                txtTel.Enabled = true;
                cmbCinsiyet.Enabled = true;


                    data.Open();
                    SqlCommand edt1 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE Ad='" + grdKayıtlar.CurrentRow.Cells[1].Value.ToString() + "'", data);
                    SqlDataReader dr = edt1.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    DataRow row = dt.Rows[0];
                    txtAd.Text = row["Ad"].ToString();
                    dr.Close();

                    SqlCommand edt2 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE Soyad='" + grdKayıtlar.CurrentRow.Cells[2].Value.ToString() + "'", data);
                    dr = edt2.ExecuteReader();

                    dt.Load(dr);
                    row = dt.Rows[1];
                    txtSoyad.Text = row["Soyad"].ToString();
                    dr.Close();

                    SqlCommand edt3 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE TC='" + grdKayıtlar.CurrentRow.Cells[3].Value.ToString() + "'", data);
                    dr = edt3.ExecuteReader();

                    dt.Load(dr);
                    row = dt.Rows[2];
                    txtTC.Text = row["TC"].ToString();
                    dr.Close();

                    SqlCommand edt4 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE Tel='" + grdKayıtlar.CurrentRow.Cells[4].Value.ToString() + "'", data);
                    dr = edt4.ExecuteReader();

                    dt.Load(dr);
                    row = dt.Rows[3];
                    txtTel.Text = row["Tel"].ToString();
                    dr.Close();

                    SqlCommand edt5 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE Cinsiyet='" + grdKayıtlar.CurrentRow.Cells[5].Value.ToString() + "'", data);
                    dr = edt4.ExecuteReader();

                    dt.Load(dr);
                    row = dt.Rows[4];
                    cmbCinsiyet.Text = row["Cinsiyet"].ToString();
                    dr.Close();

                    SqlCommand Duzenle6 = new SqlCommand("SELECT * FROM SatisVeRezerve WHERE ID='" + grdKayıtlar.CurrentRow.Cells[0].Value.ToString() + "'", data);
                    dr = edt4.ExecuteReader();

                    dt.Load(dr);
                    row = dt.Rows[5];
                    KoltukNo.Text = row["ID"].ToString();
                    dr.Close();
                    data.Close();              
            }

          catch
            {
                MessageBox.Show("Herhangi bir kayıt seçmendiniz.", "Hata");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        long TCKontrol;
        int BasamakToplam = 0, CiftBasamakToplam = 0, TekBasamakToplam = 0;


        public delegate bool Kontrol(int S1, int S2, long S3);

        bool TCK;

        public bool Deger(int Dogrumu, int Dogrumu2, long TC)
        {


            try
            {

                if (Dogrumu.ToString()[1] == TC.ToString()[10] && Dogrumu.ToString()[1] % 2 == 0 && Dogrumu2.ToString() == TC.ToString()[9].ToString()) // TC' No'nun rakamları toplamının birler basamağını TC No'nun birler basamağı ile karşılaştır ve TC No'nun birler basamağının tek rakam olmamasını kontrol et..
                {
                    TCK = true;
                    return true;

                }

                else
                {
                    TCK = false;
                    return false;
                }
            }

            catch (Exception)
            {

                return false;
            }


        }

        private void Sifirlabt_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtTC.Enabled = true;
            data.Open();
            SqlCommand Ara = new SqlCommand("SELECT * from SatisVeRezerve where TC like '%" + txtTC.Text + "%'", data);
            SqlDataReader dr = Ara.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            grdKayıtlar.DataSource = dt;
            data.Close();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        public void TCKMethod()
        {
            if (txtTC.Text.IndexOf("0") == 0 || txtTC.Text.Length != 11 || txtTC.Text == string.Empty) // Uzunluk 11'den eksik veya fazla ise, ilk hane 0 ise TC kimlik No Hatalıdır. 
            {
                TCK = false;

            }


            else
            {

                TCKontrol = long.Parse(txtTC.Text);

                for (int i = 0; i < TCKontrol.ToString().Length - 1; i++) // TC No'nun rakamlarının uzunluğunu birer birer indirerek, for döngüsünü döndür.
                {
                    BasamakToplam += int.Parse(txtTC.Text[i].ToString()); // TC No'nun rakamları toplamını al.
                }

                for (int i = 1; i <= 8; i += 2) // Çift basamakların toplamı.
                {
                    CiftBasamakToplam += int.Parse(txtTC.Text[i].ToString());
                }

                for (int i = 0; i <= 9; i += 2) // Tek basamakların toplamı.
                {
                    TekBasamakToplam += int.Parse(txtTC.Text[i].ToString());
                }

                int OnuncuRakam = ((TekBasamakToplam * 7) - CiftBasamakToplam) % 10; // 10. Basamağı bulmak için Tekbasamakların toplamının 7 katından çift basamakların toplamını çıkar ve 10 ile bölümünden kalanı al.

                Kontrol Temsil = new Kontrol(Deger);
                Temsil(BasamakToplam, OnuncuRakam, TCKontrol); // TC no rakamlarının toplamını ve TC No'yu temsilci parametresine yolla.               


                // Sonda değerleri sıfırla.
                BasamakToplam = 0;
                OnuncuRakam = 0;
                TekBasamakToplam = 0;
                CiftBasamakToplam = 0;

            }
        }




        private void KayitAraBt_Click(object sender, EventArgs e)
        {
            TCKMethod();
            txtTC.Enabled = true;

            if (TCK == true)
            {
                data.Close(); // Olası veritabanı açık bağlantılarını engelle.
                data.Open();
                SqlCommand Ara = new SqlCommand("SELECT * from SatisVeRezerve where TC like '%" + txtTC.Text + "%'", data);
                SqlDataReader dr = Ara.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                grdKayıtlar.DataSource = dt;
                data.Close();
            }

            else
            {
                MessageBox.Show("Geçerli bir 11 haneli TC kimlik numarası giriniz.", "Kimlik No Hatalı");
            }

            TCK = false;
        }
    }
}
