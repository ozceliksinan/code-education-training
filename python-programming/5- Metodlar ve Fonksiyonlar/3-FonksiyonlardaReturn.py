#######################################
# Writed by Sinan Özçelik             #
#######################################

# return ifadesi fonksiyonun işlemi bittikten sonra çağrıldığı 
# yere değer döndürmesi anlamı taşır. 
# Böylelikle, fonksiyonda aldığımız değeri bir değişkende depolayabilir 
# ve değeri programın başka yerlerinde kullanabiliriz.

def toplama(a,b,c): # Birinci fonksiyon
    print("Toplamları",a+b+c)
def ikiyleçarp(a): # İkinci fonksiyon
    print("2 ile çarpılmış hali", a * 2)
toplam = toplama(3,4,5)
"""
Çıktı
Toplamları 12
"""

ikiyleçarp(toplam) # Hata Alacağız
# Hatanın sebebi ise toplam değişkenine bir değer atanmamasıdır. 
# Yani program bize NoneType hatası verir.
# Burada hata almamızın sebebi fonksiyonları herhangi bir değer 
# döndürmemesi yani return kullanmamasıdır.

# Burada toplama fonksiyonundan herhangi bir değer döndürülmediği için toplam 
# değişkenimiz hiçbir değere sahip olmadı ve tipi NoneType(atanmamış) olmuş oldu. 
# İsterseniz burada fonksiyonları tekrardan tanımlayalım ve return mantığını anlamaya çalışalım.

def toplama(a,b,c):
    return a+b+c # return'un kullanımı 
def ikiyle_çarp(a):
    return a*2
toplam = toplama(3,4,5)
print(ikiyle_çarp(toplam))
"""
Çıktı
24
"""
# return yardımıyla fonksiyonlar değerleri çağrıldığı yere döndürebilir ve biz de 
# bu değerleri istediğimiz yerde kullanabiliriz.

# Yeni bir örnek yapalım.
def üçleçarp(a):
    print("1.fonksiyon çalıştı")
    return a*3
def ikiyletopla(a):
    print("2.fonksiyon çalıştı")
    return a + 2
def dördeböl(a):
    print("3.fonksiyon çalıştı")
    return a / 4
# 3 ünü beraber kullanalım.
print(dördeböl(ikiyletopla(üçleçarp(5))))
"""
Çıktı
1.fonksiyon çalıştı
2.fonksiyon çalıştı
3.fonksiyon çalıştı
4.25
"""

# return ifadesinden sonra fonksiyonumuz tamamıyla sona erer. 
# Yani, return ifadesinden sonra yapılan herhangi bir işlem çalıştırılmaz.

def toplama(a,b,c):
    return a + b + c
    print("Toplama fonksiyonu") # Çalıştırılmadı.
"""
Çıktı
6
"""

def toplama(a,b,c):
    print("Toplama fonksiyonu") # Çalıştırıldı.
    return a + b + c
toplama(1,2,3)
"""
Çıktı
Toplama fonksiyonu
6
"""