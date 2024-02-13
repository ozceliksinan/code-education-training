using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWinForm
{
    public class DataIslemleri
    {
        public DataIslemleri()
        {

        }

        public List<Personel> personelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();

            int id = 0;
            for (int i = 0; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.id = id++;
                personel.isim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.emailAdres = personel.isim + "." + personel.soyisim + "@" + personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCountry();
                personelListe.Add(personel);
            }

            return personelListe;
        }

        public void PersonelKaydet(string path, List<Personel> personelListesi)
        {
            DirectoryInfo ulkeBilgisi = null;
            for (int i = 0; i <= personelListesi.Count; i++)
            {
                if (Directory.Exists(path + "\\" + personelListesi[i].ulke))
                {
                    ulkeBilgisi = new DirectoryInfo(path + "\\" + personelListesi[i].ulke);
                }
                else
                {
                    ulkeBilgisi = Directory.CreateDirectory(path + "\\" + personelListesi[i].ulke);
                }

                FileStream fs = File.Create(ulkeBilgisi.FullName +"\\"+ personelListesi[i].isim + "." + personelListesi[i].soyisim + ".txt");
                byte[] personelBilgi = new UTF8Encoding(true).GetBytes(personelListesi[i].personelBilgiGetir());
                fs.Write(personelBilgi, 0, personelBilgi.Length);
                fs.Close();
            }
        }
    }
}