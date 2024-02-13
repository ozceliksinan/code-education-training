using System;
using System.Collections;

namespace _5_KoleksiyonlarGiriş
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[10]; // 10 elemanlı bir dizi oluşturuldu (string tipinde)

            // ArrayList .Net içerisinde bulunan bir kütüphanedeki sınıftır.
            ArrayList A1 = new ArrayList();

            #region Tek değer ekleme
            // Add komutu ile tek tek değer eklenebilir.
            A1.Add("Sinan Deneme");
            A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme işlemi
            ArrayList A2 = new ArrayList();
            A2.Add("Deneme");
            A2.Add("Deneme Yazısı");
            A2.Add("Deneme 2");

            // AddRange ile başka bir ArrayList dizisindeki değerleri sonuna ekler.
            A1.AddRange(A2);
            #endregion

            #region Koleksiyonlarda Capacity & Count İncelemesi
            // ArrayList.Capacity : Capacity komutu ArrayList içindeki ayrılan yer alanıdır. 4'lü sıra halinde boyut artışı yapar.
            // ArrayList.Count : Count komutu ArrayList içindeki dizi index değerlerini tutan komut görevidir.
            int counter = 0;
            int capacity = 0;

            counter = A1.Count;
            capacity = A1.Capacity;

            Console.WriteLine("A1 ArrayListin kapasitesi: " + capacity);
            Console.WriteLine("A1 ArrayListin counter degeri: " + counter);
            #endregion

            #region Koleksiyonların içindeki değerlere ulaşmak
            // Koleksiyonlardaki değerlere ulaşmak için sıradan bir değişken tanımlayıp
            // verileri değişkene atama işlemi yapılır. Önemli nokta ise tip dönüşümlerinin
            // düzgün yapılması çok önemlidir.
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            //int I1 = (int)A1[4]; 
            // Hata verir bu satır. Çünkü string bir veri tipi int değişkene atanmaya çalışılıyor. Bilinçsiz bir tür dönüşümü yapılmış olundu.
            int I1 = (int)A1[1];

            A1[3] = "Yeniden Düzenlendi"; // Bu satırda ArrayList içindeki değer sonradan değiştirildi.
            #endregion

            #region Koleksiyonlarda Sıralama işlemleri
            // Dizinin mevcut elemanlarını ters olarak sıralama işlemi
            A1.Reverse();

            // A-Z Sıralama İşlemi
            A1.Sort();
            // Bu programda hata verir çünkü int veri tipi vardır. String veri tipi ile karşılaştıramadığı için hata verir.
            #endregion

            #region Koleksiyonlarda yardımcı komutlar
            // ArrayList içindeki aradığımız değerin var olup olmadığını öğrenmek için Contains kullanılır
            bool Kontrol1 = A1.Contains("Deneme"); // Bulursa true, bulamazsa false döndürür.
            bool Kontrol2 = A1.Contains(200); // False Döndürür!!

            // Indexof: Dizide arama yapar ve bulduğu index değerini belirtilen değişkene atama işlemi yapar.
            // Aşağıdaki modülde ArrayList içinde değer araması yapar. Değer var ise index değerini eşleştirir
            // ve silme işlemini gerçekleştirir.
            if (A1.Contains("Deneme 2"))
            {
                int indexDegeri = A1.IndexOf("Deneme 2");
                A1.RemoveAt(indexDegeri);
            }

            // ArrayList içindeki değerleri diziye aktarmak için aşağıdaki yöntem kullanılır.
            object[] yeniDizi = A1.ToArray();

            // Clear: ArrayList içindeki ne kadar değer varsa hepsini silme işlemi yapar. Count sıfırlanır
            // ama capacity kısmı sıfırlanmaz. Önceden ne kadar veri varsa (4'lü sıra halde) bu veri halen
            // korunur.
            A1.Clear();

            // TrimToSize(): İlgili koleksiyonun size boyutunu yeniden ayarlar. 
            // İlgili ArrayListin ilk oluşturulduğu zamanki capacity değerine döndürür.
            A1.TrimToSize();

            #endregion

            #region ArrayList koleksiyonundan değerleri silmek
            // ArrayList içindeki verilen değeri bulur ve direkt olarak index'i siler.
            A1.Remove("Yeniden Düzenlendi");

            // RemoveRange(Başlangıç_indeks, Bitiş_indeks): Girilen indeks değer aralıklarını siler.
            A1.RemoveRange(2, 2);

            // RemoveAt(indeks_degeri): İlgili indeks değerini direkt olarak siler.
            A1.RemoveAt(2);
            #endregion

            /*********************************************************************************************/
            /*                      ARRAY LİST BASİT UYGULAMA YAPALIM                                    */
            /*********************************************************************************************/
            Console.Clear();
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz: ");
                kullaniciSecim = Console.ReadLine();

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğiniz değeri giriniz : ");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Değeriniz Bulundu : index sırası :{0} - Değer : {1}", bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız kriterlerde bir deger bulunamadı");
                            // Eğer aradığı kriterde değer bulamadı ise kullanıcıya bu değeri listeye ekleyelim mi olarak sorun eger kullanıcı E derse listeye ekleyin. 
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":

                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz", kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer liste içerisinde bulunamadı");
                        }

                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "5":
                        Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();

                        if (kullaniciSilCevap.ToUpper() == "E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("Değeriniz Silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
                            }
                        }

                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim != "6");

            /*********************************************************************************************/
            /*                      HASH TABLE YAPISINA GÖZ ATALIM                                       */
            /*********************************************************************************************/

            // Hashtable sözlükler gibi düşünülebilir. Key ve value ister bizden.
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
