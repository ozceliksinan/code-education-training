using System;

namespace _20__Sanal_Metotların_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            televizyon T1 = new televizyon();
            T1.ekranaYaz("Hangisi ?");

            urun U1 = new urun();
            U1.ekranaYaz("Merhaba");

            baseClass B1 = new baseClass();
            B1.ekranaYaz("Merhaba");
        }
    }
}
