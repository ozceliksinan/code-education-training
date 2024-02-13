using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Olusturma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            <?xml version="1.0" standalone="yes"?>
            <VeriTabanim>
              <Personellerim>
                <Isim>sinan</Isim>
                <Soyisim>deneme</Soyisim>
              </Personellerim>
            </VeriTabanim>
            */

            // LinQ Teknolojisi ile daha basit ve pratik şekilde xml yapısı oluşturulabilir.
            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("VeriTabanim",
                new XComment("Personellerim Bilgilerini Taşır"), // Yorum satırı oluşturuldu
                new XElement("Personellerim", new XAttribute("ID", "102"), // XML Yapısı içerisinde özellik içinde özellik yapısı kullanılabilir. 
                new XElement("Isim", "sinan"), 
                new XElement("Soyisim", "deneme"), 
                new XElement("EmailAdres", "sinanozcelik@yaani.com")
                )
                )
                );
            XDoc.Save(@"c:\XML\Ornek1.xml");
        }
    }
}
