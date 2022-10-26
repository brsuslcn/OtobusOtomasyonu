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


namespace OtobusFirmasi
{
    public partial class SeferTanim : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
       
        public SeferTanim()
        {
            InitializeComponent();
        }

        void Otobusler()
        {
            cmbOtoTip.Items.Clear();
            SqlDataAdapter adapter;
            DataSet DSet = new DataSet();

            adapter = new SqlDataAdapter("SELECT *From Otobus", data);
            adapter.Fill(DSet);

            foreach(DataRow Drow in DSet.Tables[0].Rows)
            {
                cmbOtoTip.Items.Add(Drow[0]);
            }

        }
       
        private void SeferTanim_Load(object sender, EventArgs e)
        {

            Otobusler();
            DTime1.MinDate = DateTime.Now;
            DTime1.Format = DateTimePickerFormat.Custom;
            DTime1.CustomFormat = "d/MM/yyyy";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBaslaBit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeferTbt_Click(object sender, EventArgs e)
        {

            bool Check = true;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr;


            data.Open();
            cmd2.Connection = data;
            cmd2.CommandText = "SELECT * FROM Arac where Plaka='" + cmbOtoTip.Text + "'";
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



            if (cmbBaslaBit.SelectedIndex != -1 && cmbOtoTip.SelectedIndex != -1 && cmbSeans.SelectedIndex != -1 && cmbDurakBit.SelectedIndex != -1)
            {
                if (Check == false)
                {

                    data.Open();
                    cmd.Connection = data;
                    cmd.CommandText = "Insert Into Arac(Seans, Plaka, Adres, IDP, Tarih) values (@Seans1, @Plaka1, @Adres1, @IDP1, @Tarih1)";
                    cmd.Parameters.AddWithValue("@Seans1", cmbSeans.Text);
                    cmd.Parameters.AddWithValue("@Plaka1", cmbOtoTip.Text);
                    cmd.Parameters.AddWithValue("@Adres1", cmbBaslaBit.Text + " - " + cmbDurakBit.Text);
                    cmd.Parameters.AddWithValue("@Tarih1", DTime1.Text);
                    cmd.Parameters.AddWithValue("@IDP1", cmbBaslaBit.Text + " - " + cmbDurakBit.Text + " - "  + DTime1.Text + " - "  + cmbSeans.Text + " - " + cmbOtoTip.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Tanımlama Başarılı!", "İşlem Gerçekleştirildi");
                    data.Close();
                }

                else
                {

                    DialogResult EvetHayir = new DialogResult();
                    EvetHayir = MessageBox.Show("Seçtiğiniz otobüs için zaten bir sefer tanımlıdır. Sefer Düzenleme Panelinden ilgili aracın seferini düzenleyip kaldırabilirsiniz. Sefer Düzenleme Panelini görmek ister misiniz?", "Araç Zaten Seferde", MessageBoxButtons.YesNo);

                    if(EvetHayir == DialogResult.Yes)
                    {
                       TanımlıSeferler Ac = new TanımlıSeferler();
                        Ac.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Eksiksiz Doldurunuz!", "Hata");
            }
        }
    }
}
