#######################################
# Writed by Sinan Özçelik             #
#######################################

# etiket = lambda parametre1,parametre2.... :  İşlem

# Bu yapıdan henüz bir şey anlamamış olabiliriz. 
# İsterseniz örneklerimizle lambda ifadelerini anlamaya çalışalım. 
# Bir tane iki ile çarpma görevini yerine getiren fonksiyon yazalım.

def ikiyleçarp(x): # Klasik fonksiyon tanımlama
    return x * 2
print(ikiyleçarp(2))
"""
Çıktı
4
"""

# Şimdi de bu fonksiyonu lambda ifadelerini kullanarak tek satırda yazalım.
ikiyleçarp = lambda x : x * 2 
# x parametre x* 2 return ifadesi ve ikiyleçarp değeri de bir etikettir.
ikiyleçarp(3) 
# Buradaki 3 argümanı lambda ifadesindeki x'in yerine geçiyor.
"""
Çıktı
6
"""

# İşte lambda ifadesini bu şekilde küçük fonksiyonlar için kullanabiliriz. 
# lambda ifadelerini özellikle kısa bir fonksiyonu def ifadesiyle yazmanın 
# zahmetli olduğu zamanlarda kullanılabilir.