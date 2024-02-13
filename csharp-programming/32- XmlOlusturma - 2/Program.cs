using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlOlusturma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> Ogrencilerim = new List<Ogrenci>();

            // Nuget kısmından fake data ile rastgele verili xml yapısı oluşturalım..
            for (int i = 0; i < 100; i++)
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.NewGuid();
                Temp.Isim = FakeData.NameData.GetFirstName();
                Temp.Soyisim = FakeData.NameData.GetSurname();
                Temp.Numara = FakeData.NumberData.GetNumber(100, 500);
                Ogrencilerim.Add(Temp);
            }

            XDocument Doc = new XDocument(
                new XDeclaration("1.1", "UTF-8", "yes"), 
                new XElement("Ogrencilerim", Ogrencilerim.Select(I => new XElement("Ogrenci", new XElement("ID", I.ID), 
                new XElement("Isim", I.Isim), new XElement("Soyisim", I.Soyisim), new XElement("Numara", I.Numara)))));
            Doc.Save(@"c:\XML\Ogrencilerim.xml");
        }
    }
}
