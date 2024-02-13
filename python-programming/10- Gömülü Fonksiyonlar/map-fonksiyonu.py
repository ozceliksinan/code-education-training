# Pythonda gömülü bir fonksiyon olan map() fonksiyonunun yapısı şu şekildedir.
# map(fonksiyon,iterasyon yapılabilecek veritipi(liste,demet vb),....)

# map() fonksiyonu ilk parametre olarak bir tane fonksiyon objesi alır. 
# (Fonksiyonlar da birer obje olduğu için başka bir fonksiyona gönderilebilir.) 
# 2. parametre olarak da bir tane iterasyon yapılacak veritipi alarak , 
# gönderilen fonksiyonu her bir eleman üzerinde uygulayarak sonuçları bir map objesi olarak döner. 
# Örneklerimize geçersek bu fonksiyonun işlevini daha iyi anlayacağız.

##################################################################################################################
def double(x):
    return x * 2
map(double,[1,2,3,4,5,6,7]) # fonksiyon bir tane argüman alıyor ve listenin her bir elemanı üzerinde uygulanıyor.
"""
Çıktı

<map at 0x5522e9e208>
"""

list(map(double,[1,2,3,4,5,6,7]))
"""
Çıktı

[2, 4, 6, 8, 10, 12, 14]
"""

list(map(double,(1,2,3,4,5,6,7)))
"""
Çıktı

[2, 4, 6, 8, 10, 12, 14]
"""
##################################################################################################################

# Buradaki fonksiyonları lambda ifadeleriyle de yazabiliriz.

map(lambda x : x ** 2, [1,2,3,4,5,6,7,8,9])
"""
Çıktı

<map at 0x5522e9e438>
"""

list(map(lambda x : x ** 2, [1,2,3,4,5,6,7,8,9]))
"""
Çıktı

[1, 4, 9, 16, 25, 36, 49, 64, 81]
"""
##################################################################################################################

# Map fonksiyonu birden fazla liste veya demet alabilir.

liste1 = [1,2,3,4]
liste2 = [5,6,7,8]
liste3 = [9,10,11,12,13]

map(lambda x,y : x * y , liste1,liste2)
"""
Çıktı

<map at 0x5522e9e2b0>
"""

list(map(lambda x,y : x * y , liste1,liste2))
"""
Çıktı

[5, 12, 21, 32]
"""

list(map(lambda x,y,z : x * y * z , liste1,liste2,liste3))
"""
Çıktı

[45, 120, 231, 384]
"""
##################################################################################################################