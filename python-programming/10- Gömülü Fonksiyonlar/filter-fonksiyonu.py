#######################################
# Writed by Sinan Özçelik             #
#######################################

# Yapısı;

# filter(fonksiyon,iterasyon yapılabilen bir veritipi(liste vb.))

# filter() fonksiyonu birinci parametre olarak mutlaka mantıksal değer dönen (True , False) 
# bir fonksiyon alır ve liste gibi veritiplerinin her bir elemanına bu fonksiyonunu uygular. 
# filter sadece True sonuç çıkaran değerleri alarak bir tane filter objesi döner. Hemen örneklerimize bakalım.

##################################################################################################################

filter(lambda x : x % 2 == 0, [1,2,3,4,5,6,7,8,9,10])
"""
Çıktı

<filter at 0xa4bab50438>
"""

##################################################################################################################

list(filter(lambda x : x % 2 == 0, [1,2,3,4,5,6,7,8,9,10])) # Çift olan sayılar

"""
Çıktı

[2, 4, 6, 8, 10]
"""

##################################################################################################################

def asal_mi(x):
    i = 2
    if (x == 1):
        return False # Asal değil
    elif(x == 2):
        return True # Asal sayı
    else:
        while(i < x):
            if (x % i == 0):
                return False # Asal Değil
            i += 1
    return True

asal_mi(34) # False

asal_mi(2) # True

asal_mi(1) # False

asal_mi(3) # True

asal_mi(4) # False

##################################################################################################################

filter(asal_mi,range(1,100))

"""
Çıktı

<filter at 0xa4bab50550>
"""

list(filter(asal_mi,range(1,100))) # 1 den 100' e kadar olan asal sayılar.

"""
Çıktı

[2,
 3,
 5,
 7,
 11,
 13,
 17,
 19,
 23,
 29,
 31,
 37,
 41,
 43,
 47,
 53,
 59,
 61,
 67,
 71,
 73,
 79,
 83,
 89,
 97]
"""

##################################################################################################################