using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriDüzeyTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            BLL.OgrenciYeniKayit("Sinan", "Ozclk", "11B");
        }
    }
}
