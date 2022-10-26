using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonuBaris
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void TumKayitlar_Click(object sender, EventArgs e)
        {
            OtobusFirmasi.TumKayitlar Ac = new OtobusFirmasi.TumKayitlar();
            Ac.Show();
        }

        private void OzelKayitlar_Click(object sender, EventArgs e)
        {
            OtobusFirmasi.OzelKoltuklar Ac = new OtobusFirmasi.OzelKoltuklar();
            Ac.Show();
        }

        private void SeferRezervasyonVeSatis_Click(object sender, EventArgs e)
        {
            OtobusFirmasi.SvR X = new OtobusFirmasi.SvR();
            X.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtobusFirmasi.TanımlıSeferler Ac = new OtobusFirmasi.TanımlıSeferler();
            Ac.Show();
        }

        private void SeferTanimla_Click(object sender, EventArgs e)
        {
            OtobusFirmasi.SeferTanim X = new OtobusFirmasi.SeferTanim();
            X.Show();
        }
         

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otobüs Bilet Otomasyonu; Barış USLUCAN tarafından geliştirilmiştir. © 2020 www.barisuslucan.com.tr", "Hakkında");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void şifreyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreSifirlama Ac = new SifreSifirlama();
            Ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtobusTanimla Ac = new OtobusTanimla();
            Ac.Show();
        }
    }
}
