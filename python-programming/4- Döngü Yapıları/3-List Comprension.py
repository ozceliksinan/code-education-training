# Bu konuda listeleri üretmek ve oluşturmak Pythonda çok pratik bir yöntem olan “List Comprehension” konusunu öğreneceğiz. 
# Biliyorsunuz Pythonda birçok işimizi çok kısa kodlar halledebiliyoruz. 
# Ancak kodları daha da kısaltmak ve pratik yöntemler kullanmak her zaman isteriz.

# Listelerdeki append metodunu hatırlayalım.
liste = [1,2,3,4]
liste.append(5)
print(liste)

# liste1'den liste2'yi oluşturalım.
liste1 = [1,2,3,4,5]
liste2 = list() # veya liste2 = [] ikisi de boş liste oluşturur.
for i in liste1:
    liste2.append(i) # liste2 'ye liste1 in elemanları for döngüsü yardımıyla atıyoruz.
print(liste2)

# Acaba bu kodumuzu list comprehension ile daha kısa yazabilir miyiz ?
liste1 = [1,2,3,4,5] # Örnek 1 
liste2 = [i for i in liste1] # List Comprehension
print(liste2)

# Örnek 2
liste1 = [1,2,3,4,5] 
liste2 = [i*2 for i in liste1] # List Comprehension
print(liste2)

# Örnek 3
liste1 = [(1,2),(3,4),(5,6)] 
liste2 = [i*j for (i,j) in liste1] # List Comprehension
print(liste2)

# Örnek 4
liste1 = [1,2,3,4,5,6,7,8,9,10] 
liste2 = [i for i in liste1 if not (i == 4 or i == 9)] # List Comprehension
print(liste2)

# Örnek 5
s = "Python" 
liste = [i * 3 for i in s] # List Comprehension
print(liste)


liste = [[1,2,3],[4,5,6,7,8],[9,10,11,12,13,14,15]]
liste2 = list()
for i in liste:
    print(i) ## Buradaki i değeri de aslında bir liste.
"""
Çıktı
[1, 2, 3]
[4, 5, 6, 7, 8]
[9, 10, 11, 12, 13, 14, 15]
"""

liste = [[1,2,3],[4,5,6,7,8],[9,10,11,12,13,14,15]]
liste2 = list()
for i in liste:
    for x in i:
        print("x:",x)
        liste2.append(x)
print(liste2)
"""
Çıktı
x: 1
x: 2
x: 3
x: 4
x: 5
x: 6
x: 7
x: 8
x: 9
x: 10
x: 11
x: 12
x: 13
x: 14
x: 15
[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
"""

# List Comprehension 
liste = [[1,2,3],[4,5,6,7,8],[9,10,11,12,13,14,15]]
liste2 = [x for i in liste for x in i] # Biraz karmaşık
print(liste2)
"""
Çıktı
[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
"""