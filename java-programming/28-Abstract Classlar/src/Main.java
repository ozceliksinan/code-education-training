 /**
 *
 * @author Sinan Özçelik
 */
public class Main {
    public static void main(String[] args) {
        
        //Sekil sekil = new Sekil("Sekil");
        Sekil sekil;
        sekil = new Kare("Kare2",6);
        
        sekil.alan_hesapla();
        //sekil.cevre_hesapla();
        
        Kare kare1 = new Kare("Kare1",5);
        Daire daire1 = new Daire("Daire1", 3);
        
        kare1.alan_hesapla();
        daire1.alan_hesapla();
        kare1.cevre_hesapla();


        /*
		Soyutlama (Abstraction)
		Nesneye yönelimli programlamadaki en önemli kavramlardan biriside soyutlamadır. 
		Büyük ve kapsamlı program birçok sistem parçası ile mesajlaşarak çalışmaktadır. 
		Yapılan bu çalışmaların hepsini bir programcı olarak bilmek zor, zaman alıcı ve gereksizdir. 
		Böyle bir sistemin detaylarına odaklanmak yerine girdi ve çıktılarını bakmak sistemi daha iyi anlamıza olanak sağlar. 
		Java dilinde soyutlama abstract class (soyut sınıflar) ve interface (arayüzler) aracılığıyla yapılır.

		Abstract Class (Soyut Sınıf)
		Abstract sınıflar,genellikle ortak özellikleri olan nesneleri tek bir çatı altında toplamak için kullanılır. 
		Abstract sınıflarda içi boş yada dolu metodlar tanımlanır. 
		Abstract sınıflardan new kelimesi ile nesne oluşturulmaz. En az 1 abstract metod varsa sınıf abstract olmalıdır. 
		Bir sınıfı abstract sınıf yapmak için abstract kelimesi kullanılır.

		Abstract sınıflar,genellikle ortak özellikleri olan nesneleri tek bir çatı altında toplamak için kullanılır. 
		Abstract sınıflarda içi boş yada dolu metodlar tanımlanır. Abstract sınıflardan new kelimesi ile nesne oluşturulmaz. 
		En az 1 abstract metod varsa sınıf abstract olmalıdır. Bir sınıfı abstract sınıf yapmak için abstract kelimesi kullanılır. 
		Şimdi nasıl soyut sınıf oluşturabileceğimizi görelim.

		Soyut sınıflar kalıtım özelliğini kullanarak kod tekrarını azaltır.
		Her ne kadar soyutlama işlemi yapılmış olsa da interface kullanımına göre iyi sonuçlar alınmayabilir.

		Soyut sınıflar kendisinden türeyen sınıflardır.Bu sınıflardan nesne oluşturamayız.
		
		Erişim belirleyiciler ( public, private… ) kullanılabilir.
		Soyut sınıfı extend eden sınıf soyut sınıfın tüm soyut metotlarını override etmek zorundadır.
		Extends ederek farklı sınıflarda kullanabiliriz.Her extends ettiğimiz sınıfta, soyut sınıfların özellikleri kullanılarak farklı sonuçlar üretilir.
		Arayüzdeki somut nesneler( new operatörü ile oluşturduğumuz nesneler) oluşturulamaz.
		Soyut sınıflar , başka nesnelerden bağımsız bir şekilde çalışır.Daha iyi anlamak aşağıdaki örnek koduna bakabilirsiniz.

		Soyut sınıflarda neler olmaz?
		Soyut sınıfların içerisindeki soyut metotların gövdesi boş olması gerekir(Kullanılacak yere göre işlem farklılığı olacağından.)
		Ama soyut olmayan metotların gövdeleri olmak zorundadır.
		Soyut sınıflar private olarak tanımlanamazlar.Çünkü kalıtım özelliğini her daim göstermek zorundadır(Zaten soyut sınıfların sihri bu).
		
		
		Soyut sınıflar “abstract” türünden nesneler tanımlamazlar.
		
		“Static” metotlar soyut olarak tanımlanamazlar.

		Soyut sınıflar “sealed” anahtar sözcüğü ile ifade edilemezler.

		Soyut sınıflar neden kullanılır?
		Bazı durumlarda oluşturacağımız tasarımda benzer özellikler taşıyan sınıflara rastlayabiliriz.
		Bu sınıflarda tekrar tekrar aynı kodları yazmaktansa soyut sınıfları kullanmak daha kolaylık sağlıyor(kodun yeniden kullanılabilirliği).

		Genelde metotları sonradan geliştirilmek için kullanılır.

        */
    }
    
}