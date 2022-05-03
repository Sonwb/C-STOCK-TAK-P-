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
using System.Data.SqlClient;

namespace Stock_Kontrol
{
    public partial class Stock_ekle : Form
    {
        public Stock_ekle()
        {
            InitializeComponent();
        }

        public static int deger=1000;
        public static int deger1 = 0;
 
       public static urunekle[] stocklar = new urunekle[deger];





        private void Stock_ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
   
        }

        private void Stock_ekle_Load(object sender, EventArgs e)
        {

        }
        connet con =new connet();   
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_barkod.Text == "" || txt_aciklama.Text == "" || txt_ad.Text == "" || txt_adet.Text == "" || txt_fiyat.Text == "")
            {
                MessageBox.Show("boş Geçemezsin");
            }
            else
            {
                con.connopen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.conn;
                cmd.CommandText = "INSERT INTO product (barcode,product_name,product_detail,product_money,product_piece) VALUES(@barcode,@product_name,@product_detail,@product_money,@product_piece)";
                cmd.Parameters.AddWithValue("@barcode", txt_barkod.Text.ToString());
                cmd.Parameters.AddWithValue("@product_name", txt_ad.Text);
                cmd.Parameters.AddWithValue("@product_detail", txt_aciklama.Text);
                cmd.Parameters.AddWithValue("@product_money", txt_fiyat.Text);
                cmd.Parameters.AddWithValue("@product_piece", txt_adet.Text);
                cmd.ExecuteNonQuery();  
                con.connclose();
                MessageBox.Show("Eklendi");
           
            }


        

        }
    }
}
