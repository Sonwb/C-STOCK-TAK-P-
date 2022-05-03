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

namespace Stock_Kontrol
{
    public partial class Stocklar : Form
    {
        

        public Stocklar()
        {
            InitializeComponent();
        }

        private void Stocklar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
          
        }
        connet con =new connet();
        private void Stocklar_Load(object sender, EventArgs e)
        {


      
          DataTable chart = new DataTable();

            SqlDataAdapter data = new SqlDataAdapter("SELECT* FROM product", con.conn);

            data.Fill(chart);

            dataGridView1.DataSource= chart; 
         


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.connopen();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.conn;
            cmd.CommandText = "INSERT INTO product VALUES(@barcode,@product_name,@product_detail,@product_money,@product_piece)";
            

            con.connclose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
