using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36__Registry_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Registry Nedir?
            // İşletim sisteminin veya işletim sistemi içerisine kurulan uygulamaların ayarlarının saklandığı yerdir.
            // Uygulamaların lisanslama işlemlerinde sıklıkla kullanılır.
            // C# ile registry işlemlerini yapabilmek için;
            // Registry sınıfını kullanırız. Registry sınıfı Microsoft.Win32 içerisindedir.

            // Yeni bir değer oluşturma işlemi
            Registry.CurrentUser.SetValue("Anahtar", "Merhaba Registry");


            // Oluşturmuş olduğumuz değerimizi okuyalım. 
            // Okumak için statik metotlardan faydalanırız. (Obje olarak geriye döner)
            string GelenDeger = Registry.CurrentUser.GetValue("Anahtar").ToString();
            Console.WriteLine($"Registry içerisindeki değer {GelenDeger}");

            Registry.CurrentUser.DeleteValue("Anahtar");


            // subkey -> registry editördeki(regedit) klasörler anlamına gelir.
            // Subkey oluşturma işlemi 
            // CurrentUser klasörü içerisine XYZProjesi adlı klasör oluşturduk.
            // Geriye registry key olarak geriye değer döndürür.
            Registry.CurrentUser.CreateSubKey("XYZProjesi");

            // SubKey oluşturma işlemi. 
            RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);

            // Subkey içerisine değer ekleme işlemi. 
            XYZProjesi.SetValue("HardDiskSeriNumarasi", "1245685");

            //  RegistryKey XYZProjesi =  Registry.CurrentUser.OpenSubKey("XYZProjesi");
            // Sub key içerisinden değer okuma işlemi. 
            string SeriNumarasi = XYZProjesi.GetValue("HardDiskSeriNumarasi").ToString();
            Console.WriteLine(SeriNumarasi);


            // CurrentUser klasöründeki XYZProjesi subkey'in içindeki değerleri okuyalım (HEPSİNİ)
            RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi", false);
            // GetValueNames -> değerlerin isimlerini dizi olarak döndürür.
            string[] KEYS = XYZProjesi.GetValueNames();
            for (int i = 0; i < KEYS.Length; i++)
            {
                Console.WriteLine($"Anahtar : {KEYS[i]} Value : {XYZProjesi.GetValue(KEYS[i])}");
            }

            Console.ReadLine();
        }
    }
}
