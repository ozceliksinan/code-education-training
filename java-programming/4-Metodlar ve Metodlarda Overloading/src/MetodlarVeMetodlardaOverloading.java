 /**
 *
 * @author Sinan Özçelik
 */
package pkg4.metodlar.ve.metodlarda.overloading;

import java.util.Scanner;

/**
 *
 * @author Sinan Özçelik
 */
public class MetodlarVeMetodlardaOverloading {
    public static void selamlama(){
        
        System.out.println("Merhaba Nasılsınız ?");
        System.out.println("Selamlar...");
        
    }
    public static void faktoriyel(){
        
        Scanner scanner = new Scanner(System.in);
        System.out.println("Bir sayı giriniz:");
        int sayi = scanner.nextInt();
        
        int faktoriyel = 1;
        
        while(sayi > 0) {
            
            faktoriyel *= sayi;
            
            sayi--;
        }
        System.out.println("Faktöriyel = " + faktoriyel);
    }
    
    // Parametreli fonksiyonlarla ilgili 2 tane örnek verelim.
    public static void toplama(int a,int b,int c) {
        
        System.out.println("Toplamları = " + (a+b+c));
        
    }
    public static void selamlama(String isim){
        
        System.out.println("Selamlar " + isim);
    }
    
    // Fonksiyonlarda return kavramı
    public static int ikiilecarp(int a) {
        return a*2;
    }
    public static int ikiiletopla(int a) {
        return a + 2;
    }
    public static int dortilecarp(int a) {
        return a * 4;
    }
    
    // Fonksiyonlarda overloading kavramı.
    public static void skorhesapla(String isim, int puan) {
        System.out.println(isim + " adlı oyuncunun " + puan + " puanı var");       
    }
    public static void skorhesapla(int puan) {
        System.out.println("İsimsiz oyuncunun " + puan + " puanı var");
    }
    public static void skorhesapla(String isim) {
        System.out.println(isim + " adlı oyuncunun hiç puanı yok.");
    }
    
    // Fonksiyonlarda overloading kavramı.
    public static void toplama(String a,String b) {
        System.out.println(a + " " + b);
    }
    public static void toplama(int a,int b) {
        System.out.println("Toplamları = " + (a+b));
    }
    public static void toplama(int a,int b,int c) {
        System.out.println("Toplamları = " + (a+b+c));
    }
    
    public static boolean asalMi(int sayi) {
        for (int i = 2 ; i < sayi;i++) {
            if (sayi % i == 0){
                return false;
            }
        }
        return true;
    }
    
    public static int ebobBulma(int sayi1,int sayi2) {
        int ebob = 1;
        for (int i = 1; i <= sayi1 && i <= sayi2 ; i++) {
            if ((sayi1 % i == 0) && (sayi2 % i == 0) ){   
                ebob = i;
            }
        }
        return ebob;
    }
    
    
    
    
    public static void main(String[] args) {

        /*
        Erişim_Belirleyici(Opsiyonel) Ekstra_Özellikler Dönüş_Tipi Fonksiyon_Adı(Parametreler){
            // Burası Fonksiyon Bloğu
        
            // Fonksiyonun yapacağı işlemler burada olacak.
        }
        */
        // Standart fonksiyonlar
        faktoriyel();
        faktoriyel();
        
        // Parametreli fonksiyonlar
        selamlama("Deneme");
        selamlama("Denemeeee");
        toplama(3,4,5);
        toplama(10,12,20);
        
        // Fonksiyonlarda return kavramı
        System.out.println("Sonuç " + dortilecarp(ikiiletopla(dortilecarp(4))));
        
        // Fonksiyonlarda overloading kavramı.
        toplama(3,4,5);
        toplama(2,5);
        toplama("Sinan Deneme","Denemee");
        
        // Fonksiyonlarda overloading kavramı.
        skorhesapla("Murat",1000);
        skorhesapla("Mehmet");
        skorhesapla(1500);
        
        /********************************************************************/
        /*          1'DEN 1000'E KADAR OLAN ASAL SAYILAR                    */
        /********************************************************************/
        /*
        1'den 1000'e kadar olan sayılardan asal olanları ekrana yazdırın.
        Asal Sayı : 1'e ve kendisinden başka hiçbir sayıya bölünmeyen sayıya asal sayı denir.
        */
        for (int i = 2 ; i < 1000 ; i++) {
            if (asalMi(i)){
                System.out.println(i);
            }
        }
        
        /********************************************************************/
        /*          İKİ SAYININ EBOBUNU BULMA                               */
        /********************************************************************/
        // Kullanıcıdan alınan 2 sayının ebobunu bulma
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Birinci Sayı : ");
        int birinci_sayi = scanner.nextInt();
        
        System.out.print("İkinci Sayı : ");
        int ikinci_sayi = scanner.nextInt();
        System.out.println("İki Sayının Ebobu : " + ebobBulma(birinci_sayi, ikinci_sayi));
        
    }
}