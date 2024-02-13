#######################################
# Writed by Sinan Özçelik             #
#######################################

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Iteratorların Oluşturulması ve Kullanılması
# Bu konuda iteratorları oluşturmayı, kullanmayı ve kendi objelerimizi iterable (üzerinde gezinilebilecek) olarak nasıl yazarız öğrenmeye çalışacağız. 
# İlk olarak iteratorlar nedir anlamaya çalışalım

# Iteratorlar nedir?
# Iteratorlar aslında Pythonda çoğu yerde biz görmesek de kullanılır. 
# Iteratorlar özellikle for döngülerinde , list comprehensionlarında, ve bir sonraki derste göreceğimiz generatorlarda karşımıza çıkar.
# Iteratorlar en genel anlamıyla üzerinde gezinilebilecek bir objedir ve bu obje her seferinde bir tane eleman döner.
# Pythonda kendisinden iterator oluşturabileceğimiz her obje iterable bir objedir. 
# Örneğin, demetlerden,listelerden ve stringlerden oluşturduğumuz bütün objeler iterable bir objedir.
# Bir objenin iterable olması için hazır metodlar olan __iter()__ ve __next()__ metodlarını mutlaka tanımlaması gerekir.

# Iterator oluşturma
# Bir iterator objesini , iterable bir objeden (liste,demet,string vs) oluşturmak için Pythonda iter() fonksiyonunu kullanıyoruz ve bu 
#  objenin bir sonraki elemanını almak için next() fonksiyonu kullanıyoruz.

liste = [1,2,3,4,5]
print(dir(liste)) # __iter__ metodu tanımlı olduğu için listeler üzerinde iterator oluşturabiliriz.

iterator = iter(liste) # Iterator oluşturma
print(next(iterator)) # next metoduyla sıradaki eleman
print(next(iterator)) # next metoduyla sıradaki eleman
print(next(iterator)) # next metoduyla sıradaki eleman
print(next(iterator)) # next metoduyla sıradaki eleman
print(next(iterator)) # next metoduyla sıradaki eleman
"""
Çıktı
1
2
3
4
5
"""

print(next(iterator)) 
# Eleman kalmadığı için "StopIteration" hatası
----------------------------------------------------------------------------
StopIteration                             Traceback (most recent call last)
<ipython-input-75-9aa5c89bf87c> in <module>()
----> 1 next(iterator) # Eleman kalmadığı için "StopIteration" hatası
 
StopIteration: 
----------------------------------------------------------------------------

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# İşte iterable bir objeden bir iterator’ı bu şekilde oluşturup, next() fonksiyonuyla objenin sıradaki elemanını alabiliyoruz. 
# Ancak eleman kalmayınca StopIterationhatasını alıyoruz. İşte iteratorların kullanımı bu şekildedir. 
# Aslında biz farketmesek de Pythondaki for döngüleri aslında bir objenin üzerinde gezinirken iteratorları kullanır.

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Kendi Iterable Objelerimizi Oluşturmak

# Peki biz kendi oluşturduğumuz veritiplerini nasıl iterable yapacağız ?
# Bunun için oluşturacağımız sınıfların mutlaka __iter()__ ve __next()__ metodlarını tanımlaması gereklidir. 
# Şimdi bir tane kumanda sınıfı oluşturalım ve bu sınıfı iterable yapalım.

class Kumanda():
    def __init__(self,kanal_listesi):
        self.kanal_listesi = kanal_listesi # Kanal Listemiz
        self.index = -1 # İndeksimiz
        
    def __iter__(self):
        return self # iterator oluşturduğumuzda (iter fonksiyonu çağrıldığında )objemizi döneceğiz.
    def __next__(self): # next fonksiyonu çağrıldığında burası çalışacak.
        self.index += 1
        if (self.index < len(self.kanal_listesi)):
            return self.kanal_listesi[self.index]
        else:
            self.index = -1
            raise StopIteration

kumanda = Kumanda(["Kanal d","Trt","Atv","Fox","Bloomberg"]) # Objemizi oluşturuyoruz.
 
iterator =  iter(kumanda) # Objemiz iterable olduğu için iterator oluşturulabilir.
 
print(next(iterator))
print(next(iterator))
print(next(iterator))
print(next(iterator))
print(next(iterator))
 
"""
Çıktı
 
'Kanal d'
'Trt'
'Atv'
'Fox'
'Bloomberg'
"""

print(next(iterator))
----------------------------------------------------------------------------
StopIteration                             Traceback (most recent call last)
<ipython-input-87-3733e97f93d6> in <module>()
----> 1 next(iterator)
 
