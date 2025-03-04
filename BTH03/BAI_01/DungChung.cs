using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_01
{
    internal class DungChung
    {
        public static int UCLN(int x, int y)
        {

                x = Math.Abs(x);
                y = Math.Abs(y);
                if (y == 0) return x;
                return UCLN(y, x % y);
        }
    }
}
