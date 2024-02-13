#######################################
# Writed by Sinan Özçelik             #
#######################################

# Hatalar ve İstisnalar (Exceptions)
# Python programlarında bazen bir değişkenin tanımlanmadan kullanılmaya çalıştırılması , 
# bazen de yapılamayacak bir aritmetik işlemin yapılması Pythonda hatalara yol açar. 
# Ancak bu istisnai durumlarda, hataların türüne göre programlarımızı daha güvenli bir şekilde yazabiliriz.
# Yani hata çıkarabilecek kodlarımızı öngörerek bu hataları programlarımızda yakalayabiliriz. 
# Pythondaki bazı hatalara şunlar örnek verilebilir;

print(a) # Tanımlı değil - Name Error hatası
 
"""
Çıktı
 
---------------------------------------------------------------------------
NameError                                 Traceback (most recent call last)
<ipython-input-1-01c78f0f4f60> in <module>()
----> 1 print(a) # Tanımlı değil
 
NameError: name 'a' is not defined
---------------------------------------------------------------------------
"""

int("sdas324234") # Value Error Hatası
 
"""
Çıktı
 
---------------------------------------------------------------------------
ValueError                                Traceback (most recent call last)
<ipython-input-3-a9d99df9a3df> in <module>()
----> 1 int("sdas324234") # Value Error Hatası
 
ValueError: invalid literal for int() with base 10: 'sdas324234'
---------------------------------------------------------------------------
"""

2 / 0 # Bir sayı 0'a bölünemez.
 
"""
Çıktı
 
---------------------------------------------------------------------------
ZeroDivisionError                         Traceback (most recent call last)
<ipython-input-4-a27cfecb694d> in <module>()
----> 1 2 / 0 # Bir sayı 0'a bölünemez.
 
ZeroDivisionError: division by zero
---------------------------------------------------------------------------
"""

# Bunun gibi Pythonda yüzlerce hata bulunur. Ancak bunların hiçbirini ezberlememize gerek yok. 
# Kodumuzun durumuna göre zaten biz hataları çıktı olarak görebiliyoruz. 
# Ama , siz yine de bunların neler olduğuna bakmak isterseniz Python'ın resmi sitesine bakabilirsiniz.

# Hatalar
# Python programlarında bazen bir değişkenin tanımlanmadan kullanılmaya çalıştırılması , bazen de yapılamayacak bir aritmetik işlemin yapılması Pythonda hatalara yol açar. 
# Ancak bu istisnai durumlarda, hataların türüne göre programlarımızı daha güvenli bir şekilde yazabiliriz.
# Yani hata çıkarabilecek kodlarımızı öngörerek bu hataları programlarımızda yakalayabiliriz. 
# Pythondaki bazı hatalara şunlar örnek verilebilir;

# Hata Yakalama – try,except,finally
# try , except blokları
# try ,except bloklarının yapısı şu şekildedir;

# try:
#     Hata çıkarabilecek kodlar buraya yazılıyor.
#     Eğer hata çıkarsa program uygun olan except bloğuna girecek.
#     Hata oluşursa try bloğunun geri kalanındaki işlemler çalışmayacak.
# except Hata1:
#     Hata1 oluştuğunda burası çalışacak.
# except Hata2:
#     Hata2 oluştuğunda burası çalışacak.

try:
    a =  int("324234dsadsad") # Burası ValueError hatası veriyor.
    print("Program burada")
except: # Hatayı belirtmezsek bütün hatalar bu kısma giriyor.
    print("Hata oluştu")  # Burası çalışır.
print("Bloklar sona erdi")
"""
Çıktı
Hata oluştu
Bloklar sona erdi
"""

# Burada a = int(“324234sadsad”) kodu sıkıntı verdiği için program bu bloktan çıkarak direk 
# except bloğuna girdi ve “Hata oluştu” yazdı. try ,except bloğu bitince program ekrana “Bloklar sona erdi” yazdırdı.

try:
    a =  int("324234") # Burası normal çalışıyor
    print("Program burada")
except ValueError: # Hatayı belirtirsek ValueError hatası bu kısma giriyor.
    print("Hata oluştu") # Hata olmadığı için çalışmadı.
print("Bloklar sona erdi")
"""
Çıktı
Program burada
Bloklar sona erdi
"""

#------------------------------------------------------------------------------------------------------------------------#

