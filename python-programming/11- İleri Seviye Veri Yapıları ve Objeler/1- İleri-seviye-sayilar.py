#######################################
# Writed by Sinan Özçelik             #
#######################################

# Bu konuda sayı veritiplerini biraz daha derinlemesine incelemeye ve sayılar 
# üzerinde uygulanabilen yararlı fonksiyonları öğrenmeye çalışacağız.

# Bazen programlamada sayılarımızı 10'luk taban haricinde 2'lik(binary) ve 
# 16'lık(hexadecimal) tabanda göstermek ve kullanmak isteyebiliriz.

##################################################################################################################

bin(4) # bin fonksiyonu . Sayımız 2'lik tabanda yazıldı. (1 ve 0)
# Çıktı: '0b100'

bin(19) # bin fonksiyonu . Sayımız 2'lik tabanda yazıldı. (1 ve 0)
# Çıktı: '0b10011'

bin(521) # bin fonksiyonu . Sayımız 2'lik tabanda yazıldı. (1 ve 0)
# Çıktı: '0b1000001001'

##################################################################################################################

# Şimdi de 10'luk tabandaki bir sayıyı 16'lık tabana çevirmek için kullanılan hex() fonksiyonuna bakalım.

hex(32) # Sayımız 16'lık tabanda yazıldı.
# Çıktı: '0x20'

hex(54) # Sayımız 16'lık tabanda yazıldı.
# Çıktı: '0x36'

hex(1212) # Sayımız 16'lık tabanda yazıldı.
# Çıktı: '0x4bc'

##################################################################################################################

# abs fonksiyonu

# Sayının mutlak değerini almamızı sağlar.

abs(-4) # 4

abs(4.5) # 4.5

abs(0) # 0

##################################################################################################################

# round fonksiyonu

# Sayıları alta veya üste yuvarlar.

round(3.7) # 4

round(3.2) # 3

round(3)   # 3

round(3.21329321321323,4) # Ondalıklı sayının 4. hanesine göre yuvarlar
# 3.2133
round(3.21324321321323,4) # Ondalıklı sayının 4. hanesine göre yuvarlar
# 3.2132

##################################################################################################################

# max ve min fonksiyonu

# max() fonksiyonu verdiğimiz değerlerin en büyüğünü döndürür.
# min() fonksiyonu verdiğimiz değerlerin en küçüğünü döndürür.

max(3,4) # İstediğimiz kadar değer verebiliriz.
# 4
max(100,-2,3,4,1,131)  # İstediğimiz kadar değer verebiliriz.
# 131
max([13.2,-4.32,1.2,15.6]) # Sayıları liste şeklinde de verebiliriz.
# 15.6
max((13.2,-4.32,1.2,15.6)) # Sayıları demet şeklinde de verebiliriz.
# 15.6
min(3,4)
# 3
min(100,-2,3,4,1,131)
# -2

##################################################################################################################

# sum fonksiyonu
# sum() fonksiyonu verilen değerleri toplayarak döndürür. Değerlerin liste,demet vb. şeklinde verilmesi gerekir.

sum(3,4) # Hata verir!!!
---------------------------------------------------------------------------
TypeError                                 Traceback (most recent call last)
<ipython-input-43-9b5e45f4f33d> in <module>()
----> 1 sum(3,4)

TypeError: 'int' object is not iterable
---------------------------------------------------------------------------

sum([3,4,5,6,7])
# 25

sum((3,4))
# 7

##################################################################################################################

# pow fonksiyonu

# pow() fonksiyonu üs alma işlemlerinde kullanılır.

pow(2,4) # 2 üzeri 4
# 16

pow(3,4) # 3 üzeri 4
# 81

pow(17,2) # 17 üzeri 2
# 289

##################################################################################################################