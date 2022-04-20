using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Otopark_Ucretı_hesaplama
{
    class Otomobil
    {
        public double ücret;
        public double Hesapla(double saat) 
        {
            if (saat==0&&saat<2)
            {
                ücret = 5;
            }
            else if (saat>=2&&saat<6)
            {
                ücret = 10;
            }
            else if (saat >= 6 && saat < 12)
            {
                ücret = 20;
            }
            else if (saat >= 12 && saat <= 24)
            {
                ücret = 24;
            }
            else
            {
                ücret = 24 + 20 * (saat / 24);
            }
            
            return ücret;
        
        }

    }
}
