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
    

    public partial class SvR : Form
    {       
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;");
        SatisRezervasyon orn = new SatisRezervasyon();

  
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void SvR_Load(object sender, EventArgs e)
        {
            data.Open();

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/MM/yyyy";
        }
        public SvR()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            data.Close();
            data.Open();
            SqlCommand Ara = new SqlCommand("SELECT * from Arac where IDP like '%" + comboBox1.Text + " - " + comboBox2.Text + " - " + dateTimePicker1.Text + "%'", data);
            SqlDataReader dr = Ara.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            grdTanımlı.DataSource = dt;
            data.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {


                data.Close();
                data.Open();
                SqlCommand edt1 = new SqlCommand("SELECT *FROM Arac WHERE Seans='" + grdTanımlı.CurrentRow.Cells[0].Value.ToString() + "'", data);
                SqlDataReader dr = edt1.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                DataRow row = dt.Rows[0];
                label7.Text = row["Seans"].ToString();
                dr.Close();
                label6.Text = grdTanımlı.CurrentRow.Cells[1].Value.ToString();
                dr.Close();


                SqlCommand edt3 = new SqlCommand("SELECT * FROM Otobus WHERE OPlaka=@OPlaka1", data);
                edt3.Connection = data;
                edt3.Parameters.AddWithValue("@Oplaka1", grdTanımlı.CurrentRow.Cells[1].Value.ToString());
                SqlDataReader dr2 = edt3.ExecuteReader();

                if(dr2.Read())
                {
                    label12.Text = dr2["OModel"].ToString();
                    label13.Text = dr2["KoltukS"].ToString();
                    label14.Text = dr2["Wifi"].ToString();
                    label15.Text = dr2["EkranSarjS"].ToString();
                }
                

                data.Close();
            }

            catch
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!", "Sefer Seçilmedi");
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {            
                   
         try
            {


                if (label13.Text == "2+2")
                {
                    orn.place = grdTanımlı.CurrentRow.Cells[2].Value.ToString();
                    orn.bus = grdTanımlı.CurrentRow.Cells[1].Value.ToString();
                    orn.date = grdTanımlı.CurrentRow.Cells[4].Value.ToString();
                    orn.session = grdTanımlı.CurrentRow.Cells[0].Value.ToString();
                    orn.ShowDialog();

                }

               else if(label13.Text == "2+1")
                {
                    OtobusOtomasyonuBaris.SatisVeRezervasyon2 Ac = new OtobusOtomasyonuBaris.SatisVeRezervasyon2();
                    Ac.place = grdTanımlı.CurrentRow.Cells[2].Value.ToString();
                    Ac.bus = grdTanımlı.CurrentRow.Cells[1].Value.ToString();
                    Ac.date = grdTanımlı.CurrentRow.Cells[4].Value.ToString();
                    Ac.session = grdTanımlı.CurrentRow.Cells[0].Value.ToString();

                    Ac.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Lütfen bir tane seferi işleme alınız!", "Sefer İşleme Alınmadı");
                }
                   
                                       
            }
            catch
            {
                MessageBox.Show("Lütfen bir tane seferi işleme alınız!", "Sefer İşleme Alınmadı");
            
            }     
        }
    }
}
