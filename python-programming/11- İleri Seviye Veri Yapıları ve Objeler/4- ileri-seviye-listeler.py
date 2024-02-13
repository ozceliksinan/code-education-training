#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################

# append() metodu
# append metodu listenin en sonuna eleman eklememizi sağlar.

liste = [1,2,3,4,5,6,7]
liste.append(34)
liste
# [1, 2, 3, 4, 5, 6, 7, 34]

liste.append("Python")
liste
# [1, 2, 3, 4, 5, 6, 7, 34, 'Python']

##################################################################################################################

# extend() metodu
# extend() metodu bir listeye başka bir listenin elemanları eklememizi sağlar.

liste = [1,2,3,4,5,6,7]
liste.extend([10,11,12])
liste
# [1, 2, 3, 4, 5, 6, 7, 10, 11, 12]

##################################################################################################################

# insert() metodu
# insert() metodu listenin belli bir indeksine bir eleman eklememizi sağlar.

liste = [1,2,3,4,5,6,7,8,9]
liste.insert(2,"Python") # 2.indekse "Python" değerini ekliyoruz.
liste
# [1, 2, 'Python', 3, 4, 5, 6, 7, 8, 9]

##################################################################################################################

# pop() metodu
# pop() metodu içine hiçbir değer vermezsek listenin son elemanını silerek ekrana basar. 
# İçine belli bir indeks değeri verirsek o indeksi siler ve ekrana basar.

liste = [1,2,3,4,5,6,7]
liste.pop() # Son eleman siliniyor.
# 7 listeden çıkarıldı
liste
# [1, 2, 3, 4, 5, 6]

liste.pop(2) # 2.indeksteki eleman siliniyor.
# 3

##################################################################################################################

# remove() metodu
# remove() metodu verdiğimiz değeri listeden çıkarmamızı sağlar.

liste = ["Python","Php","Java","C"]
liste.remove("Python") # Python'ı siliyoruz.
liste
# ['Php', 'Java', 'C']

liste.remove("Javascript") # Listede yok hata verir.
"""
HATA ÇIKTISI

---------------------------------------------------------------------------
ValueError                                Traceback (most recent call last)
<ipython-input-30-0b889355a141> in <module>()
----> 1 liste.remove("Javascript") # Listede yok hata verir.

ValueError: list.remove(x): x not in list
index() metodu
index() metodu verilen bir değerin baştan başlayarak hangi indekste olduğunu söyler. Değer listede yoksa hata döner. Eğer ekstra index değeri belirtilirse, index metodu() değeri bu indeksten itibaren aramaya çalışır.

liste = [1,2,3,4,3,3,5,6,7,8,9]
liste.index(3) # 3 elemanı baştan başlayarak 2.indekste
2
liste.index(3,3) # 3 elemanı 3.indekten itibaren arandığından 4.indekste 
4
liste.index("Python")
---------------------------------------------------------------------------
ValueError                                Traceback (most recent call last)
<ipython-input-39-b87c248e4fc3> in <module>()
----> 1 liste.index("Python")

ValueError: 'Python' is not in list

"""

##################################################################################################################

# count() metodu
# count() metodu verilen bir değerin listede kaç defa geçtiğini sayar.

liste = [1,2,3,4,5,6,1,1,1,1,1,1,1,1,8]
liste.count(1)
# 9
liste.count(10)
# 0

##################################################################################################################

# sort() metodu
# sort() metodu bir listenin elemanlarını sayıysa küçükten büyüğe , string ise alfabetik olarak sıralar. 
# Eğer özellikle içine reverse = True değeri verilirse elemanları büyükten küçüğe sıralar.

liste = [12,-2,3,1,34,100]
liste.sort()
liste
# [-2, 1, 3, 12, 34, 100]

liste2 = ["Python","Php","C","Java"]
liste2.sort()
liste2
# ['C', 'Java', 'Php', 'Python']

liste = [12,-2,3,1,34,100]
liste.sort(reverse = True)
liste
# [100, 34, 12, 3, 1, -2]

liste2 = ["Python","Php","C","Java"]
liste2.sort(reverse = True)
liste2
# ['Python', 'Php', 'Java', 'C']

##################################################################################################################