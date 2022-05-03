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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        connet con = new connet();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kulanici.Text==""||txt_sifre.Text=="")
            {
                MessageBox.Show("Boş Geçilmez !!");
            }
            else {
     
                 
                    con.connopen();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = con.conn;

                    cmd.CommandText = "SELECT * FROM user_login WHERE user_name='"+ txt_kulanici.Text.ToString() + "' or user_password='" + txt_sifre.Text.ToString() + "'";


                   SqlDataReader data = cmd.ExecuteReader();

             
                if (data.Read()==true)
                {
                    
                    this.Hide();
                    ana_sayfa a = new ana_sayfa();
                    a.Show();
                    con.connclose();
                    txt_kulanici.Clear();
                    txt_sifre.Clear();
                }
         
               else
                 {
                    con.connclose();
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı Lütfen Tekrar Deneyin..");
                 }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Programdan Çıkmak istediğinize emin misiniz ?", " Uyarı !", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {

                    Environment.Exit(0);

                  

           

            }

            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
           
        }
    }
}
