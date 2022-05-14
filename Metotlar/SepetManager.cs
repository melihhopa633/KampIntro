using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // naming convention
        public void Ekle(Product tugba)
        {
            
            Console.WriteLine("Tebrikler Sepete eklendi : " + tugba.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }
    }
}
