# Kendi veri tiplerimizi oluşturmak ve bu veri tiplerinden objeler üretmemiz 
# için öncelikle objeleri üreteceğimiz yapıyı tanımlamamız gerekiyor. 
# Bunu tasarladığımız yapıya da sınıf veya ingilizce ismiyle class diyoruz. 
# Şimdi class yapılarını öğrenerek konumuza başlayalım.

# Class Anahtar Kelimesi
# Sınıflar veya Classlar objelerimizi oluştururken objelerin özelliklerini ve metodlarını 
# tanımladığımız bir yapıdır ve biz herbir objeyi bu yapıya göre üretiriz. 
# İsterseniz bir Araba classı tanımlayarak yapımızı kurmaya başlayalım.

#  Yeni bir Araba veri tipi oluşturuyoruz.
class Araba():
    model =  "BMW 3.16i"
    renk = "Gümüş"            # Sınıfımızın özellikleri (attributes)
    beygir_gücü = 156
    silindir = 8

# Sınıfımızı Pythonda tanımladık. 
# Peki bu sınıftan obje nasıl oluşturacağız ? 
# Bunu da şu şekilde yapabiliyoruz.

# obje_ismi = Sınıf_İsmi(parametreler(opsiyonel))

araba1 =  Araba() # Araba veri tipinden bir "araba1" isminde bir obje oluşturduk.
print(araba1) # Objemizin veri tipi Araba
"""
Çıktı
<__main__.Araba at 0x8b9f76f860>
"""
print(type(araba1))
"""
Çıktı
__main__.Araba
"""

# araba1 objesi artık sınıfta tanımladığımız bütün özelliklere (attributes) sahip olmuş oldu. 
# İşte sınıf ve obje üretmek bu şekilde olmaktadır. Peki bu araba objesinin özelliklerinin nasıl görebiliriz ?

# obje_ismi.özellik_ismi

print(araba1.model)
print(araba1.renk)
print(araba1.beygir_gücü)
print(araba1.silindir)
"""
Çıktı
'BMW 3.16i'
'Gümüş'
156
8
"""

# __init__()

# Aslında init metodu Pythonda yapıcı(constructor ) fonksiyon olarak tanımlanmaktadır. 
# Bu metod objelerimiz oluşturulurken otomatik olarak ilk çağrılan fonksiyondur. 
# Bu metodu özel olarak tanımlayarak objelerimizi farklı değerlerle oluşturabiliriz.

class Araba():
    def __init__(self,model,renk,beygir_gücü,silindir): # Parametrelerimizin değerlerini objelerimizi oluştururken göndereceğiz.
        self.model =  model # self.özellik_ismi = parametre değeri şeklinde objemizin model özelliğine değeri atıyoruz.
        self.renk = renk # self.özellik_ismi = parametre değeri şeklinde objemizin renk özelliğine değeri atıyoruz.
        self.beygir_gücü = beygir_gücü # self.özellik_ismi = parametre değeri şeklinde objemizin beygir_gücü özelliğine değeri atıyoruz.
        self.silindir = silindir # self.özellik_ismi = parametre değeri şeklinde objemizin silndir özelliğine değeri atıyoruz.
# araba1 objesini oluşturalım.
# Artık değerlerimizi göndererek objelerimizin özelliklerini istediğimiz değerle başlatabiliriz.
araba1 = Araba("Peugeot 206","Siyah",90,4) 
# araba2 objesini oluşturalım.
araba2 = Araba("BMW 3.16i","Gümüş",110,4)
print(araba1.model)
print(araba1.renk)
print(araba2.model)
print(araba2.renk)
"""
Çıktı
'Peugeot 206'
'Siyah'
'BMW 3.16i'
'Gümüş'
"""

# İstersek init metodunu varsayılan değerlerle de yazabiliriz.
class Araba():
    def __init__(self , model = "Bilgi Yok",renk = "Bilgi Yok",beygir_gücü = 75 ,silindir = 4): 
        self.model =  model 
        self.renk = renk 
        self.beygir_gücü = beygir_gücü 
        self.silindir = silindir
araba1 = Araba(beygir_gücü = 85, renk = "Siyah")
print(araba1.renk)
print(araba1.model)
"""
Çıktı
'Siyah'
'Bilgi Yok'
"""