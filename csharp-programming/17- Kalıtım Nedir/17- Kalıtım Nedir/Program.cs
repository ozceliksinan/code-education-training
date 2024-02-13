using System;

namespace _17__Kalıtım_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //temelTip T1 = new temelTip();
            //T1.TemelTipMetot1();

            //Egitmen E1 = new Egitmen();
            //Console.WriteLine("Eğitmen nesnesi örneklendi.");
            //E1.TemelTipMetot1();

            //// Özel tiplerde Boxing ve Unboxing 

            //// Bizim object nesnemiz nedir ? 
            //// Temel Tip 
            //temelTip T2;
            //// Hangi nesnelerde temeltip object görevi görür... 
            //// Personel Egitmen Ogrenci. 
            //// Temeltip nesnesinden turedikleri için temel tip nesnesi bu nesnelerde object gibi davranır. 

            //T2 = E1; // Egitmen nesnesini Temeltip nesnesine atadık. 

            //E1 = (Egitmen)T2; // Unboxing 

            //Personel P1 = new Personel();
            //T2 = P1; // Personel nesnesini Temeltip nesnesine atadık.

            //P1 = (Personel)T2;

            //Ogrenci O1 = new Ogrenci();
            //T2 = O1; // Ogrenci nesnesini Temeltip nesnesine atadık.

            //O1 = (Ogrenci)T2;

            //// object O3 = T2;


            // Boxing -- Unboxing 

            //object O1 = E1;     // Boxing
            //E1 = (Egitmen)O1;   // Unboxing


            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object Obj1 = O1;
            //O1 = (Ogrenci)Obj1;

            //Obj1 = P1;
            //P1 = (Personel)Obj1;

            // Ben istiyorum Kİ türemiş olan tiplerim türeyemesin... 
            // object => temeltip => Personel =>  
            //                    => Ogrenci  => X
            //                    => Eğitmen  => X
            //Test T1 = new Test();
            //T1.

            // Hangi nesnemizin kalıtılmasını istemiyoruz ? 
            // Egitmen sealed

            Egitmen E1 = new Egitmen();

            // Egitmen => Personel => Temeltip => Object 
            // Object => TemelTip => Personel => Egitmen 

            // public : uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır. 
            // private : sadeece tanımlandığı class içerisine erişilebilir olur. 
            // protected : Normal kullanımda private olarak davranır. kalıtım yolu ile başka bir class içerisinde public olarak kullanılır. 

            temelTip T1 = new temelTip();

            Ogrenci O1 = new Ogrenci();
            O1.TemelTipMetot1();
        }
    }
}
