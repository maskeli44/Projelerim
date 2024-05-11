using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaProjes3
{
    internal class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();

        public void YemekEkle(Yiyecek yiyecek)
        {
            liste.Add(yiyecek);
        }

        public void YemekSil(int index)
        {
            if (index >= 0)
            {
                liste.RemoveAt(index);
            }
        }
        public List<Yiyecek> SiparisYazdir()
        { return liste; }
    }
}
