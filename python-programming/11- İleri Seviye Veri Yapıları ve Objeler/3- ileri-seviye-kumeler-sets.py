#######################################
# Writed by Sinan Özçelik             #
#######################################

# Kümeler, matematikte olduğu gibi bir elemandan sadece bir adet tutan bir veritipidir. 
# Bu açıdan kullanıldıkları yerlerde çok önemli bir veritipi olmaktadırlar. İsterseniz hemen bir küme oluşturalım.

##################################################################################################################

# Küme oluşturmak
x =  set() # Boş küme
type(x)
set
liste = [1,2,3,3,1,1,2,2,2] # Aynı elemanı birçok defa  barındıran bir liste
x = set(liste) # Veri tipi dönüşümü
x # Aynı elemanlar tek bir elemana indirgendi.
# {1, 2, 3}

x = set("Python Programlama Dili")  # Aynı karakterler tek bir karaktere indirgendi.
x
# {' ', 'D', 'P', 'a', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'r', 't', 'y'}

x = {"Python","Php","Python"}
x # Aynı elemanlar teke indirgendi.
# {'Php', 'Python'}

##################################################################################################################

# For döngüsüyle Gezinmek
# Kümeler de tıpkı sözlükler gibi sırasız bir veri tipidir. Bunu for döngüsüyle görebiliriz.

x = {"Python","Php","Java","C","Javascript"}
for i in x:
    print(i) 
"""
Çıktı

Php
Python
Java
Javascript
C
"""
# Peki bir kümenin elemanlarına direk olarak ulaşabiliyor muyuz ?

x
{'C', 'Java', 'Javascript', 'Php', 'Python'}
x[0]
"""
HATA ÇIKTISI
---------------------------------------------------------------------------
TypeError                                 Traceback (most recent call last)
<ipython-input-19-1ae75c28907a> in <module>()
----> 1 x[0]

TypeError: 'set' object does not support indexing
x["Python"]
---------------------------------------------------------------------------
TypeError                                 Traceback (most recent call last)
<ipython-input-20-8627f284d48b> in <module>()
----> 1 x["Python"]

TypeError: 'set' object is not subscriptable

Buradaki işlemler aslında kümelerde tanımlı değil. 
Yani biz bir kümenin elemanlarına ne indexle ne de eleman ismiyle erişebiliyoruz. 
Erişmek için mutlaka veritipi dönüşümü yapmamız gerekiyor.
"""
liste = list({1,2,3,4,5})

liste[0]
# 1

##################################################################################################################

# Kümelerin Metodları
# Eleman Eklemek : add() metodu
# Kümeye eleman eklemimizi sağlar. Aynı eleman eklenmeye çalışırsa hata vermez ve herhangi bir ekleme işlemi yapmaz.

x = {1,2,3}
x.add(4)
x
# {1, 2, 3, 4}

x.add(4) # Tekrar eklenmiyor.
x
# {1, 2, 3, 4}

##################################################################################################################

# İki kümenin farkı : difference() metodu
# Bu metod birinci kümenin ikinci kümeden farkını döner.

küme1.difference(küme2) # Küme1'in Küme2'den farkı
küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}
küme1.difference(küme2)
# {-2, 3, 10, 100}
küme2.difference(küme1)
# {-1, 23}
küme1
# {-2, 1, 2, 3, 10, 34, 100}

##################################################################################################################

# İki kümenin farkı ve güncelleme : difference_update() metodu
# Bu metod birinci kümenin ikinci kümeden farkını dönerek birinci kümeyi bu farka göre günceller.

küme1.difference_update(küme2) # Küme1'in Küme2'den farkı
küme1
# {-2, 1, 2, 3, 10, 34, 100}

küme2
# {-1, 1, 2, 23, 34}

küme1.difference_update(küme2)
küme1 # Farka göre güncellendi.
# {-2, 3, 10, 100}

##################################################################################################################

# Kümeden Eleman Çıkartmak : discard() metodu
# İçine verilen değeri kümeden çıkartır. Eğer kümede öyle bir değer yoksa, bu metod hiçbir şey yapmaz(Hata vermez).

küme1 = {1,2,3,4,5,6}
küme1.discard(2)
küme1
# {1, 3, 4, 5, 6}

küme1.discard(10)
küme1
# {1, 3, 4, 5, 6}

##################################################################################################################

# Küme kesişimleri : intersection() metodu
# Bu metod iki kümenin kesişimleri bulmamızı sağlar.

küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}
küme1.intersection(küme2)
# {1, 2, 34}

##################################################################################################################

# Küme kesişimleri ve güncelleme : intersection_update() metodu
# Bu metod birinci kümeyle ikinci kümenin kesişimlerini bulur ve birinci kümeyi bu kesişime göre günceller.

küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}
küme1.intersection_update(küme2)
küme1
# {1, 2, 34}

##################################################################################################################

# Kümeler ayrık küme mi ? : isdisjoint() metodu
# Bu metod, eğer iki kümenin kesişim kümesi boş ise True, değilse False döner.

küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}
küme3 = {30,40,50}
küme1.isdisjoint(küme2)
# False
küme1.isdisjoint(küme3)
# True

##################################################################################################################

# Alt kümesi mi ? : issubset() metodu
# Bu metod , birinci küme ikinci kümenin alt kümesiyse True, değilse False döner.

küme1 = {1,2,3}
küme2 = {1,2,3,4}
küme3 = {5,6,7}
küme1.issubset(küme2)
# True
küme1.issubset(küme3)
# False

##################################################################################################################

# Birleşim Kümesi : union() metodu
# Bu metod, iki kümenin birleşim kümesini döner.

küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}
küme1.union(küme2)
# {-2, -1, 1, 2, 3, 10, 23, 34, 100}

##################################################################################################################

# Birleşim Kümesi ve update : update() metodu
# Bu birinci kümeyle ikinci kümenin birleşim kümesini döner ve birinci kümeyi buna göre günceller.

küme1 = {1,2,3,10,34,100,-2}
küme2 = {1,2,23,34,-1}

küme1.update(küme2)
küme1
# {-2, -1, 1, 2, 3, 10, 23, 34, 100}
##################################################################################################################