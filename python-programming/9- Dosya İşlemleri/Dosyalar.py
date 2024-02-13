#######################################
# Writed by Sinan Özçelik             #
#######################################

# Bir dosyayı açmak için open() fonksiyonunu kullanıyoruz. Yapısı şu şekildedir;

# open(dosya_adı,dosya_erişme_kipi)

# Dosya adını istediğimiz isimde verebiliriz. 
# Dosya erişme kipi ise bizim dosya üzerindeki işlemlerimizi belirler. Bunları dersler boyunca yavaş yavaş göreceğiz.

# “w” dosya kipi
# Dosyalarımızı açmak ve dosyalarımıza yazmak için “write” anlamına gelen “w” kipini kullanıyoruz. 
# “w” kipi eğer oluşturmak istediğimiz dizinde öyle bir dosya yoksa dosyayı oluşturuyor , eğer öyle bir dosya varsa dosyayı silip tekrar oluşturuyor. 
# Yani, eğer açmak istediğimiz dosyadan zaten varsa ve dosyanın içi doluysa “w” kipi dosyadaki bilgileri silip tekrar oluşturacaktır. (Biraz Tehlikeli)

open("bilgiler.txt","w") # Dosyayı bulunduğumuz dizinde açıyor.

file = open("bilgiler.txt","w") # Dosya üzerinde işlem yapacak dosya imlecini file isimli değişkene atıyoruz.
# file = open("C:/Users/Desktop/bilgiler.txt","w")   -> Başka bir konumda dosya açmak.

# Dosyaları Kapatmak
# Bir dosya üzerinde işlem yaptığımızda o dosyayı kapatmak sistem kaynaklarının gereksiz kullanılmaması açısından önemlidir. 
# Çünkü programımız bitse bile dosyanın kapanacağı garanti değildir. 
# Bu yüzden işlerimiz bittiği zaman dosyayı kapatmalıyız.

file.close()  # Dosyayı kapatmak

# Eğer bir dosyayı bulunduğumuz dizinde değil de başka bir dizinde açmak istersek, dizinin yolunu özellikle belirtmeliyiz.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# “w” Kipiyle Dosyalara Yazmak

file = open("bilgiler.txt","w",encoding="utf-8") # Türkçe karakter kullanacaksak encoding="utf-8" parametresini veriyoruz.
file.write("İnclude Program Python") # write fonksiyonu ile dosyamıza yazıyoruz. 20 bytelık yani 20 karakter yazıldı.
 
file.close()

# Gördüğümüz gibi write fonksiyonuyla dosyamıza herhangi bir şey yazabiliyoruz. 
# Ancak “w” kipi her seferinde dosyayı tekrar oluşturduğu için dosyayı tekrar açtığımızda bilgiler kaybolacaktır.

file = open("bilgiler.txt","w",encoding="utf-8")
file.close()

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# “a” Kipiyle Dosyalara Yazmak
# “append” (ekleme) kelimesinin kısaltması olan “a” kipiyle bir dosyayı açtığımızda , dosya eğer yoksa oluşturulur. 
# Eğer öyle bir dosya mevcut ise, dosya tekrar oluşturulmaz ve dosya imleci dosyanın sonuna giderek dosyaya ekleme yapmamızı sağlar.

file = open("bilgiler.txt","a",encoding="utf-8")
file.write("İnclude Program Python") 
file.close()

# Dosyayı tekrar açalım.

file = open("bilgiler.txt","a",encoding="utf-8")
file.write("Python Programlama") # Dosyanın sonuna ekleme yaptık.
file.close()

# Ancak eğer buradaki isimleri dosyalara alt alta yazmak istersek “\n” karakterini kullanmalıyız.

file = open("bilgiler.txt","a",encoding="utf-8")
file.write("İnclude Program Python\n")
file.write("Python Programlama\n")
file.close()

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosya Okuma İşlemleri
# Dosyaları okumak ve verileri almak için “r” kipiyle açmamız gerekiyor. 
# “r” kipiyle açtığımız dosya eğer bulunmuyorsa “FileNotFoundError” hatası dönecektir. 
# Şimdi bulunduğumuz dizinde bulunan “bilgiler.txt” dosyasını açalım.

file = open("bilgiler.txt","r", encoding="utf-8")
file.close()

file = open("bilgiler2.txt","r",encoding="utf-8")  # böyle bir dosya yok . O yüzden FileNotFoundError hatası döndü.
 
