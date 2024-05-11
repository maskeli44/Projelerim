using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaProjes3
{
    internal class Yiyecek
    {
        
        public string Ad;
        public string Cins;
        public double Fiyat;
        public double KdvOran;
    

        public Yiyecek()
        {
            this.Ad = "";
            this.Cins = "";
            this.Fiyat = 0;
            this.KdvOran = 0;

        }

        public Yiyecek(string ad, string cins, double fiyat, double kdv)
        {
            this.Ad = ad;
            this.Cins = cins;
            this.Fiyat = fiyat;
            this.KdvOran = kdv;
        }

        public virtual string yazdir()
        {
            string data = string.Format("{0, -10},{1, -10}, {2,10}, {3,3}", Ad, Cins, Fiyat, KdvOran);
            return data;
        }
    }
}
