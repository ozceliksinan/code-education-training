<h1>Hafta 2</h1>

- Kullanıcının gördüğü arayüzlere Activity denir. Bir class ın Activity olabilmesi için AppCompatActivity classını extend etmesi gerekir.
- Her activity onCreate method undan çalışmaya başlar.
- setContentView() methodu ile Activity nin hangi xml dosyası ile çalışacağı set edilir.
- Android uygulamalarının 3 ana parçası bulunur. AndroidManifest.xml  dosyası , java  ve res  klasörleridir.
- AndroidManifest.xml : uygulamanın genel konfigürasyon dosyasıdır. İzinler,uygulama ikonu , Activityler, Intendler,tema vs ... burada tanımlıdır.
- java klasörü : tüm java kodları burada bulunur.
- res klasörü  : görüntü,ses,uygulamanın kullandığı metinler,arayüz tasarımları , renk bilgileri... kısaca uyugulamanın kullandığı tüm kaynaklar buradadır.
- res klasörü altında bulunan mipmap klasöründe aynı görüntünün faklı çözünürlükte 6 kopyası bulunur. Uygulamanın açıldığı ekranın çözünürlüğüne göre uygun olan otomatik olarak    seçilir.
- res klasörü altında bulunan values klasöründe uygulamanın metinsel verileri tutulur.
- res klasörü altında bulunan layout klasöründe arayüz tasarımları bulunur.
- java kodunda R sınıfı ile res klasörü arasında bağlantı kurulur.
- Gradle uygulama geliştirme sürecini otomotize eden bir araçtır. Örneğin uygulamamızda kullanacağımız bir kütüphaneyi gradle a belirtir. Gradle otomotik olarak indirip uygulamaya dahil eder.
- Ekranda görünen her nesne bir view nesnesidir. Bir view elamanına tıkladığımızda eğer varsa onClick methodu tetiklenir.
- Intendler activiteler arası geçiş yapan ayrıca veri taşıyabilen nesnedir.

Bir önceki uygulamamızda değindiğim gibi Android’de bir ekran oluşturmak için iki temel gereksinim vardır. Bunlardan biri ekranı kodlarla kontrol edeceğiniz bir class (sınıf), diğeride ekranın tasarım dosyası olan xml uzantılı dosya. Ekran tasarımınızın yer alacağı xml uzantılı bu dosya res klasörü altında yer alan layout klasörleri içinde mutlaka yer almalıdır.

Tasarımlarınızı sadece bu dosyalar ile değil, oluşturduğunuz sınıf içerisinde yazdığınız kodlarla da yapabilirsiniz. Fakat kodlarla yapmak özellikle de yeni başlayanlar için biraz zahmetli  ve zor olacaktır. Bu yüzden xml uzantılı dosyaları kullanızı tavsiye ederim.

Gelelim bu dosyaları nasıl kullanacağınıza;

Öncelikle tasarlamak istediğiniz sayfaya uygun bir isimle xml uzantılı dosyayı oluşturmalısınız. Bunun için projenize sağ tıklayıp New -> Android XML File bağlantısını izleyebilirsiniz. Burada dosyanıza ismini verdikten sonra Finish‘e tıklıyorsunuz. Dilerseniz dosya ilk açıldığında kendiliğinden gelecek olan bileşeni de buradan seçebilirsiniz. Hiçbir şey seçmezseniz varsayılan olarak Constraint Layout  seçilecektir.

Dosya açıldığında iki kısımdan oluştuğunu göreceksiniz. Bunlardan biri, Graphical Layout, yani sürükle bırak mantığıyla istediğiniz bileşenleri çalışmalarınıza ekleyebildiğiniz, bu bileşenlerin konumlarını ayarlayabildiğiniz ve en önemlisi ekranınızın tasarımını rahatlıkla görebildiğiniz kısımdır. Diğeride, xml kodlarının yer aldığı kısımdır. Bu kodlar ile de istediğiniz düzenlemeleri gerçekleştirebilirsiniz. Bu iki kısım arasındaki geçişi sayfanın sol altında yer alan butonlarla gerçekleştirebilirsiniz.

# Android Görsel Bileşenlerimiz
Android,  uygulamalarımızda kullanabileceğimiz görsel bileşenleri bize hazır bir şekilde sunmaktadır. Bunlar, uygulamalarımızın olmazsa olmaz bileşenleridir.

