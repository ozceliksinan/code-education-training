#######################################
# Writed by Sinan Özçelik             #
#######################################

# type() fonksiyonu
# type() fonksiyonu içine gönderilen değerin hangi veri tipinden olduğunu söyler. Class şeklinde belirtir.
# Integer (Tamsayı) türü
a = 65
print(type(a))
# Float (Ondalıklı Sayı) türü
a = 5.87
print(type(a))
# String (Karakter Dizisi) türü
a = "Sinan"
print(type(a))

# sep parametresi
# print() fonksiyonunda kullanılabilen sep parametresi yazdırdığımız değerlerin arasına istediğimiz 
# karakterlerin yerleştirilmesini sağlar. Eğer bu parametreyi kullanmazsak değerlerin arasına 
# varsayılan olarak boşluk yerleştirildiğini biliyoruz.Örneklere bakalım.
print(3,4,5,6,7,8,9)
# sep parametresi sayesinde değerlerin arasına nokta konuyor.
print(3,4,5,6,7,8,9,sep = ".")
# Değerlerin arasında "/" sembolü yerleştiriliyor.
print("06","04","2020",sep = "/")
print("Sinan","Program","Python",sep = "\n")

# Yıldızlı Parametreler
# Eğer bir stringin başına * işareti koyup, print fonksiyonuna gönderirsek bu string karakterlerine 
# ayrılacak ve her bir karakter ayrı birer string olarak davranılarak ekrana basılacaktır.
# Varsayılan olarak karakterlerin arasına boşluk konuluyor.
print(*"Python")
print(*"Python",sep = "\n")
print(*"TBMM",sep =".")

# Formatlama
# Programlama yaparken bazı yerlerde bir stringin içinde daha önceden tanımlı string,float, int vs. 
# değerleri yerleştirmek isteyebiliriz. Böyle durumlar için Pythonda format() fonksiyonu bulunmaktadır. 
# Örneğin, programımızda 3 tane tamsayı değerimiz var ve biz bunları bir string içinde ekrana basmak istiyoruz. 
# Bunun için format() fonksiyonunu kullanabiliriz.
# Burada 3 tane süslü parantezimiz ({}) var ve bunların yerine sırasıyla format fonksiyonun içindeki değerler geçiyor.
print("{} {} {}".format(3.1423,5.324,7.324324))
a = 3
b = 4
print("{} + {} 'nin toplamı {} 'dır".format(a,b,a+b))
# Süslü parantezlerin içindeki sayılar format fonksiyonun içinden hangi sıradaki değerin geleceğini söylüyor.
print("{1} {0} {2}".format(43,"Python",54))
# Süslü parantezlerin içindeki kullanım ondalıklı kısmın sadece 2 basamağına kadar almak istediğimiz söylüyor.
print("{:.2f} {:.2f} {:.3f}".format(3.1463,5.324,7.324324))