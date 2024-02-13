#######################################
# Writed by Sinan Özçelik             #
#######################################

# Problem 1
# Elinizde stringlerin bulunduğu bir liste bulunduğunu düşünün.

# liste = ["345","sadas","324a","14","Sinan"]

# Bu listenin içindeki stringlerden içinde sadece rakam bulunanları ekrana yazdırın. 
# Bunu yaparken try,except bloklarını kullanmayı unutmayın.

liste = ["345","sadas","324a","14","Sinan"]

for eleman in liste:
    
    try: 
        eleman = int(eleman) # Eğer hata ile karşılaşırsak burası hata verecek ve print çalışmayacak.
        print(eleman)
    except:
        pass # pass deyimi bir blokun hiçbir şey yapmadığı anlamına geliyor. Python'ın hata vermemesi için kullanabilirsiniz.
"""
Çıktı:

345
14
"""


# Problem 2
# Bir sayının çift olup olmadığını sorgulayan bir fonksiyon yazın. 
# Bu fonksiyon, eğer sayı çift ise return ile bu değeri dönsün. 
# Ancak sayı tek sayı ise fonksiyon raise ile ValueError hatası fırlatsın. 
# Daha sonra, içinde çift ve tek sayılar bulunduran bir liste tanımlayın ve liste üzerinde gezinerek ekrana sadece çift sayıları bastırın.

def çift_mi(sayı):
    
    if (sayı % 2 == 0):
        return sayı
    else:
        raise ValueError
liste = [34,2,1,3,33,100,61,1800]

for i in liste:
    try:
        print(çift_mi(i))
    except ValueError:
        pass

"""
Çıktı:

34
2
100
1800
"""