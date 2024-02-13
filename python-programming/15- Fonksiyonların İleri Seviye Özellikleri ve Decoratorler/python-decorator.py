#######################################
# Writed by Sinan Özçelik             #
#######################################

# *args ve **kwargs

# Fonksiyonlara argüman göndermenin esnek bir şekilde yapıldığını biliyoruz. 
# İsterseniz ilk olarak yıldızlı argümanları hatırlamaya çalışalım.

def fonksiyon(*args): # İstediğimiz sayıda argüman gönderebiliyoruz.
    print(args)
    for i in args:
        print(i)
fonksiyon(1,2,3)
"""
Çıktı
(1, 2, 3)
1
2
3
"""

# ------------------------------------------------------------------------------------------------------------------------------ #

def fonksiyon(**kwargs):
    print(kwargs)
 
fonksiyon(isim = "Sinan", soyisim = "Program", numara = 12345)
 
"""
Çıktı
{'isim': 'Sinan', 'soyisim': 'Program', 'numara': 12345}
"""

# Dikkat ederseniz 2 yıldız koyarak keyword argümanlar ile (anahtar kelimeli argümanlar) fonksiyonumuzu tanımladık ve argümanlara 
# isim vererek fonksiyonumuzu çağırdığımızda isimleri anahtar kelime , argüman değerlerini değer olarak alarak fonksiyonumuz sözlük oluşturdu. 
# İşte keyword argümanlar bu şekilde kullanılabiliyor.

# ------------------------------------------------------------------------------------------------------------------------------ #

def fonksiyon(**kwargs):
    for i,j in kwargs.items():
        print("Argüman İsmi:",i,"Argüman Değeri:",j)
 
fonksiyon(isim = "Sinan", soyisim = "Program", numara = 12345)
 
"""
Çıktı
Argüman İsmi: isim Argüman Değeri: Sinan
Argüman İsmi: soyisim Argüman Değeri: Program
Argüman İsmi: numara Argüman Değeri: 12345
"""

# ------------------------------------------------------------------------------------------------------------------------------ #

# Şimdi de *args ve **kwargs argümanlarını beraber kullanalım.

def fonksiyon(*args,**kwargs):
    for i in args:
        print("Argümanlar:",i)
    print("------------------------------")
    for i ,j in kwargs.items():
        print("Argüman İsmi:",i,"Argüman Değeri:",j)
        
fonksiyon(1,2,3,4,5,6,7,isim = "Sinan",soyisim = "Program", numara = 12345)
"""
Çıktı
Argümanlar: 1
Argümanlar: 2
Argümanlar: 3
Argümanlar: 4
Argümanlar: 5
Argümanlar: 6
Argümanlar: 7
------------------------------
Argüman İsmi: isim Argüman Değeri: Sinan
Argüman İsmi: soyisim Argüman Değeri: Program
Argüman İsmi: numara Argüman Değeri: 12345
"""

# ------------------------------------------------------------------------------------------------------------------------------ #

# İç içe fonksiyonlar
# Pythonda fonksiyonlar da birer obje oldukları için hem bir tane değişkene atanabilirler, hem de başka bir fonksiyonun içinde tanımlanabilirler.

def selamla(isim):
    print("Selam",isim)
selamla("Sinan")
"""
Çıktı
Selam Sinan
"""
# Bir tane değişkene atıyoruz.
merhaba = selamla
print(merhaba) # Obje tipi fonksiyon oldu.
"""
Çıktı
<function __main__.selamla>
"""
merhaba("Sinan") # Fonksiyon olduğu için artık bu isimle de kullanabilirim.
"""
Çıktı
Selam Sinan
"""
del selamla # Selamla fonksiyonunu siliyorum.
print(selamla)

# Hata verir
---------------------------------------------------------------------------
NameError                                 Traceback (most recent call last)
<ipython-input-36-476cfa688e53> in <module>()
----> 1 selamla
 
NameError: name 'selamla' is not defined
 
# selamla objesi silinmesine rağmen merhaba objesi silinmedi.
merhaba("Program") 
"""
Çıktı
Selam Program
"""

# ------------------------------------------------------------------------------------------------------------------------------ #

def fonksiyon():
    def fonksiyon2():
        print("Küçük fonksiyondan Merhaba")
    print("Büyük fonksiyondan Merhaba")
    fonksiyon2() # Tanımladığım fonksiyonu kullanabilirim.
fonksiyon()
"""
Çıktı
Büyük fonksiyondan Merhaba
Küçük fonksiyondan Merhaba
"""

# Lokal bir değişken olduğu için fonksiyon() çağrısından sonra yok oldu.
fonksiyon2()  
# Hata verir.
---------------------------------------------------------------------------
NameError                                 Traceback (most recent call last)
<ipython-input-45-3ffe6a5f72a1> in <module>()
----> 1 fonksiyon2()  # Lokal bir değişken olduğu için fonksiyon() çağrısından sonra yok oldu.
 
NameError: name 'fonksiyon2' is not defined

# Başka bir örnek çözelim.
def fonksiyon(*args): # args : (1,2,3,4,5,6)
    def topla(args): # (1,2,3,4,5,6)
        toplam = 0
        for i in args:
            toplam += i
        return toplam
    print(topla(args))
fonksiyon(1,2,3,4,5,6)
"""
Çıktı
21
"""

