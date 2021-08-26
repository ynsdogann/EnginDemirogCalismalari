using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILogerServices> logerServices)
        {
            // Başvuru bilgilerini değerlendirme

          
            krediManager.Hesapla();
            foreach (var loger in logerServices)
            {
                loger.logla();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
            }
        }
    }
}
