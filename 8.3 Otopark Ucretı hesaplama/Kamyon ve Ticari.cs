using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Otopark_Ucretı_hesaplama
{
    class Kamyon
    {
        public double ücret;
        public double Hesapla4(double saat)
        {
            if (saat == 0 && saat < 2)
            {
                ücret = 15;
            }
            else if (saat >= 2 && saat < 6)
            {
                ücret = 30;
            }
            else if (saat >= 6 && saat < 12)
            {
                ücret = 60;
            }
            else if (saat >= 12 && saat <= 24)
            {
                ücret = 100;
            }
            else
            {
                ücret = 24 + 55 * (saat / 24);
            }

            return ücret;

        }
    }
}
