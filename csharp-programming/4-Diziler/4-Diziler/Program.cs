using System;

namespace _4_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            // Nasıl değer ekleyebiliriz. 
            // 1 2 3 4 ... 10 
            // 0 1 2 3 4 5 6 7 8 9 10
            /*
             * 5 elemanlı bir dizi oluşturuduğum zaman 
             * 
             * [0]
             * [1]
             */

            ogrenciIsimListesi[0] = "Name1 Surname1";
            ogrenciIsimListesi[1] = "Name2 Surname2";
            ogrenciIsimListesi[2] = "Name3 Surname3";
            ogrenciIsimListesi[3] = "Name4 Surname4";
            ogrenciIsimListesi[4] = "Name5 Surname5";

            // Console.WriteLine(ogrenciIsimListesi[1]);

            #region oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım. 
            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }

            Console.Clear();

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsim);
            }
            #endregion
            Console.Clear();
        }
    }
}
