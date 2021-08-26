using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate Tuzel müşteri demek
    class TuzelMusteri:Musteri // Bu olaya miras diyoruz. inheritance : musteri dıyerek 
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
