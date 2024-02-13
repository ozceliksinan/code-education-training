# Fonksiyonlar programlamada belli işlevleri olan ve tekrar tekrar kullandığımız yapılardır.
# Örneğin print() fonksiyonunun görevi içine gönderdiğimiz değerleri ekrana yazdırdırmaktır. 
# Bu fonksiyon Python geliştiricileri tarafından bir defa yazılmış ve biz de bu fonksiyonu 
# programlarımızın değişik yerlerinde tekrar tekrar kullanıyoruz. 
# İşte fonksiyonların kullanım amacı tam olarak budur. Fonksiyonlar bir defa tanımlanır ve 
# programlarda ihtiyacımız olduğu zaman kullanırız. 
# Ayrıca fonksiyonlar kod tekrarını engeller ve kodlarımız daha derli toplu durur.

# Python geliştiricilerin yazdığı fonksiyonlara yani bizim hazır kullandığımız fonksiyonlara
# (print(),type() vs.) gömülü fonksiyonlar(built-in function) denilmektedir.
# Ancak bunlardan hariç olarak biz kendi özel fonksiyonlarımızı(user-defined functions) 
# da tanımlayabiliriz.

# Fonksiyonların Tanımlanması
# def fonksiyon_adı(parametre1,parametre2..... (opsiyonel)):
#     # Fonksiyon bloğu
#     Yapılacak işlemler
#     # dönüş değeri - Opsiyonel

def selamla(): 
    print("Selam arkadaşlar...")
    print("Nasılsınız?")
type(selamla) 
# Fonksiyonumuz tanımlandı.
"""
Çıktı
function
"""

# Fonksiyonların Kullanılması veya Çağrılması (Function Call)
selamla()
"""
Çıktı
Selam arkadaşlar...
Nasılsınız?
"""

selamla("python") 
# Hata verdi çünkü fonksiyonumuz hiçbir değer almıyor.

# Parametreler ve Argümanlar

def selamla(isim): # isim değişkenimiz burada parametre olmaktadır
    print("Merhaba:",isim)
selamla("İnclude") # "İnclude" değeri burada  argüman olmaktadır. 
selamla("Program") # "Program" değeri burada  argüman olmaktadır. 
"""
Çıktı
Merhaba: İnclude
Merhaba: Program
"""

# Şimdi de örnek olması açısından bir sayının faktoriyelini hesaplayan bir fonksiyon yazalım.
# Eğer sayımız “5” ise faktoriyel 5 x 4 x 3 x 2 x 1 = 120 olacaktır
def faktoriyel(sayı):
    faktoriyel = 1
    if (sayı == 0 or sayı == 1):
        print("Faktoriyel",faktoriyel)
    else:
        while (sayı >= 1):
            faktoriyel *= sayı
            sayı -=1
        print("Faktoriyel", faktoriyel)