#######################################
# Writed by Sinan Özçelik             #
#######################################

# Programlarımızda değiştirilmesini istemediğimiz değerleri bir demet içinde depolayabiliriz.
# Demet elemanları parantez içine alınarak demet oluşturulabilir.
demet = (1,2,3,4,5,6,7,8,9)
print(demet)
print(type(demet))

# Tek elemanlı demet bu şekilde tanımlanabilir.
demet = (1,)
print(demet)
print(type(demet))

demet = (1,2,3,4,5,6,7)
# 0. indekse  ulaşma
print(demet[0])
# 4. indekse ulaşma
print(demet[4])
print(demet[-1])
print(demet[2:])

# Demetlerin Temel Metodları
# index metoduyla içine verdiğimiz elemanın hangi indekste olduğunu bulabiliriz.
# Demeti oluşturalım.
demet = (1,2,3,"Sinan","Program","Python")
# "Program" elemanının indeksini buluyoruz.
print(demet.index("Program"))

# count metoduyla içine verdiğimiz değerin demette kaç defa geçtiğini bulabiliriz.
demet = (1,23,34,34,2,1,4,5,1,1,34)
print(demet.count(1))

# Değiştirilmeme Özelliği
demet = ("Elma","Armut","Muz")
demet[0] = "Kiraz"
# Program hata verir.