---------------------------------------------------------------------------
# böyle bir dosya yok . O yüzden FileNotFoundError hatası döndü.
FileNotFoundError                         Traceback (most recent call last)
<ipython-input-10-4bbe98bb1ec9> in <module>()
----> 1 file = open("bilgiler2.txt","r",encoding="utf-8")
FileNotFoundError: [Errno 2] No such file or directory: 'bilgiler2.txt'
---------------------------------------------------------------------------

# Dosya işlemlerini daha güvenli yazmak try,except bloklarını kullanabilirsiniz.

try:
    file = open("bilgiler2.txt","r",encoding= "utf-8")
except FileNotFoundError:
    print("Dosya Bulunamadı....")
"""
Çıktı
Dosya Bulunamadı
"""

# Peki bir dosyanın içinden bilgileri nasıl okuyacağız ? 
# Bunun için Pythonda değişik yöntemler bulunuyor. 
# İsterseniz bu yöntemleri tek tek görmeye çalışalım.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# For döngüsü ile okuma
# Şöyle bir kullanım dosyamızdaki herbir satırı tek tek okuyacaktır.

"""
Diyelim ki dosyamızın içeriği bu şekilde.
 
İnclude Program Python
Python Programlama
Java Programlama
Kotlin Programlama
Javascript Programlama
"""
 
file = open("bilgiler.txt","r",encoding= "utf-8") # Dosyayı okuma kipiyle açıyoruz. Türkçe karaktere dikkat.
 
for i in file: # Tıpkı listeler gibi dosyanın her bir satırı üzerinde geziniyoruz.
    print(i) # Her bir satırı ekrana basıyoruz.
file.close()
 
"""
Çıktı
 
İnclude Program Python
 
Python Programlama
 
Java Programlama
 
Kotlin Programlama
 
Javascript Programlama
 
"""

# Burada her bir satırımız boşluklu yazıldı. Bunun nedeni, hem her satır sonunda “\n” karakterinin olması hem de 
# print fonksiyonun bir alt satıra geçmek için boşluk bırakmasıdır. 
# Bunu önlemek için varsayılan değer olarak “\n” karakteri alan end parametresine kendimiz değer verebiliriz.

file = open("bilgiler.txt","r",encoding= "utf-8") # Dosyayı okuma kipiyle açıyoruz. Türkçe karaktere dikkat.
for i in file: # Tıpkı listeler gibi dosyanın her bir satırı üzerinde geziniyoruz.
    print(i,end = "") # Her bir satırı ekrana basıyoruz. end parametresi \n yerine boşluk alacak. 
    # end karakteri ile cümle sonuna varsayılan karakter eklenebilir.
file.close()
"""
Çıktı
 
İnclude Program Python
Python Programlama
Java Programlama
Kotlin Programlama
Javascript Programlama
 
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# read() fonksiyonu
# read() fonksiyonu eğer içine hiçbir değer vermezsek bütün dosyamızı okuyacaktır.

file = open("bilgiler.txt","r",encoding="utf-8")
icerik = file.read() 
print("Dosya İçeriği:\n",icerik,sep ="")
file.close()
"""
Çıktı
 
Dosya İçeriği:
İnclude Program Python
Python Programlama
Java Programlama
Kotlin Programlama
Javascript Programlama
 
"""

# read() fonksiyonuyla bir dosyayı okuduğumuzda dosya imlecimiz dosyanın en sonuna gider ve read() fonksiyonu 2. okuma da artık boş string döner.
# Tekrardan read ile okumak bu kod için mantıklı değildir.

file = open("bilgiler.txt","r",encoding="utf-8")
icerik = file.read() 
print("1. Okuma : Dosya İçeriği:\n",icerik,sep ="")
icerik2 = file.read()
print("2. Okuma : Dosya İçeriği:\n",icerik2,sep ="")
file.close()
 
"""
Çıktı
 
1. Okuma : Dosya İçeriği:
İnclude Program Python
Python Programlama
Java Programlama
Kotlin Programlama
Javascript Programlama
 
2. Okuma : Dosya İçeriği:
 
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# readline() fonksiyonu
# readline() fonksiyonu her çağrıldığında dosyanın sadece bir satırını okur. 
# Her seferinde dosya imlecimiz (file) bir satır atlayarak devam eder.

file = open("bilgiler.txt","r",encoding="utf-8")
print(file.readline())
print(file.readline())
print(file.readline())
print(file.readline())
print(file.readline()) # Okuyacak herhangi bir şey kalmayınca readline fonksiyonu boş satır string döner.

file.close()
 
