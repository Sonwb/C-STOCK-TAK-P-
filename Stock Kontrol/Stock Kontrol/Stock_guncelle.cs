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
    public partial class Stock_guncelle : Form
    {
        static int indisdeger;
        public Stock_guncelle()
        {
            InitializeComponent();
        }

        private void Stock_guncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
       
        }

        private void Stock_guncelle_Load(object sender, EventArgs e)
        {

        }
        connet con = new connet();
        private void btn_tara_Click(object sender, EventArgs e)
        {
            if (txt_barkod.Text=="")
            {
                MessageBox.Show("Boş Geçilemez..");
            }
            else
            {
          
                con.connopen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.conn;
                cmd.CommandText = "SELECT * FROM  product  WHERE  barcode = '" + txt_barkod.Text.ToString() + "'";



                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    txt_barkod.Text = data["barcode"].ToString();
                    txt_ad.Text = data["product_name"].ToString();
                    txt_aciklama.Text = data["product_detail"].ToString();
                    txt_fiyat.Text = data["product_money"].ToString();
                    txt_adet.Text = data["product_piece"].ToString();
                }
                con.connclose();
            }
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_barkod.Text == "" || txt_aciklama.Text == "" || txt_ad.Text == "" || txt_adet.Text == "" || txt_fiyat.Text == "")
            {
                MessageBox.Show("Boş Geçilemez..");
            }
            else
            {
                con.connopen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.conn;
                cmd.CommandText = "UPDATE  product SET barcode=@barcode , product_name=@product_name , product_detail=@product_detail , product_money=@product_money , product_piece=@product_piece WHERE  barcode = '" + txt_barkod.Text.ToString()+"'";
                cmd.Parameters.AddWithValue("@barcode", txt_barkod.Text.ToString());
                cmd.Parameters.AddWithValue("@product_name", txt_ad.Text);
                cmd.Parameters.AddWithValue("@product_detail", txt_aciklama.Text);
                cmd.Parameters.AddWithValue("@product_money", txt_fiyat.Text);
                cmd.Parameters.AddWithValue("@product_piece", txt_adet.Text);
                cmd.ExecuteNonQuery();
                con.connclose();
                MessageBox.Show("Ürün Güncellendi.");
            }

        }
    }
}
