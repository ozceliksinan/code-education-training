#######################################
# Writed by Sinan Özçelik             #
#######################################

# Metodlar bir obje üzerinde belli işlemleri gerçekleştiren 
# objelere özgü fonksiyonlardır ve objelerin üzerinde metodlar 
# şu şekilde kullanılır.

# Örneğin bir liste objesi oluşturduğumuz zaman bu objenin üzerinde 
# belli metodları uygulayabiliriz.

liste =  [1,2,3,4,5,6]
liste.insert(1,"Program")
print(liste)
"""
Çıktı
[1, 'Program', 2, 3, 4, 5, 6]
"""

# Pop ile listedeki son eleman silinir.
liste.pop()
print(liste)
"""
Çıktı
[1, 'Program', 2, 3, 4, 5]
"""