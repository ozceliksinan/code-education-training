using System;
using System.IO;

namespace _27__File_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool kontrol = FileExists("c:\\Sinan\\merhaba.txt");
            //if (kontrol)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır.");
            //}
            //else
            //{
            //    FileCreate("c:\\Sinan\\merhaba.txt");
            //}

            string metinDegeri = FileReadAllText("c:\\Sinan\\merhaba.txt");
            Console.WriteLine(metinDegeri);
            FileAppendText("c:\\Sinan\\merhaba.txt", "Merhaba TXT belgesi. Yeni içerik metot tarafından eklendi.");

            FileCopy("c:\\SinanII\\merhaba.txt", "c:\\Sinan\\merhaba.txt");
            FileMove("c:\\Sinan\\merhaba.txt", "c:\\SinanII\\merhaba.txt");

            FileDelete("c:\\Sinan\\merhaba.txt");
        }

        static void FileCreate(string path)
        {
            // Filestream ile bir dosya açıldığında, o dosya sistem dosyası olarak kabul edilir ve Close ile 
            // akış kapatılmadığı sürece çeşitli hatalar kullanıcı tarafında alınabilir. (Yazılan bilgileri kaydetme hatası gibi..)
            FileStream Fs = File.Create(path);
            Fs.Close(); // Kapatıldığı için sistem tarafından kullanılmış uygulama olarak göstermedi. (Bellekten düştü)
        }

        static bool FileExists(string path)
        {
            // Exists ile dosyanın var olup olmadığını kontrol ederiz.
            return File.Exists(path);
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef)
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path, string deger)
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri = File.ReadAllText(path); // Bütün dosya okunur.
            return metinDegeri;
        }
    }
}