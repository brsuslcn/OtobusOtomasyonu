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
    public partial class SatisRezervasyon : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;"); 
        SqlCommand cmd = new SqlCommand();
        SqlCommand rez = new SqlCommand();
        SqlDataReader datareader;
        public string session, bus, place, date;
        public SatisRezervasyon()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "1";
            }
        }
        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "2";
            }
        }
        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "3";
            }
        }
        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "4";
            }
        }
        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "5";
            }
        }
        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "6";
            }
        }
        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "7";
            }
        }
        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "8";
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {
            if (b9.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "9";
            }
        }
        private void b10_Click(object sender, EventArgs e)
        {
            if (b10.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "10";
            }
        }
        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "11";
            }
        }
        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "12";
            }
        }
        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "13";
            }
        }
        private void b14_Click(object sender, EventArgs e)
        {
            if (b14.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "14";
            }
        }
        private void b15_Click(object sender, EventArgs e)
        {
            if (b15.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "15";
            }
        }
        private void b16_Click(object sender, EventArgs e)
        {
            if (b16.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "16";
            }
        }
        private void b17_Click(object sender, EventArgs e)
        {
            if (b17.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "17";
            }
        }
        private void b18_Click(object sender, EventArgs e)
        {
            if (b18.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "18";
            }
        }
        private void b19_Click(object sender, EventArgs e)
        {
            if (b19.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "19";
            }
        }
        private void b20_Click(object sender, EventArgs e)
        {
            if (b20.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "20";
            }
        }
        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "21";
            }
        }
        private void b22_Click(object sender, EventArgs e)
        {
            if (b22.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "22";
            }
        }
        private void b23_Click(object sender, EventArgs e)
        {
            if (b23.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "23";
            }
        }
        private void b24_Click(object sender, EventArgs e)
        {
            if (b24.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "24";
            }
        }
        private void b25_Click(object sender, EventArgs e)
        {
            if (b25.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "25";
            }
        }
        private void b26_Click(object sender, EventArgs e)
        {
            if (b26.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "26";
            }
        }
        private void b27_Click(object sender, EventArgs e)
        {
            if (b27.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "27";
            }
        }
        private void b28_Click(object sender, EventArgs e)
        {
            if (b28.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "28";
            }
        }
        private void b29_Click(object sender, EventArgs e)
        {
            if (b29.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "29";
            }
        }
        private void b30_Click(object sender, EventArgs e)
        {
            if (b30.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "30";
            }
        }
        private void b31_Click(object sender, EventArgs e)
        {
            if (b31.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "31";
            }
        }
        private void b32_Click(object sender, EventArgs e)
        {
            if (b32.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmek istediğiniz koltuk meşguldür!");
            }
            else
            {
                txtKOLTUKNO.Text = "32";
            }
        }
        public void ProgressStatus()
        {
            if (Progress == 0)
                prgDoluluk.Value = 0;

            if (Progress >= 5 && Progress <= 10)
                prgDoluluk.Value = 30;

            if (Progress >= 11 && Progress <= 15)
                prgDoluluk.Value = 45;

            if (Progress >= 16 && Progress <= 20)
                prgDoluluk.Value = 55;

            if (Progress >= 21 && Progress <= 25)
                prgDoluluk.Value = 65;

            if (Progress >= 26 && Progress <= 27)
                prgDoluluk.Value = 85;

            if (Progress >= 28 && Progress <= 31)
                prgDoluluk.Value = 95;

            if (Progress >= 32)
                prgDoluluk.Value = 100;
        }

        void ProgressCheck()
        {
            Progress = 0;

            if(b1.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b2.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b3.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b4.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b5.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b6.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b7.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b8.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b9.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b10.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b11.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b12.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b13.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b14.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b15.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b16.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b17.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b18.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b19.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b20.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b21.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b22.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b23.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b24.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b25.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b26.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b27.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b28.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b29.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b30.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b31.BackColor == Color.Red)
            {
                Progress++;
            }

            if (b32.BackColor == Color.Red)
            {
                Progress++;
            }

        }

        int Progress = 0;
        private void SatisRezervasyon_Load(object sender, EventArgs e)
        {         
            prgDoluluk.Minimum = 0;
            prgDoluluk.Maximum = 100;     
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
            label9.Text = bus.ToString();
            label11.Text = place.ToString();
            label10.Text = session.ToString();
            label13.Text = date.ToString();
            txtKOLTUKNO.Enabled = false;
            Dataread();
            DataRead2();
            txtTC.MaxLength = 11;
            txtTel.MaxLength = 10;
            ProgressCheck();
            ProgressStatus();
        }     
        string[] DoluOlan = new string[33];
        int i = 1;
        void Dataread()
        {
            Tekrar:
            SqlCommand cmd2 = new SqlCommand();     
                data.Open();
                cmd2.Connection = data;
                cmd2.CommandText = "SELECT *FROM SatisVeRezerve WHERE ID2='" + i + " " + bus + " " + place + " " + date + " " + session + "'";
                datareader = cmd2.ExecuteReader();

            if (datareader.Read())
                {
                 DoluOlan[i] = i.ToString();  
                }
            i++;
            data.Close();
                if(i<=32)
            {
                goto Tekrar;
            }
            if (DoluOlan[1] == "1")
            {
                b1.BackColor = Color.Red;
               
            }
            if (DoluOlan[2] == "2")
            {
                b2.BackColor = Color.Red;
            
            }
            if (DoluOlan[3] == "3")
            {
                b3.BackColor = Color.Red;
               
            }
            if (DoluOlan[4] == "4")
            {
                b4.BackColor = Color.Red;
             
            }
            if (DoluOlan[5] == "5")
            {
                b5.BackColor = Color.Red;
              
            }
            if (DoluOlan[6] == "6")
            {
                b6.BackColor = Color.Red;
             
            }
            if (DoluOlan[7] == "7")
            {
                b7.BackColor = Color.Red;
               
            }
            if (DoluOlan[8] == "8")
            {
                b8.BackColor = Color.Red;
             
            }
            if (DoluOlan[9] == "9")
            {
                b9.BackColor = Color.Red;
               
            }
            if (DoluOlan[10] == "10")
            {
                b10.BackColor = Color.Red;
               
            }
            if (DoluOlan[11] == "11")
            {
                b11.BackColor = Color.Red;
                
            }
            if (DoluOlan[12] == "12")
            {
                b12.BackColor = Color.Red;
               
            }
            if (DoluOlan[13] == "13")
            {
                b13.BackColor = Color.Red;
                
            }
            if (DoluOlan[14] == "14")
            {
                b14.BackColor = Color.Red;
               
            }
            if (DoluOlan[15] == "15")
            {
                b15.BackColor = Color.Red;
              
            }
            if (DoluOlan[16] == "16")
            {
                b16.BackColor = Color.Red;
               
            }
            if (DoluOlan[17] == "17")
            {
                b17.BackColor = Color.Red;
              
            }
            if (DoluOlan[18] == "18")
            {
                b18.BackColor = Color.Red;
               
            }
            if (DoluOlan[19] == "19")
            {
                b19.BackColor = Color.Red;
               
            }
            if (DoluOlan[20] == "20")
            {
                b20.BackColor = Color.Red;
                
            }
            if (DoluOlan[21] == "21")
            {
                b21.BackColor = Color.Red;
               
            }
            if (DoluOlan[22] == "22")
            {
                b22.BackColor = Color.Red;
               
            }
            if (DoluOlan[23] == "23")
            {
                b23.BackColor = Color.Red;
              
            }
            if (DoluOlan[24] == "24")
            {
                b24.BackColor = Color.Red;
                
            }
            if (DoluOlan[25] == "25")
            {
                b25.BackColor = Color.Red;
               
            }
            if (DoluOlan[26] == "26")
            {
                b26.BackColor = Color.Red;
               
            }
            if (DoluOlan[27] == "27")
            {
                b27.BackColor = Color.Red;
                
            }
            if (DoluOlan[28] == "28")
            {
                b28.BackColor = Color.Red;
               
            }
            if (DoluOlan[29] == "29")
            {
                b29.BackColor = Color.Red;
               
            }
            if (DoluOlan[30] == "30")
            {
                b30.BackColor = Color.Red;
                
            }
            if (DoluOlan[31] == "31")
            {
                b31.BackColor = Color.Red;
             
            }
            if (DoluOlan[32] == "32")
            {
                b32.BackColor = Color.Red;
               
            }
            ProgressStatus();
        }          
        void DataRead2()
        {

            i = 1;
            Tekrar:
            SqlCommand command = new SqlCommand();
            data.Open();
            command.Connection = data;
            command.CommandText = "SELECT *FROM SatisVeRezerve WHERE ID2='" + i + " " + bus + " " + place + " " + date + " " + session + " " + "Rezerve" + "'";
            datareader = command.ExecuteReader();
            if (datareader.Read())
            {
                DoluOlan[i] = i.ToString();
            }
            i++;
            data.Close();

            if (i <= 32)
            {
                goto Tekrar;
            }
            if (DoluOlan[1] == "1")
            {
                b1.BackColor = Color.Red;
               
            }
            if (DoluOlan[2] == "2")
            {
                b2.BackColor = Color.Red;
                
            }
            if (DoluOlan[3] == "3")
            {
                b3.BackColor = Color.Red;
              
            }
            if (DoluOlan[4] == "4")
            {
                b4.BackColor = Color.Red;
                
            }
            if (DoluOlan[5] == "5")
            {
                b5.BackColor = Color.Red;
               
            }
            if (DoluOlan[6] == "6")
            {
                b6.BackColor = Color.Red;
               
            }
            if (DoluOlan[7] == "7")
            {
                b7.BackColor = Color.Red;
               
            }
            if (DoluOlan[8] == "8")
            {
                b8.BackColor = Color.Red;
                
            }
            if (DoluOlan[9] == "9")
            {
                b9.BackColor = Color.Red;
             
            }
            if (DoluOlan[10] == "10")
            {
                b10.BackColor = Color.Red;
                
            }
            if (DoluOlan[11] == "11")
            {
                b11.BackColor = Color.Red;
                
            }
            if (DoluOlan[12] == "12")
            {
                b12.BackColor = Color.Red;
                
            }
            if (DoluOlan[13] == "13")
            {
                b13.BackColor = Color.Red;
               
            }
            if (DoluOlan[14] == "14")
            {
                b14.BackColor = Color.Red;
               
            }
            if (DoluOlan[15] == "15")
            {
                b15.BackColor = Color.Red;
               
            }
            if (DoluOlan[16] == "16")
            {
                b16.BackColor = Color.Red;
              
            }
            if (DoluOlan[17] == "17")
            {
                b17.BackColor = Color.Red;
                
            }
            if (DoluOlan[18] == "18")
            {
                b18.BackColor = Color.Red;
                
            }
            if (DoluOlan[19] == "19")
            {
                b19.BackColor = Color.Red;
               
            }
            if (DoluOlan[20] == "20")
            {
                b20.BackColor = Color.Red;
             
            }
            if (DoluOlan[21] == "21")
            {
                b21.BackColor = Color.Red;
              
            }
            if (DoluOlan[22] == "22")
            {
                b22.BackColor = Color.Red;
               
            }
            if (DoluOlan[23] == "23")
            {
                b23.BackColor = Color.Red;
               
            }
            if (DoluOlan[24] == "24")
            {
                b24.BackColor = Color.Red;
                
            }
            if (DoluOlan[25] == "25")
            {
                b25.BackColor = Color.Red;
                
            }
            if (DoluOlan[26] == "26")
            {
                b26.BackColor = Color.Red;
                
            }
            if (DoluOlan[27] == "27")
            {
                b27.BackColor = Color.Red;
                
            }
            if (DoluOlan[28] == "28")
            {
                b28.BackColor = Color.Red;
                
            }
            if (DoluOlan[29] == "29")
            {
                b29.BackColor = Color.Red;
               
            }
            if (DoluOlan[30] == "30")
            {
                b30.BackColor = Color.Red;
               
            }
            if (DoluOlan[31] == "31")
            {
                b31.BackColor = Color.Red;
               
            }
            if (DoluOlan[32] == "32")
            {
                b32.BackColor = Color.Red;
               
            }
            ProgressStatus();
        }
        private void button44_Click(object sender, EventArgs e)
        {
            TCKMethod();

            if (txtTC.Text != String.Empty & txtAD.Text != String.Empty & txtSOYAD.Text != String.Empty & txtTel.Text != String.Empty & txtKOLTUKNO.Text != String.Empty)
            {

                if (TCK == true)
                {

                    data.Open();
                    rez.Connection = data;
                    rez.CommandText = "Insert Into SatisVeRezerve(ID, Ad, Soyad, TC, Tel, ID2, Cinsiyet) values (@ID1, @Ad1, @Soyad1, @TC1, @Tel1, @ID2, @Cinsiyet)";
                    rez.Parameters.AddWithValue("@ID1", txtKOLTUKNO.Text);
                    rez.Parameters.AddWithValue("@Ad1", txtAD.Text);
                    rez.Parameters.AddWithValue("@Soyad1", txtSOYAD.Text);
                    rez.Parameters.AddWithValue("@TC1", txtTC.Text);
                    rez.Parameters.AddWithValue("@Tel1", txtTel.Text);
                    rez.Parameters.AddWithValue("@ID2", txtKOLTUKNO.Text + " " + bus.ToString() + " " + place.ToString() + " " + date.ToString() + " " + session.ToString() + " " + "Rezerve");
                    rez.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                    rez.ExecuteNonQuery();
                    rez.Parameters.Clear();
                    data.Close();
                    SelectedSeat();
                    Dataread();
                    DataRead2();
                    txtKOLTUKNO.Clear();
                    MessageBox.Show("Rezerve Başarılı!");
                    ProgressCheck();
                    ProgressStatus();
                }

                else
                {
                    MessageBox.Show("Lütfen geçerli bir 11 haneli kimlik numarası giriniz.", "Kimlik Numarası Hatalı");
                }

                TCK = false;
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.", "Boş Bilgi Girildi!");
            }      
        }
        private void SatisRezervasyon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        void SelectedSeat()
        {
            if (txtKOLTUKNO.Text == "1")
            {
                b1.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "2")
            {
                b2.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "3")
            {
                b3.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "4")
            {
                b4.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "5")
            {
                b5.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "6")
            {
                b6.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "7")
            {
                b7.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "8")
            {
                b8.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "9")
            {
                b9.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "10")
            {
                b10.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "11")
            {
                b11.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "12")
            {
                b12.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "13")
            {
                b13.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "14")
            {
                b14.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "15")
            {
                b15.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "16")
            {
                b16.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "17")
            {
                b17.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "18")
            {
                b18.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "19")
            {
                b19.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "20")
            {
                b20.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "21")
            {
                b21.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "22")
            {
                b22.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "23")
            {
                b23.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "24")
            {
                b24.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "25")
            {
                b25.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "26")
            {
                b26.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "27")
            {
                b27.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "28")
            {
                b28.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "29")
            {
                b29.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "30")
            {
                b30.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "31")
            {
                b31.BackColor = Color.Red;
            }
            if (txtKOLTUKNO.Text == "32")
            {
                b32.BackColor = Color.Red;
            }
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


        private void button43_Click(object sender, EventArgs e)
        {
            TCKMethod();

            if (txtTC.Text != String.Empty & txtAD.Text != String.Empty & txtSOYAD.Text != String.Empty & txtTel.Text != String.Empty & txtKOLTUKNO.Text != String.Empty)
            {
                if (TCK == true)
                {

                    data.Open();
                    cmd.Connection = data;
                    cmd.CommandText = "Insert Into SatisVeRezerve(ID, Ad, Soyad, TC, Tel, ID2, Cinsiyet) values (@ID1, @Ad1, @Soyad1, @TC1, @Tel1, @ID2, @Cinsiyet)";
                    cmd.Parameters.AddWithValue("@ID1", txtKOLTUKNO.Text);
                    cmd.Parameters.AddWithValue("@Ad1", txtAD.Text);
                    cmd.Parameters.AddWithValue("@Soyad1", txtSOYAD.Text);
                    cmd.Parameters.AddWithValue("@TC1", txtTC.Text);
                    cmd.Parameters.AddWithValue("@Tel1", txtTel.Text);
                    cmd.Parameters.AddWithValue("@ID2", txtKOLTUKNO.Text + " " + bus.ToString() + " " + place.ToString() + " " + date.ToString() + " " + session.ToString());
                    cmd.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    data.Close();
                    SelectedSeat();
                    txtKOLTUKNO.Clear();
                    MessageBox.Show("Satın Alınma Başarılı!");
                    ProgressCheck();
                    ProgressStatus();
                }

                else
                {
                    MessageBox.Show("Lütfen geçerli bir 11 haneli kimlik numarası giriniz.", "Kimlik Numarası Hatalı");
                }

                TCK = false;
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.", "Boş Bilgi Girildi!");
            }       
        }
    }
}