"""
Çıktı
 
İnclude Program Python
Python Programlama
Java Programlama
Kotlin Programlama
Javascript Programlama
 
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# readlines() fonksiyonu
# readlines() fonksiyonu dosyanın bütün satırları bir liste şeklinde döner.

file = open("bilgiler.txt","r",encoding="utf-8")
file.readlines()
file.close()
 
"""
Çıktı
 
['İnclude Program Python\n',
 'Python Programlama\n',
 'Java Programlama\n',
 'Kotlin Programlama\n',
 'Javascript Programlama\n']
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosyalarda Kullanılan Fonksiyonlar

# Dosyaları Otomatik Kapatma

# Dosyalarda işlemlerimiz bittiği zaman dosyamızı kapatmamız gerektiğini biliyoruz. 
# Ancak programlamacılık doğası gereği çoğu zaman dosyaları kapatmayı unutabiliriz. 
# Bunun için Pythonda dosyalarda işimiz bitince otomatik kapatma özelliği bulunuyor. 
# Bundan sonra Pythonda dosya işlemlerimizi şu blok içinde yapacağız.

with open(dosya_adı,dosya_kipi) as file:
    Dosya işlemleri

# Örneğimize bakalım.

with open("bilgiler.txt","r",encoding = "utf-8") as file:
    for i in file:
        print(i)
 
"""
Çıktı
 
İnclude Program Python
 
Python Programlama
 
Java Programlama
 
Kotlin Programlama
 
Javascript Programlama
"""

# Eğer dosya işlemlerini bu blok içinde yaparsak işlemimiz bittiği zaman dosyamız otomatik olarak kapanacaktır.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosyaları İleri Geri Sarmak

# Biliyorsunuz önceki dersimizde dosyaları okurken sadece dosyanın en başından başlayabiliyorduk ve 
# dosya imlecimiz okuma işleminin sonunda , dosyanın en sonuna gidiyordu. 
# Ancak biz çoğu zaman dosya imlecini (file) dosyanın herhangi bir yerine götürmek isteyebiliriz. 
# Bunun için Pythondaki seek() fonksiyonunu kullanacağız. 
# Ancak ondan önce dosya imlecinin hangi byteda olduğunu söyleyen tell() fonksiyonuna bakalım.

with open("bilgiler.txt","r",encoding = "utf-8") as file:
    print(file.tell())
 
"""
Çıktı
0
"""

# Şu anda hiçbir işlem yapmadığımız için tell() fonksiyonu dosyanın en başında (0. byteda) olduğumuzu söyledi. 
# Peki bir dosya imlecini dosyanın 20.byte’ına götürmek için ne yapacağız ? 
# Bunun için de seek() fonksiyonunu kullanacağız.

with open("bilgiler.txt","r",encoding = "utf-8") as file:
    file.seek(20) # 20.byte götürdük.
    print(file.tell()) 
 
"""
Çıktı
20
"""

# Peki biz bir dosyanın belirli bir byte’ına(karakter) gidip sadece belli sayıda karakteri nasıl okuyacağız ? 
# Eğer biz read() fonksiyonuna bir sayı değeri verirsek sadece o sayı değeri kadar alanı okuyacaktır. Hemen görelim.

with open("bilgiler.txt","r",encoding = "utf-8") as file:
    file.seek(5) # 5.byte gidiyoruz.
    icerik = file.read(10)  # 10 karakteri okuyoruz.
    print(icerik)
    print(file.tell())

"""
Çıktı
n,Java,C,P
15
"""


with open("bilgiler.txt","r",encoding = "utf-8") as file:
    file.seek(5) # 5.byte gidiyoruz.
    icerik = file.read(10)  # 10 karakteri okuyoruz.
    print(icerik)
    file.seek(0)
    icerik2 = file.read(6)
    print(icerik2)
"""
Çıktı
n,Java,C,P
Python
 
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosyalarda Değişiklik Yapmak

# seek() ve write()
# Eğer biz bir dosyanın belli bir yerine seek() fonksiyonu ile gidip, write() fonksiyonunu kullanırsak, 
# yazdığımız değerler öncesinde bulunan değerlerin üzerine yazılacaktır. 
# Bunun için hem okuma hem de yazma işlemimizi yapmamızı sağlayan “r+” kipini kullanacağız. 
# İlk önce dosyamızda bilgileri görelim.

with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    print(file.read())
 
"""
Çıktı
 
İnclude Program Python
Java Programlama
Kotlin Programlama
Python Programlama
 
