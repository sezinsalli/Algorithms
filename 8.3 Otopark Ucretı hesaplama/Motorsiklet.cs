using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Otopark_Ucretı_hesaplama
{
    class Motorsiklet

        
    {
        public double ücret;

        public double Hesapla2(double saat)
        {
            if (saat == 0 && saat < 2)
            {
                ücret = 0;
            }
            else if (saat >= 2 && saat < 6)
            {
                ücret = 3;
            }
            else if (saat >= 6 && saat < 12)
            {
                ücret = 6;
            }
            else if (saat >= 12 && saat <= 24)
            {
                ücret = 12;
            }
            else
            {
                ücret = 24 + 10 * (saat / 24);
            }

            return ücret;

        }
    }
}
