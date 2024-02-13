using System;
using System.Security.Cryptography;

namespace _38__MD5_Şifreleme_Teknikleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string SifrelenecekMetin = "sinanozcelik";
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] sifrelenecekMetinBytes = System.Text.Encoding.UTF8.GetBytes(SifrelenecekMetin);
            // byte dizi olarak döner.
            byte[] MD5ComputeBytes = MD5.ComputeHash(sifrelenecekMetinBytes);
            // Base64 ile md5 uygun hale getirildi.
            string SifrelenenDeger = Convert.ToBase64String(MD5ComputeBytes);

            Console.WriteLine(SifrelenenDeger);
        }
    }
}
