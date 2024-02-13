#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################
# Problem 1

# Elinizde bir dikdörtgenin kenarlarını ifade eden sayı çiftlerinin bulunduğu bir liste olsun.

	# [(3,4),(10,3),(5,6),(1,9)]

# Şimdi kenar uzunluklarına göre dikdörtgenin alanını hesaplayan bir fonksiyon yazın ve 
# bu listenin her bir elemanına bu fonksiyonu uygulayarak ekrana şöyle bir liste yazdırın.
    # [12, 30, 30, 9]

# Not : map() fonksiyonunu kullanmaya çalışın.

def alan_hesapla(demet):
    return demet[0] * demet[1]


liste = [(3,4),(10,3),(5,6),(1,9)]

print(list(map(alan_hesapla,liste)))

"""
Çıktı

[12, 30, 30, 9]
"""

##################################################################################################################

# Problem 2
# Elinizden her bir elemanı 3'lü bir demet olan bir liste olsun.
	
	# [(3,4,5),(6,8,10),(3,10,7)]

# Şimdi kenar uzunluklarına göre bu kenarların bir üçgen olup olmadığını dönen bir 
# fonksiyon yazın ve sadece üçgen belirten kenarları bulunduran listeyi ekrana yazdırın.
	
	# [(3, 4, 5), (6, 8, 10)]

# Not: filter() fonksiyonunu kullanmaya çalışın.

def üçgen_mi(demet):
    
    if (abs(demet[0]+demet[1]) > demet[2] and abs(demet[0]+demet[2]) > demet[1] and abs(demet[1]+demet[2]) > demet[0]):
        return True
    else:
        return False


liste = [(3,4,5),(6,8,10),(3,10,7)]

print(list(filter(üçgen_mi,liste)))

"""
Çıktı

[(3, 4, 5), (6, 8, 10)]
"""

##################################################################################################################

# Problem 3
# Elinizde şöyle bir liste bulunsun.

    # [1,2,3,4,5,6,7,8,9,10]

# Bu listenin içindeki çift sayıların toplamını ekrana yazdıran bir fonksiyon yazın.

# Not: İlk önce filter() fonksiyonu ile çift sayıları ayıklayın. Daha sonra reduce() fonksiyonunu kullanın.

from functools import reduce
liste = [1,2,3,4,5,6,7,8,9,10]

filtre = list(filter(lambda x : x % 2 == 0,liste))

print(reduce(lambda x,y : x + y,filtre))

"""
Çıktı

30
"""

##################################################################################################################

# Problem 4
# Elinizde programlama ve programlamaOnEk'in bulunduğu iki tane liste olsun.

    # programlama -----> ["İnclude","Program","Java","Python","Javascript","Php","Html"]

    # programlamaOnEk -----> ["Programlama","Program","Dili","Web","Server","Teknoloji","Siber"]

# Bu isimleri ve soyisimleri sırasıyla eşleştirin ve ekrana alt alta isimleri ve soyisimleri yazdırın.

# Not: zip() fonksiyonunu kullanmaya çalışın.

programlama = ["İnclude","Program","Java","Python","Javascript","Php","Html"]

programlamaOnEk = ["Programlama","Program","Dili","Web","Server","Teknoloji","Siber"]

for i,j in zip(programlama,programlamaOnEk):
    print(i,j)

"""
Çıktı

İnclude Programlama
Program Program
Java Dili
Python Web
Javascript Server
Php Teknoloji
Html Siber
##################################################################################################################