## TextView
Ekranda bir metin/yazı göstermek istediğimizde kullandığımız bileşendir.

## EditText
Kullanıcıdan bir girdi almak istediğimizde bu bileşeni kullanırız. Örneğin; mail, telefon numarası, tc vb.

## ImageView
Ekranda resim göstermek istediğimizde kullandığımız bileşendir. Göstereceğimiz bu resimler, uygulama klasörlerinden drawable klasörü içerisinde yer alan veya başka bir kaynakta yer alan resimler olabilir.

## Button
Button, tıklandığında bir kod parçasını çalıştıran bileşendir. Uygulamamız içerisinde bir çok yerde ihtiyacımız olur. Android'i diğer bileşenlere tıklanma özelliği verme imkanını sağlamış fakat bu iş için özel olan button bileşenini koymayı da ihmal etmemiş. Bu tıklamaları kodlarımız içerisinde dinleyiciler (Listener) ile yakalanır. Tıklama işlemi gerçekleştiğinde yapılması gerekenleri ise Listener (dinleyici) metodları içerisinde tanımlıyoruz.

## ListView
Elimizde bulunan verileri satırlar halinde listelemek istediğimizde kullandığımız bileşendir. Satırları özel olarak farklı bir layout dosyasında tasarlayabilme imkanını sağlar.

## WebView
Web sayfalarını uygulamanız içerisinde göstermek istiyorsanız bu bileşeni kullanmanız gerekir. Ayrıca tasarladığınız HTML sayfalarını da uygulamanız içerisine koyarak bu bileşen ile görüntüleyebilirsiniz.

## Spinner
Kullanıcıya birden çok seçenek içerisinden birini seçtirmek istediğinizde bu bileşeni kullanmanız gerekir. Örneğin; doğum yeri gibi bir seçim yapılması gerektiğinde 81 ilden birinin seçilmesi gerekir. Bu ve benzeri durumlar için bu bileşen oldukça uygun ve kullanışlıdır.

## MapView
Uygulanızda Google Maps‘in özelliklerini kullanmak istiyorsanız bu bileşeni kullanmalısınız. Google’dan alacağınız bir key ile Google Maps‘in bütün özelliklerini bu bileşen yardımıyla kullanabilirsiniz.

## ProgressBar
Uzun süren işlemlerin ilerleme durumlarını, kullanıcılara bu bileşen yardımıyla gösterebilirsiniz. Uzun süren işlemlerde kullanıcılar bu bileşeni görmezlerse işlem yapıldığını farkedemezler.

## SeekBar
Bu bileşen, sağa sola çekilebilen bir çubuk şeklindedir. Örneğin; bir video veya bir ses dosyası oynatılırken ileri geri almak ya da sesi yükseltip alçaltmak için bu bileşen kullanılabilir.

## CheckBox
Bu bileşen, doğru/yanlış, onayla/onaylama, evet/hayır gibi iki seçeneği bulunan durumlar için oldukça kullanışlıdır. İçerisine tik konulabilen bir kutucuk şeklindedir. Örneğin; kullanıcıdan bir işlem için onay almak istediğinizde bu bileşeni kullanabilirsiniz.

## Toast Nedir?
Toast, genellikle uygulama test edilirken kullanılan uyarı mesajlarıdır.

Toast ile istenilen bir yazı veya hazırlanan bir View belli bir süre ekranda gözükür ve kaybolur. Bu özellik, kullandığımız bir Listener‘ın çalışıp çalışmadığını test ederken kullanılabilir. Ayrıca kullanıcılara bilgilendirici mesajlar vermek içinde kullanılabilir. Örneğin bir slider hazırladınız, kullanıcı ileri ya da geri resimler arasında geçiş yapıyor, ilk ya da son resme geldiğinde kullanıcıya bunun uyarısını vermek için toast oldukça kullanışlıdır. Toast‘lar bu ve benzeri birçok durumda işimize yarayabilir.

Uygulamamızda intent yapısı kullanılarak activity'ler arası geçişler sağlanacaktır. 3 tane activity dosyamız oluşturulacaktır. Bu 3 activity dosyamız ise çeşitli fonksiyonlar ile işlemler gerçekleştirecektir.