<ipython-input-78-369bc7ea5e2a> in __next__(self)
     12         else:
     13             self.index = -1
---> 14             raise StopIteration
 
StopIteration: 
----------------------------------------------------------------------------

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Generatorların Oluşturulması ve Kullanılması

# Generatorlar Pythonda iterable objeler (örnek olarak fonksiyonlar) oluşturmak için kullanılan objelerdir ve bellekte herhangi bir yer kaplamazlar. 
# Örneğin, 100.000 tane değer üretip, bu değerleri bir listede tutmak bellekte oldukça fazla yer kaplayacaktır. 
# O yüzden bu işlemi gerçekleştiren bir fonksiyonu generator fonksiyon şeklinde yazmak oldukça mantıklı olacaktır. 
# Generatorları anlamak için isterseniz bir fonksiyonu ilk olarak generator kullanmadan yazmaya çalışalım.

def karelerial():
    sonuç = []
    
    for i in range(1,6):
        sonuç.append(i**2)
    return sonuç
 
 
print(karelerial())
 
"""
Çıktı
 
[1, 4, 9, 16, 25]
 
"""

# İsterseniz bu fonksiyonu bir de generator kullanarak yazmaya çalışalım. 
# Generatorlerin değer üretmesi için yield anahtar kelimesini kullanacağız.

def karelerial():
    for i in range(1,6):
        yield i ** 2 # yield anahtar kelimesi generator'un değer üretmesi için kullanılıyor.
generator =  karelerial()
 
print(generator) # Generator objesi
 
"""
Çıktı
 
<generator object karelerial at 0x0000009441354DB0>
 
 
"""

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Yazdığımız ilk fonksiyonda 1’den 6’ya kadar gidip her bir değerin karesini sonuç isimli listeye atıyoruz ve daha sonra bu listeyi dönüyoruz.
# Yani bellekte liste değişkenin içinde 1,4,9,16,25 değerleri tutuluyor.

# Generatorle yazdığımız 2.fonksiyonda yield anahtar kelimesiyle değerleri ürettiğimizi sanıyoruz. 
# Ama aslında bu fonksiyonu çağırınca bize sadece bir tane generator objesi dönüyor ve biz sadece generator 
# objesinin değerlerine ulaşmaya çalıştığımızda değerler tek tek üretiliyor. 
# Yani kısacası bellekte değerler tutulmuyor. 
# Bu generator objesinin üzerinde bir tane iterator oluşturarak durumu daha iyi anlamaya çalışalım.

iterator = iter(generator)
 
print(next(iterator)) # 1 değeri üretildi
print(next(iterator)) # 4 değeri üretildi 1 değeri tarihe karıştı.
print(next(iterator)) # 9 değeri üretildi 4 değeri tarihe karıştı.
print(next(iterator)) # 16 değeri üretildi 9 değeri tarihe karıştı
print(next(iterator)) # 25 değeri üretildi 16 değeri tarihe karıştı.
print(next(iterator)) # Üretilecek değer kalmadı.
 
"""
Çıktı
 
1
4
9
16
25
---------------------------------------------------------------------------
StopIteration                             Traceback (most recent call last)
<ipython-input-9-dd39ed4db3a3> in <module>()
      6 print(next(iterator))
      7 print(next(iterator))
----> 8 print(next(iterator))
 
StopIteration: 
 
"""

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Aslında generator objesi sadece değerlere ulaşmak istediğimiz zaman yield anahtar kelimesini kullanıp değer üretiyor. 
# Yani generatorler sadece biz değerlere ulaşmak istersek çalışıyor. 
# İşte generatorlerin mantığı tamamıyla bu şekilde ! Şimdi de list comprehensionları generatorlara çevirmeye çalışalım.

liste = [i * 3 for i in range(5)]
 
print(liste)
 
"""
 
Çıktı
 
[0, 3, 6, 9, 12]
 
"""

# Böyle bir list comprehension’ı generator objesine çevirmek için [] yerine () kullanıyoruz.

generator = (i * 3 for i in range(5))
 
print(generator)
 
"""
Çıktı
 
<generator object <genexpr> at 0x0000009441374990>
 
"""
iterator = iter(generator)
 
print(next(iterator))
print(next(iterator))
print(next(iterator))
print(next(iterator))
print(next(iterator))
print(next(iterator))
 
"""
Çıktı
 
0
3
6
9
12
---------------------------------------------------------------------------
StopIteration                             Traceback (most recent call last)
<ipython-input-32-369d18de2e56> in <module>()
----> 1 print(next(iterator))
 
StopIteration: 
 
"""

# --------------------------------------------------------------------------------------------------------------------------------------------------- #