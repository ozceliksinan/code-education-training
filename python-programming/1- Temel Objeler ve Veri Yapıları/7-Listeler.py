#######################################
# Writed by Sinan Özçelik             #
#######################################

# Liste Oluşturma
# Listeler bir [] köşeli parantez içine veriler veya değerler konarak oluşturulabilir.

# liste değişkeni. Değişik veri tiplerinden değerleri saklayabiliyoruz.
liste =  [3,4,5,6,"Elma",3.14,5.324]
print(liste)

# Boş liste
boş_liste = []
print(boş_liste)

# Boş liste . list() fonksiyonuyla da oluşturulabilir.
boş_liste = list()
print(boş_liste)

# len fonksiyonu listeler üzerinde de kullanılabilir.
liste3 = [3,4,5,6,6,7,8,9,0,0,0]
print(len(liste3))
# Çıktı 11

# Bir string list() fonksiyonu yardımıyla listeye dönüştürülebilir.
s =  "Merhaba"
lst =  list(s)
print(lst)
# Çıktı
# ['M', 'e', 'r', 'h', 'a', 'b', 'a']

# Listeleri Indeksleme ve Parçalama
# Listeleri indeksleme ve parçalama stringlerle birebir olarak aynıdır.
liste = [3,4,5,6,7,8,9,10]
print(liste)
# 0. eleman 
print(liste[0])
# 4. eleman 
print(liste[4])
# Sonuncu Eleman
print(liste[len(liste)-1])
# Baştan 4. indekse kadar (dahil değil)
print(liste[:4])
# 1.indeksten 5.indekse kadar
print(liste[1:5])
print(liste[5:])
print(liste[::2])
print(liste[::-1])

# Temel Liste Metodları ve İşlemleri
liste1 =  [1,2,3,4,5]
liste2 =  [6,7,8,9,10]
print(liste1 + liste2)

# Bir listeye bir tane eleman eklemek içinse aşağıdaki işlemi uygulayabiliriz.
liste = [1,2,3,4]
liste =  liste + ["Program"]
print(liste)

# Bir listeyi bir tamsayıyla da çarpabiliriz.
liste = [1,2,3,4,5]
print(liste * 3)
print(liste) # Ama gördüğümüz gibi listemiz değişmiyor.
liste = liste * 3 
print(liste) # Eşitleme yaptığımız için liste değişti.

# append metodu
# append metodu, verdiğimiz değeri listeye eklememizi sağlar.
liste = [3,4,5,6]
liste.append(7)
liste.append("Program")
print(liste)

# pop metodu
# Bu metod, içine değer vermezsek listenin son indeksindeki elemanı, değer verirsek verdiğimiz değere 
# karşılık gelen indeksteki elemanı listeden atar ve attığı elemanı ekrana basar.
liste = [1,2,3,4,5]
liste.pop()
print(liste)

# 2. indisi yani 3. elemanı çıkarır.
eleman = liste.pop(2)
print(eleman)
print(liste)

# sort metodu
# sort metodu listenin elemanlarını sıralamamızı sağlar. 
liste = [34,1,56,334,23,2,3,19]
liste.sort() # Küçükten büyüğe sıralar.
print(liste)
liste.sort(reverse = True) # Büyükten küçüğe sıralar.
print(liste)
liste = ["Elma","Armut","Muz","Kiraz"]
liste.sort() # Alfabetic olarak küçükten büyüğe
print(liste)

# İç içe Listeler
# Bir listenin içinde başka bir liste bulundurmak mümkündür. Bunlara Pythonda içiçe listeler denmektedir. 
# Bu tip bir özellik, Pythonda ağaç yapılarında veya matris yapılarında oldukça kullanışlı olmaktadır.
# 3 Tane liste oluşturalım.
liste1 = [1,2,3]
liste2 = [4,5,6]
liste3 = [7,8,9]
yeniliste = [liste1,liste2,liste3]
print(yeniliste)
# Şimdi, 2. listenin ilk elemanına nasıl ulaşacağımıza bakalım.
# 1.elemanın 0.elemanı
print(yeniliste[1][0])
# Çıktı 4