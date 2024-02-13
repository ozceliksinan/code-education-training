#######################################
# Writed by Sinan Özçelik             #
#######################################

# in Operatörü
# Pythondaki in operatörü , bir elemanın başka bir listede,demette veya 
# stringte (karakter dizileri) bulunup bulunmadığını kontrol eder. Kullanımı şu şekildedir;
"a" in "merhaba"
"mer" in "merhaba"
"t" in "merhaba"
4 in [1,2,3,4]
10 in [1,2,3,4]
4 in (1,2,3)
# True veya False döndürür.

# for Döngüsü
# for Döngüsü , listelerin ,demetlerin, stringlerin ve hatta sözlüklerin 
# üzerinde dolaşmamızı sağlayan bir döngü türüdür. Yapısı şu şekildedir.

liste = [1,2,3,4,5,6,7]
for eleman in liste:
    print("Eleman",eleman)

# Liste elemanlarını toplama
liste = [1,2,3,4,5,6,7]
toplam = 0
for eleman in liste:
    toplam += eleman
print("Toplam",toplam)

# Çift elemanları bastırma
liste = [1,2,3,4,5,6,7,8,9]
 
for eleman in liste:
    if eleman % 2 == 0:
        print(eleman)

# Karakter Dizileri Üzerinde Gezinmek (Stringler)
s =  "Python"
for karakter in s:
    print(karakter)

# Her bir karakterleri 3 ile çarpma
s = "Python"
 
for karakter in s:
    print(karakter * 3)

# Demetler üzerinde gezinmek (Demetler)
# Listelerle aynı mantık
demet =  (1,2,3,4,5,6,7)
 
for eleman in demet:
    print(eleman)

# Listelerin için 2 boyutlu demetler
liste = [(1,2),(3,4),(5,6),(7,8)]
for eleman in liste:
    print(eleman) # Herbir elemanın  demet olduğu görebiliyoruz.

# Demet içindeki herbir elemanı almak için pratik yöntem
liste = [(1,2),(3,4),(5,6),(7,8)]
for (i,j) in liste:
    print(i,j)

# Demet içindeki elemanları çarpalım.
liste = [(1,2,3),(4,5,6),(7,8,9),(10,11,12)]
for (i,j,k) in liste:
    print(i * j * k)

# Sözlükler üzerinde gezinmek (Dictionary)
# Hatırlarsanız, sözlükler konusunda 3 adet metod görmüştük. 
# (keys(),values(),items()). İsterseniz bunları burada hatırlayalım.

sözlük = {"bir":1,"iki":2,"üç":3,"dört":4}
print(sözlük.keys())
print(sözlük.values())
print(sözlük.items())

# Python sonuçları dict_keys,dict_values,dict_items olarak vermesine rağmen 
# bunlar üzerinde liste veya demet üzerinde gezinir gibi for döngüsüyle gezinebiliriz.
sözlük = {"bir":1,"iki":2,"üç":3,"dört":4}
for eleman in sözlük:
    print(eleman)

# keys() - Aynı şey
sözlük = {"bir":1,"iki":2,"üç":3,"dört":4}
for eleman in sözlük.keys():
    print(eleman)

# values() 
sözlük = {"bir":1,"iki":2,"üç":3,"dört":4}
for eleman in sözlük.values():
    print(eleman)

# items() 
sözlük = {"bir":1,"iki":2,"üç":3,"dört":4}
for (i,j) in sözlük.items():
    print("Anahtar:",i,"Değer:",j)