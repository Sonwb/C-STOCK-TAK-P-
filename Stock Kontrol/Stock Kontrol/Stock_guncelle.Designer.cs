
namespace Stock_Kontrol
{
    partial class Stock_guncelle
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_tara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(128, 415);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(140, 46);
            this.btn_ekle.TabIndex = 15;
            this.btn_ekle.Text = "Güncelle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(208, 352);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 20);
            this.txt_adet.TabIndex = 10;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(208, 304);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 11;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(208, 252);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(100, 20);
            this.txt_aciklama.TabIndex = 12;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(208, 187);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 13;
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(208, 141);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(100, 20);
            this.txt_barkod.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 15F);
            this.label5.Location = new System.Drawing.Point(66, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 15F);
            this.label4.Location = new System.Drawing.Point(64, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 15F);
            this.label3.Location = new System.Drawing.Point(64, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 15F);
            this.label2.Location = new System.Drawing.Point(66, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Ad";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe Fluent Icons", 15F);
            this.lbl.Location = new System.Drawing.Point(64, 142);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 20);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Ürün Barkod";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Tomato;
            this.lbl1.Location = new System.Drawing.Point(83, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(242, 39);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Stok Güncelle";
            // 
            // btn_tara
            // 
            this.btn_tara.Location = new System.Drawing.Point(330, 140);
            this.btn_tara.Name = "btn_tara";
            this.btn_tara.Size = new System.Drawing.Size(75, 23);
            this.btn_tara.TabIndex = 16;
            this.btn_tara.Text = "Tara";
            this.btn_tara.UseVisualStyleBackColor = true;
            this.btn_tara.Click += new System.EventHandler(this.btn_tara_Click);
            // 
            // Stock_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 521);
            this.Controls.Add(this.btn_tara);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl1);
            this.Name = "Stock_guncelle";
            this.Text = "Stock_guncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_guncelle_FormClosing);
            this.Load += new System.EventHandler(this.Stock_guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_tara;
    }
}