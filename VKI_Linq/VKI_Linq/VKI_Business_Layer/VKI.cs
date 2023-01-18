using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKI_Business_Layer
{
    public class VKI
    {
        public string Ad;
        public string Soyad;
        public string TelNo;
        public double Boy;
        public double Kilo;
        public double VKI_Hesapla()
        {
            return Kilo/((Boy/100)*(Boy/100));
        }
        public string VKI_Stat()
        {
            double sonuc = VKI_Hesapla();
            if (sonuc < 18.49) { return "ZAYIF"; }
            else if (sonuc > 18.50 && sonuc < 24.99) { return "ZAYIF"; }
            else if (sonuc> 18.50 && sonuc< 24.99) { return "IDEAL"; }
            else if (sonuc > 25 && sonuc < 29.99) { return "HAFİF KİLOLU"; }
            else if (sonuc > 30) { return "OBEZ"; }
            else { return "DIĞRER"; }
        }

    }
}
