 /**
 *
 * @author Sinan Özçelik
 */

public class Main {
    
    public static void main(String[] args) {
   
        /*Abone abone = new Abone();
        
        abone.isim = "Sinan Deneme";
        abone.bakiye = 200;
        abone.sehir = "İstanbul";
        
        abone.dogalgaz_kullan(200);*/
        
        GelismisAbone abone = new GelismisAbone("Sinan Deneme",200,"İstanbul");
        abone.bakiye_ogren();
        
        /*
		Dışarından ya da yanlış kullanım sonucu kodu ve veriyi koruyan bir mekanizmadır. 
		Bir diğer şekliyle iş metot tarafından yapılır fakat metotun içeriği gösterilmez.

		Private: Sınıfa özel değişkenlerdir.
		Public: Herkese açık olan değişkenlerdir.
		Protected: Extends edenlere, türetenlere ve aynı pakette olanlara açık olan değişkenlerdir.
		Default: Hiçbir şey yazılmazsa aynı pakettekilerin erişebildiği değişkenlerdir.
		Statik: public static int ogrenciSayisi = 0; böyle bir tanımlama şekli vardır.

		Eğer değişken nesne değişkeni değilde sınıf değişkeni olsun istiyorsak statik anahtar kelimesini kullanmalıyız.

		Final: Final olan bir değişkene sadece bir kere değer ataması yapılabilir.
		Final olan bir metot ne alt sınıflarca yeniden yüklenebilir (method overloading) ne de saklı (hidden) tutulabilir.

		Public ile Static kavramını karıştırmamalısınız.Bir değişken public olarak oluşturulsa da “static” değil ise
		bu değişkenin dışardan kullanılması için instance oluşturulmalıdır. Burada erişilebilecek olanlara sadece
		get metodu yazıldı.Değiştirileceklere ise set metodu yazıldı.Eğer hiçbir şekilde değiştirilmesini ve 
		erişilmesini istemezsek get ve set metodlarını kullanmamamız gerekir.

		Java Encapsulation aslında java sınıfı içerisinde tanımladığımız değişkenlerimizi korumak veya saklamak anlamanına gelmektedir. 
		Tanımladığımız bir sınıf içerisindeki değişkenin direk olarak değiştirilememesi, 
		bunun yerine bizim izin verdiğimiz ölçüde, metotlar aracılığıyla değiştirilmesi gerekmektedir. 
		Bir değişkene sadece okuma yetkisi verebilir, sadece yazma yetkisi verebilir veya hem okuma hem yazma yetkisi verebiliriz.
        */
    }
}