# ------------------------------------------------------------------------------------------------------------ #

# Fonksiyonları return ile Dönmek
# Bir fonksiyon aynı zamanda bir obje olduğu için, bu fonksiyonu başka bir fonksiyondan return ile döndürebiliriz.

def fonksiyon(işlem_adı):
    def toplama(*args):
        toplam = 0
        for i in args:
            toplam += i
        return toplam 
    def çarpma(*args):
        çarpım = 1
        for i in args:
            çarpım *= i
        return çarpım
    if işlem_adı == "toplama":
        return toplama
    else:
        return çarpma
deneme = fonksiyon("toplama")
deneme # toplama fonksiyonuna eşit oldu.
deneme(1,2,3,4,5,6,7)
"""
Çıktı
28
"""

deneme2 = fonksiyon("çarpma")
print(deneme2) # çarpma fonksiyonuna eşit oldu.
"""
Çıktı
<function __main__.fonksiyon.<locals>.çarpma>
"""

deneme2(1,2,3,4,5,6,7,8,9)
 
"""
Çıktı
362880
"""

# ------------------------------------------------------------------------------------------------------------ #

# Fonksiyonları Argüman Olarak Göndermek

def toplama(a,b):
    return a + b
def çıkarma(a,b):
    return a-b
def çarpma(a,b):
    return a * b
def bölme(a,b):
    return a / b
 
def anafonksiyon(func1,func2,func3,func4,işlem_adı): # Tanımladığımız 4 fonksiyonu da argüman olarak göndereceğiz.
    if (işlem_adı == "toplama"):
        print(func1(3,4))
    elif (işlem_adı == "çıkarma"):
        print(func2(10,3))
    elif (işlem_adı == "çarpma"):
        print(func3(10,3))
    elif (işlem_adı == "bölme"):
        print(func4(10,4))
    else:
        print("Geçersiz işlem adı...")
anafonksiyon(toplama,çıkarma,çarpma,bölme,"toplama")
anafonksiyon(toplama,çıkarma,çarpma,bölme,"bölme")
 
"""
Çıktı
7
2.5
"""

# ------------------------------------------------------------------------------------------------------------ #

# Decorator Fonksiyonların Oluşturulması ve Kullanılması
# Decorator fonksiyonlar, Pythonda fonksiyonlarımıza dinamik olarak ekstra özellik eklediğimiz fonksiyonlardır ve 
# decorator fonksiyonların kullanımı kod tekrarı yapmamızı engeller. 
# Pythonda decorator fonksiyonlar Flask gibi frameworklerde oldukça fazla kullanılır.

import time
        
def kareleri_hesapla(sayılar):
    sonuç = []
    baslama =  time.time()
    for i in sayılar:
        sonuç.append(i ** 2)
    print("Bu fonksiyon " + str(time.time() - baslama) + " saniye sürdü.")
def küpleri_hesapla(sayılar):
    sonuç = []
    baslama =  time.time()
    for i in sayılar:
        sonuç.append(i ** 3)
    print("Bu fonksiyon " + str(time.time() - baslama) + " saniye sürdü."
print(kareleri_hesapla(range(100000)))
print(küpleri_hesapla(range(100000)))
"""
Çıktı
Bu fonksiyon 0.14309906959533691 saniye sürdü.
Bu fonksiyon 0.1360929012298584 saniye sürdü.
"""

# Bu iki fonksiyonda fonksiyonların çalışma sürelerini ölçmek için time modülünü kullandık. 
# Ancak dikkat ederseniz, hem bu fonksiyonlara ekstradan iş yaptırdık , hem de 2 fonksiyonda da aynı satırları yazdık. 
# Yani, aslında kod tekrarına düştük. Ancak eğer bu fonksiyonlara ekstra özellik ekleyen decorator bir fonksiyonumuz olsaydı, 
# burada ne kod tekrarına düşecektik ne de fonksiyonlara ekstradan satır ekleyecektik. 
# İşte decoratorların tam olarak önemi budur. İsterseniz zaman_hesapla isimli decorator’ımızı ilk önce yazalım. 
# Daha sonra decoratorları açıklamaya çalışalım.

import time
def zaman_hesapla(fonksiyon):
    def wrapper(sayılar):  
        baslama = time.time()
        sonuç =  fonksiyon(sayılar)
        bitis =  time.time()
        print(fonksiyon.__name__ + " " + str(bitis-baslama) + " saniye sürdü.")
        return sonuç
    return wrapper   
# Burada zaman_hesapla() isimli decorator bir fonksiyon yazdık.
@zaman_hesapla
def kareleri_hesapla(sayılar):
    sonuç = []
    for i in sayılar:
        sonuç.append(i ** 2)
    return sonuç
# Burada zaman_hesapla() isimli decorator bir fonksiyon yazdık.
@zaman_hesapla
def küpleri_hesapla(sayılar):
    sonuç = []
    for i in sayılar:
        sonuç.append(i ** 3)
    return sonuç
print(kareleri_hesapla(range(100000)))
print(küpleri_hesapla(range(100000)))
"""
Çıktı
kareleri_hesapla 0.1340925693511963 saniye sürdü.
küpleri_hesapla 0.13509273529052734 saniye sürdü.
"""

# ------------------------------------------------------------------------------------------------------------ #