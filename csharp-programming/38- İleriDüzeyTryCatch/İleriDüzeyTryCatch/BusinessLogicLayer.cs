using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriDüzeyTryCatch
{
    class BusinessLogicLayer
    {
        //DataAccessLayer dal;
        DataAccessLayer_II dal;
        public BusinessLogicLayer()
        {
            //dal = new DataAccessLayer();
            dal = new DataAccessLayer_II();
        }

        public int OgrenciYeniKayit(string isim, string soyisim, string sinif)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = isim;
            ogrenci1.Soyisim = soyisim;
            ogrenci1.Sinif = sinif;
            return dal.OgrenciYeniKayit(ogrenci1);
        }
    }
}
