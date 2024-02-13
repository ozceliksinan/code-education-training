package değişkenler.veri.tipleri.ve.temel.operatörler;

import java.util.Scanner;

/**
 *
 * @author Sinan Özçelik
 */
public class DeğişkenlerVeriTipleriVeTemelOperatörler {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    	/***********************************************/
    	/*              DEĞİŞKENLER                    */
    	/***********************************************/
    	int a = 10;
    	
    	int b = a * 2;
    	
    	int c = a * b * 2;
    	
    	int toplam = a + b + c;
    	
    	toplam = toplam - 5;
    	System.out.println("Toplam = " + toplam);
    	
    	/***********************************************/
    	/*              TAM SAYI VERİ TİPLERİ          */
    	/***********************************************/
        // byte --> short --> int --> long
    	
    	short i = 100;
    	byte j = 2;
    	int k = 4;
    	
    	long d = i + j + k;
    	System.out.println(d);
    	
    	/***********************************************/
    	/*              FLOAT VE DOUBLE VERİ TİPLERİ   */
    	/***********************************************/
       // Double : 64 bit - 8 byte
       // Float : 32 bit - 4 byte
    	
       // Otomatik Dönüştürme :  int --> float ---> double
    	
    	double sayi1 = 70.25;
    	double sayi2 = 60d;
    	double sayi3 = 80.2;
    	
    	float float1 = 70.25f;
    	float float2 = 60f;
    	float float3 = 80.2f;
    	System.out.println("Ortalama: " + (sayi1 + sayi2 + sayi3) / 3 );
    	System.out.println("Ortalama2: " + (float1 + float2 + float3) / 3 );
    	
    	/***********************************************/
    	/*              CHAR VE BOOLEAN                */
    	/***********************************************/
    	// Char Veri Tipi : Karakterleri göstermek için kullanılır. 
        // 2 byte yer kaplar. 2^16 tane karakter simgelenebilir.
        
        // Boolean Veri Tipi : Koşul Durumlarında kullanılır. 
        // true veya false değeri alır.
        
        boolean bool1 = true;
        boolean bool2 = false;
        System.out.println(bool1);
        System.out.println(bool2);
    	
    	
    	/***********************************************/
    	/*              OPERATÖRLER                    */
    	/***********************************************/
    	/*
        + ---> Toplama Operatörü
        - ---> Çıkarma Operatörü
        / ---> Bölme Operatörü
        * ---> Çarpma Operatörü
        % ---> Kalan Operatörü

        */
        /*
        System.out.println(3 + 4.2);
        System.out.println(3 - 5f);
        System.out.println(10 / 4.0);
        System.out.println(3 * 4.5);
        System.out.println(10 % 4);
        */
        System.out.println((3f / 4) + (4 * 5));
    	
    	/***********************************************/
    	/*              INPUT ALMA                     */
    	/***********************************************/
    	Scanner scanner = new Scanner(System.in);
        
        if (scanner.hasNextInt()){
              int sayi = scanner.nextInt();
              System.out.println("Sayı: " + sayi);
        }
        else {
            System.out.println("Lütfen bir sayı giriniz....!"); 
        }
        
        int yas1 = scanner.nextInt();
        int yas2 = scanner.nextInt();
        int yas3 = scanner.nextInt();
        
        System.out.println("yas1 : " + yas1 + " yas2: " + yas2 + " yas3: " + yas3 );
        
        /*int yas = scanner.nextInt();
        scanner.nextLine(); // Dummy
        
        String isim = scanner.nextLine();
        
        System.out.println("Yaş: " + yas);
        System.out.println("İsim: " + isim);
        */
        
    	/***********************************************/
    	/*              BEDEN KİTLE İNDEKSİ HESAPLAMA  */
    	/***********************************************/
    	/*
        Kullanıcıdan aldığınız boy ve kilo değerlerine göre kullanıcının beden kitle indeksini bulun.

        Beden Kitle İndeksi : Kilo / Boy(m) * Boy(m)
    
        */
        System.out.print("Kilonuzu Girin:");
        int kilo = scanner.nextInt();
        System.out.print("Boyunuzu Girin:(Örnek :  1,72)");
        double boy = scanner.nextDouble();
         
        double bki = kilo / (boy * boy);
         
        System.out.println("Beden Kitle Indeksiniz : " + bki);
    	
    	
    	
    	/***********************************************/
    	/*           YAKIT TUTARI HESAPLAMA            */
    	/***********************************************/
    	/*
        Bir aracın kilometrede ne kadar yaktığı ve kaç kilometre yol yaptığı bilgilerini alın ve 
        sürücünün toplam ne kadar ödemesini gerektiğini hesaplayın.
        */
        System.out.print("Aracınız kilometre kaç kuruş yakıyor? (Örnek : 0,32):");
        double kurus = scanner.nextDouble();
        
        System.out.print("Aracınızla kaç kilometre gittiniz ? :");
        
        int km = scanner.nextInt();
        
        System.out.println("Toplam ödemeniz gereken tutar : " + (kurus * km) + " tl dir...");
        
        
    	/***********************************************/
    	/*           DEĞİŞKEN DEĞERLERİNİ DEĞİŞTİRME   */
    	/***********************************************/
    	// Kullanıcıdan Aldığınız iki sayının değerlerini değiştirin.
        int birinci_sayi;
        int ikinci_sayi;
        
        System.out.print("Birinci Sayı : ");
        birinci_sayi = scanner.nextInt();
        
        System.out.print("İkinci Sayı : ");
        ikinci_sayi = scanner.nextInt();
        System.out.println("Değiştirilmeden Önce....");
        
        System.out.println("Birinci Sayı : " + birinci_sayi + " İkinci Sayı : " + ikinci_sayi);
        
        int gecici = birinci_sayi;
        birinci_sayi = ikinci_sayi;
        ikinci_sayi = gecici;
        System.out.println("Değiştirildikten Sonra....");
        
        System.out.println("Birinci Sayı : " + birinci_sayi + " İkinci Sayı : " + ikinci_sayi);
        
    }
}