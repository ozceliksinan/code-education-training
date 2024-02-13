using System;
using System.Collections.Generic;
using System.Text;

namespace _28__Hata_Yönetimi_Try_Catch
{
    public class OzelHataSinifi:Exception
    {
        public OzelHataSinifi()
        {
            Console.WriteLine("Ozel Hata Sınıfı Oluştu");
        }
    }
}