# Örnek 2
# Şimdi de 2 adet sıkıntı çıkaran kodumuz bulunsun. Birincisi ZeroDivisionError , diğeri ValueError hatası.

try:
    a = int(input("Sayı1:"))
    b = int(input("Sayı2:")) # Hata burada oluşuyor. ValueError'a bloğuna giriyoruz. 
    print(a / b)
except ValueError:
    print("Lütfen inputları doğru girin.")
except ZeroDivisionError:
    print("Bir sayı 0'a bölünemez.")
 
"""
Çıktı
Sayı1:12
Sayı2:12sdasdad
Lütfen inputları doğru girin.
"""


try:
    a = int(input("Sayı1:"))
    b = int(input("Sayı2:"))
    print(a / b) # Hata burada oluşuyor. ZeroDivisionError'a bloğuna giriyoruz.
except ValueError:
    print("Lütfen inputları doğru girin.")
except ZeroDivisionError:
    print("Bir sayı 0'a bölünemez.")
"""
Çıktı
Sayı1:12
Sayı2:0
Bir sayı 0'a bölünemez.
"""


try:
    a = int(input("Sayı1:"))
    b = int(input("Sayı2:"))
    print(a / b) 
except (ValueError,ZeroDivisionError):
    print("ZeroDivision veya ValueError hatası"),
"""
Çıktı
Sayı1:12
Sayı2:213213sadsadsadasd
ZeroDivision veya ValueError hatası
"""

#------------------------------------------------------------------------------------------------------------------------#

# try,except,finally blokları
# Bazen programlarımızda her durumda mutlaka çalışmasını istediğimiz kodlar bulunabilir.
# Bunun için biz kendi try,except bloklarına ek olarak bir tane finally bloğu ekleyebiliriz. 
# finally blokları hata olması veya olmaması durumunda mutlaka çalışacaktır. Yapısı şu şekildedir;

 try:
	Hata çıkarabilecek kodlar buraya yazılıyor.
	Eğer hata çıkarsa program uygun olan except bloğuna girecek.
	Hata oluşursa try bloğunun geri kalanındaki işlemler çalışmayacak.
except Hata1:
	Hata1 oluştuğunda burası çalışacak.
except Hata2:
	Hata2 oluştuğunda burası çalışacak.
finally:
	Mutlaka çalışması gereken kodlar buraya yazılacak.
	Bu blok her türlü çalışacak.

try:
    a = int(input("Sayı1:"))
    b = int(input("Sayı2:"))
    print(a / b) # Hata burada oluşuyor. ZeroDivisionError'a bloğuna giriyoruz.
except ValueError:
    print("Lütfen inputları doğru girin.")
except ZeroDivisionError:
    print("Bir sayı 0'a bölünemez.")
finally:
    print("Her durumda çalışıyorum.")
"""
Çıktı
Sayı1:12
Sayı2:213213aaaaa
Lütfen inputları doğru girin.
Her durumda çalışıyorum.
"""

#------------------------------------------------------------------------------------------------------------------------#
# Hata fırlatmak
# Bazen kendi yazdığımız fonksiyonlar yanlış kullanılırsa kendi hatalarımızı üretip Pythonda bu hataları fırlatabiliriz. 
# Bunun içinde raise anahtar kelimesini kullanacağız. Hata fırlatma şu şekilde yapılabilmektedir;

# raise HataAdı(opsiyonel hata mesajı)

# Verilen string'i ters çevirmek
def terscevir(s):
    if (type(s) != str):
        raise ValueError("Lütfen doğru bir input girin.")
    else:
        return s[::-1]
    
print(terscevir("Python"))  # Hata vermiyor.
# Bu kod düzgün çalışır çünkü veri olarak string girilmiştir.
"""
Çıktı
nohtyP
"""
print(terscevir(12))
# Bu kod hata verir. Çünkü string bir veri girilmemiştir.
# Hata Kodu aşağıdaki gibi olur.
---------------------------------------------------------------------------
ValueError                                Traceback (most recent call last)
<ipython-input-23-affc1a0b50fd> in <module>()
----> 1 print(terscevir(12))
 
<ipython-input-20-8f7e1cd7e827> in terscevir(s)
      2 def terscevir(s):
      3     if (type(s) != str):
----> 4         raise ValueError("Lütfen doğru bir input girin.")
      5     else:
      6         return s[::-1]
 
ValueError: Lütfen doğru bir input girin.
---------------------------------------------------------------------------