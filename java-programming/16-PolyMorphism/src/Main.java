 /**
 *
 * @author Sinan Özçelik
 */
 class Hayvan {
    private String isim;

    public Hayvan(String isim) {
        this.isim = isim;
    }
    public String getIsim() {
        return isim;
    }
    public void setIsim(String isim) {
        this.isim = isim;
    }
    public String konus() {
        
        return "Hayvan konuşuyor...";
    }
}

class Kedi extends Hayvan {
    public Kedi(String isim) {
        super(isim);
    }

    @Override // Bir metodun override edildiği bu yazım şekli ile anlaşılır.
    public String konus() {
    	// getIsim miras alındı.
    	// metot miras alınan class'dan override edildi.
        return this.getIsim() + " miyavlıyor...";
    }
}
class Kopek extends Hayvan {

    public Kopek(String isim) {
        super(isim);
    }

    @Override
    public String konus() {
        return this.getIsim() + " havlıyor...";
        
    }

}
class At extends Hayvan {

    public At(String isim) {
        super(isim);
    }

    @Override
    public String konus() {
        return this.getIsim() + " kişniyor...";
        
    }   
}
public class Main {
    
    public static void konustur(Hayvan hayvan) {
        System.out.println(hayvan.konus());
        
    }
    public static void main(String[] args) {

    	/*
		Java’da farklı şekilde çalışan nesnelere aynı şekilde erişmek şeklinde tanımlayabiliriz. 
		Diğer bir tanım olarak bir nesnenin farklı bir nesne gibi davranmasıdır.
		
		Geç Bağlama — Late Binding
		En genel tanımıyla çok biçimliliğin oluştuğu anda, yani run time sırasında nesne örneğinin bağlanacağı 
		nesne türünün belirlenmesi ve buna uygun işlemlerin tamamlası sürecinde yapılan işlemlerdir.
		Çok biçimlilik olmadan geç bağlamadan bahsedilemez

		instanceof Metodu
		Çok biçimlilik olmadığında kullanılır. 
		Bu metot solunda ifade edilen referansın sağında ifade edilen tipten olup olmadığını kontrol eder. 
		Doğru ise true yanlış ise false değerini döndürür.
    	*/
        
       /* Hayvan hayvan1 = new Kedi("Tekir");
        Hayvan hayvan2 = new Kopek("Karabaş");
        Hayvan hayvan3  = new At("Şahbatur");
        System.out.println(hayvan1.konus());
        System.out.println(hayvan2.konus());
        System.out.println(hayvan3.konus());*/
       
        konustur(new Kedi("Tekir"));
        konustur(new Kopek("Karabaş"));
        konustur(new At("Şahbatur"));
        
    }
}
