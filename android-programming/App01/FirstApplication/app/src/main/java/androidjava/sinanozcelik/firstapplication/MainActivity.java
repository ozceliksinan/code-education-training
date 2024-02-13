package androidjava.sinanozcelik.firstapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    /* UYGULAMADA İLK AÇIKLAMALAR
    Ekranda gözükecek proje kısmına LAYOUT denir.
    Main activity kodunu çalıştırdığımızda default olarak ilk çalışacak metot onCreate metodudur.
    setContentView: Bu java sınıfı hangi layout kodlarını kullansın burda belirtiliyor. (İlişkilendirme işlemidir)

    # KLASÖRLERE BAKALIM #
    Manifest: Androidin kontrol (configuration) panelidir.
        - Hangi aktiviteler yer alacak.
        - Hangi izinlere sahip olacak.
        - Uygulamanın icon bilgileri yer alır.
        - Label bilgilerine burdan erişilebilir.

    Java: Uygulamamızdaki activity'ler gözükür.
        - Uygulamamızda kaç tane sayfa varsa bu klasörden yönetiriz.

    Res: Uygulamada kullanılıcak olan kaynakların yer aldığı klasördür.
        - Layout bilgilerimiz bu klasörde yer alır.
        - Drawable klasörü ise xml uzantılı resimlerimiz yer alır. JPG, PNG uzantılı resimler de atabilir.
        - XML uzantılı resimler bitmap tabanlıdı değildir Vector tabanlıdır. Çizgiler şeklindedir aslında. Verilen koordinatlar arasını dolduran çizgilerdir.
        - Bitmap boyutu > Vector boyutu
        - Mipmap: Resimler farklı çözünürlükte saklanıldığı bir klasördür. Telefon & Tablet çözünürlüğüne uygun olan resmi getirir.
        - Values: XML'de text verilerini sakladığımız yer values klasörümüzdür. Genelde string veri tiplerimizi saklarız. Renk kodları isimlendirilebilir(Örnek)

     Build.gradle (Module): Bir çok ayarlamayı yaptığımız yerdir.
        - SDK version gibi, plugin eklentileri burda yapılır.
        - Uygulamamızın version bilgilerini burdan güncelleyebiliriz.
        - Bir çok sistem bilgisini burdan kontrol ederiz ve değiştirebiliriz.
        - Bilgiler değiştirildikten sonra senktoronize edilmesi gereklidir.
     */

    /* UYGULAMADA İKİNCİ AÇIKLAMALAR
    View elemanları xml dosyasının içine bırakıldığı zaman hem yatayda hem de dikey hizalamasının yapılması gereklidir.

    Design kısmında -> View kısmında -> constraintlayout anlamı ise tüm view elemanlarını kapsayan ana bölmedir. Design kısmında eklenen bütün özellikler bu layout içinde saklanır.
    Wrap Content: İçeriğe göre genişle anlamına gelir.
    Match Constrain: Bu ise gidebileceği yere kadar genişle anlamına gelir.

    Design kısmında tanımlanan button, textview gibi elemanlar MainActivity'de ya da çalışılan Activity'de gözükmez.
    Design kısmında tanımlanıp kullanılacak olan view elemanları alıp burda tanımlamak ve daha sonrasında ilişkilendirmek gereklidir.
     */

    Button btnChange; // Çalışması için button kütüphanesi alt+enter ile eklenmesi gereklidir.
    TextView tvText; // Çalışması için TextView kütüphanesi alt+enter ile eklenmesi gereklidir.

    Button btnColor;
    Button btnSecond;

    // Burda tanımlanan değişkenlerin şuan XML Design dosyamızın içindeki view'ler ile bir bağlantısı yoktur
    // Birisi değişkendir, birisde id'dir aslında.

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Tanımlanan değişkenlerimiz ile layout'taki view elemanlarımızı bir birine bağlayalım.
        btnChange = findViewById(R.id.btn_change); // Bu işlem ile activity'deki değişkenimiz, layouttaki view elemanımızla eşleştirildi.
        tvText = findViewById(R.id.textView); // Bu işlem ile activity'deki değişkenimiz, layouttaki view elemanımızla eşleştirildi.

        btnColor = findViewById(R.id.btn_color);
        btnSecond = findViewById(R.id.btn_second);
    }

    // buttona tıklanıldığında text alanımız değişsin. Bu işlemi gerçekleştirecek kodlarımızı yazalım.
    public void ChangeText(View view)
    {
        // Buttana tıklanıldığında bu fonksiyon çalışacaktır.
        // Değişmesini istediğimiz kısım ise text alanımızdaki içeriğin değişmesidir.

        // setText: Hazır bir metottur. Text alanının içindeki veriyi değiştirmeye yarar.
        tvText.setText("Android'e Hoş Geldiniz!");
    }

    public void Colorize(View view)
    {
        // setTextColor: Yazının rengini değiştiren hazır bir fonksiyondur.
        tvText.setTextColor(Color.BLUE);
    }

    // Bir activity'den başka bir activity'e geçiş yaparken biz intent yapısını kullanıyoruz.

    public void OpenSecond(View view)
    {
        // Ana kaynak yolundan geçiş kaynak yolu belirtildi ve intent değişkenine aktarıldı.
        Intent intent = new Intent(MainActivity.this, SecondActivity.class);
        // Geçiş işleminin yapılabilmesi için startActivity() metotu ile geçiş yolunun değişken ismi parametre olarak verilmesi gereklidir.
        startActivity(intent);
        // buttona tıklanırsa geçiş işlemi gerçekleştirilir.
    }

    /*
    # ÖNEMLİ NOT #
    Bu uygulama kapsamında button değişkenleri silinirse uygulama çalışır. Sebebi ise biz XML Layout kısmında onClick metodu kısmında buttonlara zaten metot ismiyle dolaylı
    yoldan da olsa bir kimlik ataması gerçekleştirdik. Bu uygulama kapsamında button değişkenlerine ihtiyaç yoktur, ama daha karmaşık uygulamalarda button değişkenlerinin tanımlaması
    önemli bir durumdur.
     */
}