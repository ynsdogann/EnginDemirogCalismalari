using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //name Convertion : isimlendirme kuralı
        public void ekle(Urun urun) //Normal parantez gorursek orada methot vardır.parantez içi paremetredir.
        {
            Console.WriteLine("Sepete Eklendi : " + "Urun Adı:"+ urun.Adi + ", "+ "Fiyatı:"+ urun.Fiyati+", " + " Açıklama: "+urun.Aciklama);
            Console.WriteLine();
        }

        //Encapsulation olayı
        public void Ekle2(string urunAdi,string aciklama,double fiyat, int stokadeti)
        {
            Console.WriteLine("Sepete Eklendi : " + "Urun Adı:" + urunAdi);
        }
    }
}
