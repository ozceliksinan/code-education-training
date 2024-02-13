 /**
 *
 * @author Sinan Özçelik
 */
public class Main {
    
    
    public static void main(String[] args) {
        
        // IMuhendis muhendis1 = new IMuhendis();
        
        IMuhendis muhendis1 = new PcMuhendisi(false,false);
        
        /*muhendis1.askerlik_durumu_sorgula();
        muhendis1.adli_sicil_sorgula();
        System.out.println(muhendis1.mezuniyet_ortalamasi(3.07));
        String[] tecrube = {"Vestel","Havelsan","Turksat"};
        
        muhendis1.is_tecrubesi(tecrube);*/
        
        MakineMuhendisi muhendis2 = new MakineMuhendisi(true,false);
        
        String[] tecrube = {};
        String[] referans = {"Sinan Deneme","Deneme İsim"};
        muhendis2.adli_sicil_sorgula();
        muhendis2.askerlik_durumu_sorgula();
        System.out.println(muhendis2.mezuniyet_ortalamasi(2.31));
        muhendis2.is_tecrubesi(tecrube);
        muhendis2.referans_getir(referans);
        muhendis2.calis();
        
        /*
        İnterface, java dilinde class nasıl tanımlanıyorsa öyle tanımlanır. 
        Class yerine interface yazılır.Ancak soyut olarak sınıf sayabiliriz.
        Clastan farklı olarak statik değişkenleri vardır.
        (Statik değişken →başka metotta ya da sınıfta ulaşmamız gereken değişkenlere denir.
        Mesela statik değişken başka metotdan alırken alınacakMetotİsmi.statikDegisken şeklinde kullanılır.)

        Peki soyutlama ne derseniz bunu cevaplayalım.
        Bir sınıfın soyut olması kodu yazan kişinin kullanıcıya hissettirmemesi gerektiği ölçütüyle belirlenir.
        Bu sınıfları yazarken de güncelleyebilmeyi hesaba katmak gerekiyor. Aynı aşçının tenceresi gibi.
        Müşteri yemeği yer ama arkada nasıl yapıldığını bilmez.Aşçıda tencereyi geliştirmeye çalışmaz.
        
        Arayüzler c++ dilinde bulunmazlar.C# ve Javada bulunduğundan dolayı bu dillere esneklik katar.

        Arayüzlerin kullanımında ilk önce sınıflar arasındaki benzerlikler bulunmalıdır ve bu benzer yönler arayüz içerisine toplanmalıdır.
        Bu şekilde kullanım daha sağlıklıdır.

        Arayüzün gövdesi boş bırakılır.Bunun nedenini alttaki kodda görebiliriz.

        Neden interface kullanırız?
        Java çoklu mirası desteklemez.Çoklu miras alabilmek içinde interface çözümlerden biridir.

        İnterface içerisinde neler olmaz?
        Constructor ve destructor(yok edici) kesinlikle barındırmazlar.
        Arayüz içerisinde new() operatörü ile nesne tanımlanamaz.Tanımlamanız durumunda “Cannot instantiate the type…” hatasıyla karşılaşırsınız.

        Kısaca özetlersek, arayüz sınıflar dış dünyaya yapılacak hizmetleri söyler.
        Nasıl kullanılır kısmını alt sınıflar belirler.Kullanıcı hangi üst sınıf olduğunu bilmek zorunda kalmaz.
        Böylece esneklik ve sisteme kullanıcıları etkilemeden değişiklik yapmamızı sağlar.Servis sunucu ve sağlayıcı arasında bağımlılığı azaltır.

        İnterface içine yazılan tüm metotlar, implements edildiğinde tüm metotlarının hepsinin yazılması gereklidir.
        */
        
        
        
        
    }
    
}
