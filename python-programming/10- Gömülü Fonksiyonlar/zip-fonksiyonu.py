#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################

liste1 = [1,2,3,4,5]
liste2 = [6,7,8,9,10,11]

# sonucu [(1,6),(2,7),(3,8),(4,9),(5,10)] yapmaya çalışalım.

i = 0
sonuç = list()
while (i < len(liste1) and i < len(liste2)):
    sonuç.append((liste1[i],liste2[i]))
    
    i +=1
print(sonuç)

"""
Çıktı

[(1, 6), (2, 7), (3, 8), (4, 9), (5, 10)]
"""

##################################################################################################################

# Peki böyle uzun bir işlemi zip fonksiyonuyla nasıl yaparız ? 
# İsterseniz zip fonksiyonunun kullanımını direk örnek üzerinden görelim.

##################################################################################################################

list(zip(liste1,liste2))

"""
Çıktı

[(1, 6), (2, 7), (3, 8), (4, 9), (5, 10)]
"""

# Burada zip fonksiyonunun kullanımını görüyoruz. 
# zip fonksiyonu listelerin elemanları sırasıyla demet şeklinde gruplayarak bir tane liste oluşturuyor. 
# Başka bir örnek yapalım.

##################################################################################################################

liste1 = [1,2,3,4]
liste2 = [5,6,7,8]
liste3 = ["Python","Php","Java","Javascript","C"]

list(zip(liste1,liste2,liste3))

"""
Çıktı

[(1, 5, 'Python'), (2, 6, 'Php'), (3, 7, 'Java'), (4, 8, 'Javascript')]
"""

##################################################################################################################

# Aynı anda iki liste üzerinde gezinmek
liste1 = [1,2,3,4]
liste2 = ["Python","Php","Java","Javascript"]

for i,j in zip(liste1,liste2):
    print("i:",i,"j:",j)

"""
Çıktı

i: 1 j: Python
i: 2 j: Php
i: 3 j: Java
i: 4 j: Javascript
"""

##################################################################################################################

# Sözlükleri zipleyelim.
sözlük1 = {"Elma":1,"Armut":2,"Kiraz":3}
sözlük2 = {"Sıfır":0,"Bir":1,"İki":2}

list(zip(sözlük1,sözlük2)) # Anahtarlar eşleşti.

"""
Çıktı

[('Elma', 'Sıfır'), ('Armut', 'Bir'), ('Kiraz', 'İki')]

"""

list(zip(sözlük1.values(),sözlük2.values())) # Değerler eşleşti

"""
Çıktı

[(1, 0), (2, 1), (3, 2)]


"""
##################################################################################################################