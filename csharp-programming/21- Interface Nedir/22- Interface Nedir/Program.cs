using System;

namespace _22__Interface_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Interface sözdizimi (syntax) olarak classlara benzemesine rağmen farklı bir yapıdır. 
             * Interface, bir classın sağlaması gereken yeteneklerin beyanıdır.
             * Interface içerisinde yanlızca metodlar ve propertyler tanımlanır, field tanımlanamaz.
             * 
             * Interface üyeleri herhangi bir access modifier’ a sahip değillerdir , implement edilen class tarafından bütün üyeler erişilebilir.
             * Interface’ ler loosely coupled uygulamalar oluşturmaya yardımcı olur. 
             * Aralarında bir interface oluşturarak iki class arasındaki bağlantıyı azaltırız. 
             * Bu şekilde, eğer bu class’lardan biri değişirse, buna bağlı olan class üzerinde hiçbir etkisi olmaz.
             * C# da multiple inheritance yoktur bir class birden fazla class’ı inherit edemez.
             * C# da bir class birden fazla interface’i implement edebilir fakat bunu inheritance ile karıştırmamak gerekir, 
             * interface yapısını multiple inheritance amacıyla kullanmak tamamen yanlış bir yaklaşımdır, 
             * interface yapısı multiple inheritance yapmak için oluşturulmamıştır.
             * Inheritance ile kodu bir kez yazar ve tüm bu kodu tekrar yazmanıza gerek kalmadan yeniden kullanırız.
             * Interface ile yalnızca uygulama class’ının içermesi gereken üyeleri implement ederiz.
             */
        }
    }
}
