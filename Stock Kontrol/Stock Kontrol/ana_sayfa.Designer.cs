
namespace Stock_Kontrol
{
    partial class ana_sayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_stock_ekle = new System.Windows.Forms.Button();
            this.btn_stocklar = new System.Windows.Forms.Button();
            this.btn_uygulama_kapat = new System.Windows.Forms.Button();
            this.btn_stock_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stock_ekle
            // 
            this.btn_stock_ekle.BackColor = System.Drawing.Color.Green;
            this.btn_stock_ekle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_stock_ekle.Location = new System.Drawing.Point(32, 47);
            this.btn_stock_ekle.Name = "btn_stock_ekle";
            this.btn_stock_ekle.Size = new System.Drawing.Size(145, 84);
            this.btn_stock_ekle.TabIndex = 0;
            this.btn_stock_ekle.Text = "Stock Ekle";
            this.btn_stock_ekle.UseVisualStyleBackColor = false;
            this.btn_stock_ekle.Click += new System.EventHandler(this.btn_stock_ekle_Click);
            // 
            // btn_stocklar
            // 
            this.btn_stocklar.BackColor = System.Drawing.Color.Tomato;
            this.btn_stocklar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_stocklar.Location = new System.Drawing.Point(212, 47);
            this.btn_stocklar.Name = "btn_stocklar";
            this.btn_stocklar.Size = new System.Drawing.Size(145, 84);
            this.btn_stocklar.TabIndex = 0;
            this.btn_stocklar.Text = "Stocklar";
            this.btn_stocklar.UseVisualStyleBackColor = false;
            this.btn_stocklar.Click += new System.EventHandler(this.btn_stocklar_Click);
            // 
            // btn_uygulama_kapat
            // 
            this.btn_uygulama_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_uygulama_kapat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uygulama_kapat.Location = new System.Drawing.Point(212, 166);
            this.btn_uygulama_kapat.Name = "btn_uygulama_kapat";
            this.btn_uygulama_kapat.Size = new System.Drawing.Size(145, 84);
            this.btn_uygulama_kapat.TabIndex = 0;
            this.btn_uygulama_kapat.Text = "Kullanıcı Çıkış";
            this.btn_uygulama_kapat.UseVisualStyleBackColor = false;
            this.btn_uygulama_kapat.Click += new System.EventHandler(this.btn_uygulama_kapat_Click);
            // 
            // btn_stock_guncelle
            // 
            this.btn_stock_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_stock_guncelle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_stock_guncelle.Location = new System.Drawing.Point(32, 166);
            this.btn_stock_guncelle.Name = "btn_stock_guncelle";
            this.btn_stock_guncelle.Size = new System.Drawing.Size(145, 84);
            this.btn_stock_guncelle.TabIndex = 0;
            this.btn_stock_guncelle.Text = "Stock Güncelle";
            this.btn_stock_guncelle.UseVisualStyleBackColor = false;
            this.btn_stock_guncelle.Click += new System.EventHandler(this.btn_stock_guncelle_Click);
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 277);
            this.Controls.Add(this.btn_stock_guncelle);
            this.Controls.Add(this.btn_uygulama_kapat);
            this.Controls.Add(this.btn_stocklar);
            this.Controls.Add(this.btn_stock_ekle);
            this.Name = "ana_sayfa";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stock_ekle;
        private System.Windows.Forms.Button btn_stocklar;
        private System.Windows.Forms.Button btn_uygulama_kapat;
        private System.Windows.Forms.Button btn_stock_guncelle;
    }
}