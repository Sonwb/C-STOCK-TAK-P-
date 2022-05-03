using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Kontrol
{
   
    public class urunekle
    {

        public string barkod;
        public string u_ad;
        public string u_aciklama;
        public int fiyat;
        public int adet;

        public  urunekle(string barkod, string u_ad, string u_aciklama, int fiyat, int adet)
        {
            this.barkod = barkod;
            this.u_ad = u_ad;
            this.u_aciklama = u_aciklama;
            this.fiyat = fiyat;
            this.adet = adet;


        }


    }

}
