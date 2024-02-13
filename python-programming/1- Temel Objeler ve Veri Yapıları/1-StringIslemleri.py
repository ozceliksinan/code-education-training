#######################################
# Writed by Sinan Özçelik             #
#######################################
print("---------------")
#######################################
# String oluşturma;                   #
#######################################
string1 = 'Sinan Deneme'
string2 = "Sinan Deneme"
string3 = """ Sinan      Deneme """
print(string1)
print(string2)
print(string3)
#######################################

print("---------------")

#######################################
# String Indeksleme ve Parçalama      #
#######################################
# 0. elemana  ulaşalım . Bunun için [] operatörünü kullanacağız.
a = "iki"
print(a[0])
print(a[1])
print(a[2])
print("---------------")
# Sondaki eleman "-1" eleman
a = "sinan"
print(a[-1])
print(a[-2])
print(a[-3])
print(a[-4])
print(a[-5])
print("---------------")
a = "Python Programlama Dili"
# 4. indeksten başla 10.indekse kadar(dahil değil) al.
print(a[4:10])
# Başlangıç değeri belirtilmemişse en baştan başlayarak alır.
print(a[:10])
# Bitiş değeri belirtilmemişse en sonuna kadar alır.
print(a[4:])
# İki değer de belirtilmemişse tüm stringi al.
print(a[:])
#Son karaktere kadar al.
print(a[:-1])
# Baştan sona 2 değer atlaya atlaya stringi al.
print(a[::2])
# 4.indeksten 12'nci indekse 3'er atlayarak stringi al.
print(a[4:12:3])
# Baştan sona -1 atlayarak stringi al. (String'i ters çevirme)
print(a[::-1])
print("---------------")
# len() fonksiyonunu kullanma.
a = "Python Programlama Dili"
print(len(a))
print("---------------")
# Stringleri toplayalım yani birbirine ekleyelim.
a = "Python "
b = "Programlama "
c = "Dili"
print(a + b + c)
print("---------------")
# Python * 3 aslında Python + Python + Python işlemine eşdeğerdir.
print("Python" * 3)
print("---------------")