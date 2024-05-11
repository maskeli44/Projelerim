using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaProjes3
{
    internal class Salata:Yiyecek
    {
        public double Kalori;
        public Salata() : base()
        {
            Kalori = 0;
        }

        public Salata(string ad, string cins, double fiyat, double kdv, double kalori)
            : base(ad, cins, fiyat, kdv)
        {
            Kalori = kalori;
        }
        public override string yazdir()
        {
            string data = string.Format("{0,-10}{1,-10}{2,10}{3,3}{4,4}", Ad, Cins, Fiyat, KdvOran, Kalori);
            return data;
        }
    }

}
