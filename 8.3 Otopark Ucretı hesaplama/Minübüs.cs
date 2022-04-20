using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Otopark_Ucretı_hesaplama
{
    class Minübüs
    {
        public double ücret;
        public double Hesapla3(double saat)
        {
            if (saat == 0 && saat < 2)
            {
                ücret = 8;
            }
            else if (saat >= 2 && saat < 6)
            {
                ücret = 16;
            }
            else if (saat >= 6 && saat < 12)
            {
                ücret = 32;
            }
            else if (saat >= 12 && saat <= 24)
            {
                ücret = 45;
            }
            else
            {
                ücret = 45 + 25 * (saat / 24);
            }

            return ücret;

        }
    }
}
