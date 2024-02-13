using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _18_Kalıtım_Uygulaması
{
    public static class sanalDatabase
    {
        private static ArrayList db = new ArrayList();
        public static void yeniUrunEkle(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;
            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseClass bc = (baseClass)db[i];
                    if (bc.barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }
    }
}
