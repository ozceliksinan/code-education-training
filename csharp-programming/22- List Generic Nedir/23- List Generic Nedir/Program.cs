using System;
using System.Collections;
using System.Collections.Generic;

namespace _23__List_Generic_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList ) Generic versiyonu 

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            // <T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek . 

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            //listeGeneric.Add("uc");

            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Sinan");
            isimler.Add("Deneme");
            isimler.Add("İsim");
            //isimler.Add(123);

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            List<musteri> musteriListe = new List<musteri>();
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "Sinan",
                soyisim = "Deneme"
            });

            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }

            /******************************************************************/
            /*                          2. KISIM                              */
            /******************************************************************/

            // Generic olmayan koleksiyon davranışı... 
            Hashtable HTList = new Hashtable();
            HTList.Add(1, "Bir");
            HTList.Add(2, "İki");
            HTList.Add(3, true);
            //HTList.Add(1, "Test");

            // Dictionary<TKey,TValue> 

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3, "Üç");
            //DictionaryList.Add(1, "Test");

            bool silmeSonuc = DictionaryList.Remove(1);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Aranana değer liste içerisinde bulunamadı silme işlemi başarısız.");
            }


            bool arananDegerSonuc = DictionaryList.ContainsKey(1);
            if (arananDegerSonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen Değer";
                DictionaryList[1] = gelenDeger;
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı");
            }

            bool arananDeger = DictionaryList.ContainsValue("Üç");
            if (arananDeger)
            {
                Console.WriteLine("Aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı");
            }

            foreach (KeyValuePair<int, string> item in DictionaryList)
            {
                Console.WriteLine("Anahatar : {0} || Değer : {1}", item.Key, item.Value);
            }

            DictionaryList.Clear();

            SortedList<int, string> sortedListKoleksiyon = new SortedList<int, string>();

            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50, "Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");
        }
    }
}
