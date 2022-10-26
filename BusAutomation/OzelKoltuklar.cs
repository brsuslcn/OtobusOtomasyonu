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
using System.Data.OleDb;

namespace OtobusFirmasi
{
    public partial class OzelKoltuklar : Form
    {
        SqlConnection data = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Otobus.mdf;Integrated Security=True;");
        SqlDataAdapter Adtr;
        DataTable datatbl = new DataTable();
        public OzelKoltuklar()
        {
            InitializeComponent();
        }
        void Search()
        {
            Adtr = new SqlDataAdapter("SELECT *FROM SatisVeRezerve WHERE ID2 Like '%" + "Rezerve" + "%'", data);
            Adtr.Fill(datatbl);
            grdKoltuklar.DataSource = datatbl;
        }
        private void OzelKoltuklar_Load(object sender, EventArgs e)
        {
            Search();
            txtTC.MaxLength = 11;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                data.Open();
                SqlCommand del = new SqlCommand("DELETE FROM SatisVeRezerve WHERE ID='" + grdKoltuklar.CurrentRow.Cells[0].Value.ToString() + "'", data);
                del.ExecuteNonQuery();
                data.Close();
                datatbl.Clear();
                Search();
            }

            catch
            {
                MessageBox.Show("Herhangi bir rezerve seçmediniz.", "Hata");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            data.Open();
            SqlCommand Ara = new SqlCommand("SELECT * from SatisVeRezerve where TC like '%" + txtTC.Text + "%'", data);
            SqlDataReader dr = Ara.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            grdKoltuklar.DataSource = dt;
            data.Close();
        }
    }
}
