Bildiğiniz gibi tasarımlar programladığımız Mobil Android uygulamalarda büyük bir öneme sahip. Kullanıcı gözüyle uygulamalara baktığımızda, insanların tasarıma ve uygulamanın kendi içindeki akışına önem verdiğini görebiliriz. Bu sebeple, yazımda Layout kavramını ve Layout tasarımını giriş seviyesinde sizlere aktarmak istiyorum. Kullanımlarını ben de zamanla oturtmaya çalışıyorum. Bu yüzden hatalarım olacaktır fakat genel çerçevesiyle Layout mantığını kavratacak bir yazı olduğunu düşünüyorum. Yazıma sıkça rastlayacağınız “component” kavramıyla başlamak isterim.

## Component Nedir?
Componentler basitçe, View tarafında kullandığımız nesnelerdir. Tasarımımızı componentler ile oluştururuz. Componentlere için “Widget” kavramı da kullanılmakta fakat ben bu yazı için component kavramını kullanacağım.

>Ör: TextView, ImageView, EditText…

## Layout Nedir?
Android projelerimizde, Projemizin View yani arayüz kısmını .xml formatlı olarak tasarlarız. Bu arayüzler, layout dosyaları aracılığıyla oluşturulur. Layout, yaptığımız tasarımda View componentlerin yaşama alanıdır diyebiliriz. Tasarımlarda kalıp görevi görerek sağladığı özelliklerine göre içinde kullanılan componentlere düzen sağlar, nasıl gözükmeleri gerektiğini belirler. Android’de farklı layoutlar vardır ve farklı amaçlar için kullanılır. Android programlamaya başlandığında sık rastlanan hizalama ve boşluk hatalarını kolayca çözmemizi sağlayan ve layoutlarda kullanmamız gereken 2 temel tasarım özelliğini göstermek istiyorum.

**wrap_context : İçerisinde bulunan componentler kadar yer kaplar.**

**match_parent : İçinde bulunduğu alanı tüm doğrultusuyla kapsar.**

Şimdi Layout türlerine giriş yapabiliriz.

## 1) LinearLayout
Android programlamaya başlayanların, ilk zamanlarda sık sık denk geldiği layoutlardan biridir.

Linear Layout, temel olarak içinde bulunan componentleri yatay (horizontal) veya dikey (vertical) olarak sırayla hizalamaya yarar.

Bunu belirlemek için xml özelliklerimizden veya daha önce söylediğimiz “Attributes” kısmından kullanılan Layout’un orientation(yön) ayarlamasını yapabiliriz.

LinearLayoutlar ile yaptığımız tasarımlarda hizalamayı doğru yaparsak, uygulamamız ileride farklı boyutlardaki cihazlarda da sıkıntısız olarak çalışacaktır. Çünkü orantıyı kurmak, elle sayı girmekten her zaman daha iyidir. Sayılar değişse bile program önceden kurgulanan orantıya bağlı kalarak tasarım düzenini koruyacaktır.

## 2) RelativeLayout
Relative Layout, temelinde programcıya tasarımda özgürlük tanır. Componentleri istediğimiz şekilde hizalayabilir ve sürükleyebiliriz. LinearLayout’tan farkı daha özgür olması ve farklı özellikler içermesidir. İçindeki componentleri, etrafındaki bileşenlere göre sağa, sola, yukarı veya aşağı hizalayabiliriz.

Bileşenleri, ekran içerisindeki bir kenara veya köşeye hizalamak için, 

layout_alignParent özelliğini kullanabiliriz.

Hizalama yöntemlerini inceleyelim.

1. Dışarıdan Hizalama
    * layout_above : seçilen componenti ID’si verilen diğer componentin üstünden başlayarak dışarıya doğru hizalar.

    * layout_below : seçilen componenti ID’si verilen diğer componentin altından başlayarak dışarıya doğru hizalar.

    * layout_toRightOf : seçilen componenti ID’si verilen diğer componentin sağından başlayarak dışarıya doğru hizalar.

    * layout_toLeftOf : seçilen componenti ID’si verilen diğer componentin solundan başlayarak dışarıya doğru hizalar.

2. İçeriden Hizalama
    * layout_alignLeft : seçilen component’i ID’si verilen diğer componentin solundan başlayarak içine doğru hizalar.

    * layout_alignRight : seçilen component’i ID’si verilen diğer componentin sağından başlayarak içine doğru hizalar.

    * layout_alignBottom : seçilen component’i ID’si verilen diğer componentin altından başlayarak içine doğru hizalar.

    * layout_alignTop : seçilen component’i ID’si verilen diğer componentin üstünden başlayarak içine doğru hizalar.


> Dışarıdan hizalamada, birbirine göre hizalanması gereken 2 component iç içe çakışmaz. Above(üst) veya Below(alt)’dan başlayarak o componentin dışına doğru hizalar.

<br>

## 1) GridLayout
GridLayout, TableLayout’un daha gelişmiş halidir. TableLayout veri gösterimi için kullanılabilir fakat cansızdır ve dinamik olarak kullanışsızdır. Daha gelişmiş özellikleri içeren bir tablo görünümü için GridLayout kullanmalıyız. Çünkü GridLayout aynı zamanda ListView’e yakın mantıkta çalışır. Adapter ile kullanılabilir, gezinme, sürükleme vb. imkanlar tanır. Sütun veya satırlara istediğimiz componentleri yerleştirip onları düzene sokmamıza olanak sağlar. Bazı temel özelliklerini incelemeye başlayalım.

Satır ve sütün sayılarını kendimiz belirleriz.

Bunun için;

**columnCount**

**rowCount özelliklerini kullanırız.**

Unutmamız gereken detay şudur: satır ve sütunlarda ilk indis 0’dır.

Böylece Android bize bileşenlerin yerlerini row ve column ayarları vererek değiştirme imkanı tanıyor.

Ayrıca,

```java
android:useDefaultMargins="true"
```

komutu ile layoutun varsayılan kenar boşluklarını kullanabilmesini sağlar.

Peki, her satırın veya sütunun kullanması gerektiği alanı değiştirmemiz gerektiğinde ne yapacağız?

Bunun için;

**layout_rowSpan***

layout_columnSpan özelliklerini kullanabiliririz.

## 4) FrameLayout
Frame Layout, yaygın olarak componentlerin birbirlerinin yerine geçebilmesine ve üst üste kullanabilmesine olanak sağlar. Bu şekilde yapıları çakışmadan birbirinin yerine kullanmamıza ve hangisinin üstte olacağına karar vermemizi sağlar.

FrameLayout componentlerin yerleşiminde stack gibi davranır.

Stack ise Last In First Out mantığıyla çalışır. Burada da FrameLayout’a eklenen en son bileşen en önde gözükecektir.

Ayrıca FrameLayoutlar sık olarak Fragmentlar ile kullanılsa da aralarında direk bir bağlantı yoktur. Burada da aynı şekilde fragmentların üstlerine binmeden birbiri arasında geçiş yapabilmesi söz konusudur.