"""


with open("bilgiler.txt","r+",encoding = "utf-8") as file: 
    file.seek(10) # 10. byte
    file.write("Deneme")


with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    print(file.read())
 
"""
Çıktı

İnclude PrDenemePython
Java Programlama
Kotlin Programlama
Python Programlama
"""

# Bu şekilde bir şeyler yapmak isterseniz bu yöntemi kullanabilirsiniz

# Dosyanın Sonunda Değişiklik Yapmak
# Bu işlemlerin en kolayıyla başlayalım. 
# Dosyaların sonunda değişiklik yapmak için, dosyamızı “a” kipiyle açalım ve sadece dosyanın sonuna write() ile ekleme yapalım.

with open("bilgiler.txt","a",encoding = "utf-8") as file:
    file.write("Javascript Programlama\n") # "append" metoduyla açılan bir dosyanın imleci direk dosyanın sonunda olduğu için sadece write


with open("bilgiler.txt","r",encoding = "utf-8") as file:
    print(file.read())
 
"""
Çıktı
 
İnclude Program Python
Java Programlama
Kotlin Programlama
Python Programlama
Javascript Programlama
"""

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosyanın Başında Değişiklik Yapmak

# “bilgiler.txt” dosyamızın başına bir tane satır eklemek için ne yapabiliriz ? 
# Bunun için dosyamızı bütünüyle string halinde alıp daha sonra satırımızı string’in başına eklememiz gerekiyor. 
# Daha sonra dosyanın en başına seek() fonksiyonuyla giderek ,direk write() fonksiyonunu kullanabiliriz.

with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    icerik = file.read()
    print(icerik)
 
"""
 
Çıktı
 
İnclude Program Python
Java Programlama
Kotlin Programlama
Python Programlama
Javascript Programlama
 
"""


with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    icerik = file.read()
    
    icerik = "Program İnclude\n" + icerik
    file.seek(0)
    file.write(icerik)


with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    icerik = file.read()
    print(icerik)
 
"""
Çıktı
 
Program İnclude
İnclude Program Python
Java Programlama
Kotlin Programlama
Python Programlama
Javascript Programlama
 
"""

# İşte bu kadar ! Son olarak da dosyaların ortasında değişiklik yapmayı öğrenmeye çalışalım.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------ #

# Dosyanın Ortasında Değişiklik Yapmak

# Dosyaların ortasına herhangi bir satır eklemek için ilk olarak her bir satırı liste halinde almamızı sağlayan readlines() fonksiyonunu kullanacağız. 
# Daha sonra bu listenin herhangi bir yerine bir eleman ekleyerek bu listeyi for döngüsü ile dosyaya yazacağız.

with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    print(file.readlines())
 
"""
Çıktı
 
['Program İnclude\n', 'İnclude Program Python\n', 'Java Programlama\n', 'Kotlin Programlama\n', 'Python Programlama\n', 'Javascript Programlama\n']
 
"""

# Örneğin , “Java Programlama” satırının altına bir tane daha satır eklemek istiyoruz. 
# Bunun için bu listenin 3.indeksine insert() metoduyla bir satır ekleyeceğiz. 
# Daha sonra dosyanın en başına giderek bu listeyi tek tek for döngüsü ile yazacağız.

with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    liste = file.readlines()
    liste.insert(3,"Php Programlama\n")
    file.seek(0)
    for satır in liste:
        file.write(satır)


with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    icerik = file.read()
    print(icerik)
 
"""
Çıktı
 
Program İnclude
İnclude Program Python
Java Programlama
Php Programlama
Kotlin Programlama
Python Programlama
Javascript Programlama
 
"""

# Pythonda bir dosyaya listenin içindeki değerleri yazmak için for döngüsü dışında pratik bir fonksiyon bulunuyor. 
# writelines fonksiyonu içine verdiğimiz listeyi dosyaya yazacaktır.

with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    liste = file.readlines()
    liste.insert(3,"Ahmet Baltacı\n")
    file.seek(0)
    file.writelines(liste)
 
with open("bilgiler.txt","r+",encoding = "utf-8") as file:
    icerik = file.read()
    print(icerik)
 
"""
Çıktı
 
Program İnclude
İnclude Program Python
Java Programlama
Ahmet Baltacı
Php Programlama
Kotlin Programlama
Python Programlama
Javascript Programlama
 
"""


# İşte bu kadar ! 
# Gördüğünüz gibi dosyalarda işlem yapabilmek için biraz fazla düşünmemiz gerekiyor.