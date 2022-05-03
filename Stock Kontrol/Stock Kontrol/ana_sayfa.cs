using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Kontrol
{
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form a = Application.OpenForms["giris"];
            a.Show();
        }

        private void btn_stock_ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_ekle b = new Stock_ekle();
            b.Show();
        }

        private void btn_stocklar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stocklar c = new Stocklar();
            c.Show();
        }

        private void btn_stock_guncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_guncelle d = new Stock_guncelle();
            d.Show();
        }

        private void btn_uygulama_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form a = Application.OpenForms["giris"];
            a.Show();
        }
    }
}
