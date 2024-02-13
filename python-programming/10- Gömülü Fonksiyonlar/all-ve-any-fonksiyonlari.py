#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################

def hepsi(liste):
    for i in liste:
        if not i:
            return False
    return True
# Bütün değerler True ise True en az birisi False ise False döndürmek istiyoruz.
liste = [True,False,True,False,True]

hepsi(liste) # En az birisi Çıktı : False

liste = [1,2,3,4,5] # Daha önceden biliyoruz. 0' haricinde bütün sayılar True sayılmaktadır.

hepsi(liste) # Hepsi True

##################################################################################################################

def herhangi(liste):
    for i in liste:
        if i:
            return True
    return False
# Herhangi bir değer True ise True, Hepsi False ise False döndürmek istiyoruz.

liste = [True,False,True,False,True]
herhangi(liste) # True

liste = [0,0,0,0,0,0,0] # Bütün değerler False , 0 = False
herhangi(liste) # False

# Aslında bu işlemleri all() ve any() fonksiyonları yapmaktadır. İsterseniz bunların örneklerine bakalım.

# all() fonksiyonu bütün değerler True ise True, en az bir değer False ise False sonuç döndürür.

liste = [True,False,True,False,True]

all(liste) # False

liste = [1,2,3,4,5]

all(liste) # True

any() fonksiyonu bütün değerler False ise False, en az bir değer True ise True sonuç döndürür.

liste = [True,False,True,False,True]

any(liste) # True

liste = [0,0,0,0,0,0,0]

any(liste) # False

##################################################################################################################