#######################################
# Writed by Sinan Özçelik             #
#######################################

# Varsayılan değerleri anlamak için selamla fonksiyonunu varsayılan 
# parametre değeri ile yazalım.

def selamla(isim = "İsimsiz"):
    print("Selam",isim)
selamla() 
# Hiç bir değer göndermedik. "isim" parametresinin değeri
# varsayılan olarak "İsimsiz" olarak belirlendi
selamla("Program") 
# Değer verirsek varsayılan değerin yerine bizim verdiğimiz değer geçer.  
"""
Çıktı
Selam İsimsiz
Selam Program
"""

# İşte bu kadar ! Peki birçok parametreye sahip olursak ne olacak ? 
# Bir fonksiyon daha tanımlayalım.

def bilgilerigöster(ad = "Bilgi Yok",soyad = "Bilgi Yok",numara =  "Bilgi Yok"):
    print("Ad:",ad,"Soyad:",soyad,"Numara:",numara)
bilgilerigöster() 
# Bütün parametreler varsayılan değerle ekrana basılacak.
bilgilerigöster("İnclude Program","Python") 
# ad ve soyad değerini verdik  ancak numara parametresi varsayılan değer oldu. 
"""
Çıktı
Ad: Bilgi Yok Soyad: Bilgi Yok Numara: Bilgi Yok
Ad: İnclude Program Soyad: Python Numara: Bilgi Yok
"""

# Aslında biz varsayılan değerleri kursumuzun en başlarında görmüştük. print fonksiyonunun sep parametresini hatırlayalım.

print("İnclude","Program","Python") 
# sep parametresine değer vermeyince varsayılan olarak boşluk karakteri verildi.
print("İnclude","Program","Python",sep = "/") 
# sep parametresine özel olarak değer atadık.
"""
Çıktı
İnclude Program Python
İnclude/Program/Python
"""

# Peki ben bir fonksiyonu esnek sayıda argümanla kullanmak istersem ne yapacağım ? 
# Bunun için de Yıldızlı Parametre kullanmam gerekiyor. Kullanımı şu şekildedir;
def toplama(*parametreler): 
	# Artık parametreler değişkenini bir demet gibi kullanabilirim.
    toplam =  0
    print("Parametreler:",parametreler)
    for i in parametreler:
        toplam += i
    return toplam
print(toplama(3,4,5,6,7,8,9,10))
"""
Çıktı
Parametreler: (3, 4, 5, 6, 7, 8, 9, 10)
52
"""
# print fonksiyonunu tekrar hatırlayacak olursak aslında print fonksiyonu 
# bu şekilde tanımlanmış bir fonksiyondur. 
# Çünkü biz print fonksiyonuna istediğimiz sayıda argüman gönderebiliyorduk.