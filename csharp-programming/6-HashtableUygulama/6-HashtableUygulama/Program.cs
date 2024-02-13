using System;
using System.Collections;

namespace _6_HashtableUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable içerisine ENG  - TR olarak data eklemeniz. 
            /*
             * Yeni kayıt eklemek istiyormusunuz E/H
             * E : Yeni kayıt ekleme işlemi devam etsin, 
             * H : Tüm listeyi yazdırın. 
             * 
             * Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden ... şeklinde sistemimizde bulunmaktadır. 
             * 
             */

            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız");
                Console.Write("EN :");
                string eng = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey(eng);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır. {1} değerin türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} ingilizce değerin türkçe karşılığını yazınız", eng);
                    string tr = Console.ReadLine();
                    sozlukVeriTabani.Add(eng, tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı");
                }

                Console.WriteLine("Yeni değer eklemek istiyor musunuz ? ( E/H ) ");
            }
            while (Console.ReadLine().ToUpper() != "H");

            // 1 : yöntem :
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = TR : {1}", item, sozlukVeriTabani[item]);
            }

            // 2.Yöntem 

            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                // Console.WriteLine(item.GetType().Name);
                Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
            }
        }
    }
}
