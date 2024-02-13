#######################################
# Writed by Sinan Özçelik             #
#######################################

# Pythondaki bu hazır fonksiyon bizim verdiğimiz değerlere göre range isimli bir yapı oluşturur ve bu yapı listelere oldukça benzer. 
# Bu yapı başlangıç, bitiş ve opsiyonel olarak artırma değeri alarak listelere benzeyen bir sayı dizisi oluşturur.

print(*range(0,20)) 
# Yazdırmak için başına "*" koymamız gerekiyor.
"""
Çıktı
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19
"""

liste = list(range(0,20)) # list fonksiyonuyla listeye dönüştürebilir.
print(liste)
"""
Çıktı
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19]
"""

print(*range(5,10))
"""
Çıktı
5 6 7 8 9
"""

print(*range(15)) # Başlangıç değeri vermediğimiz 0'dan başlar 
"""
Çıktı
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14
"""

print(*range(5,20,2)) # 5'ten 20'ye kadar olan sayıları 2 atlayarak oluşturur.
"""
Çıktı
5 7 9 11 13 15 17 19
"""

print(*range(5,100,5)) # 5'ten 100'e kadar olan ve 5 ile bölünebilen sayılar
"""
Çıktı
5 10 15 20 25 30 35 40 45 50 55 60 65 70 75 80 85 90 95
"""

print(*range(20,0,-1)) # 20'den geri gelen sayıları oluşturur.
"""
Çıktı
20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
"""

for sayı in range(0,10):
    print(sayı)
"""
Çıktı
0
1
2
3
4
5
6
7
8
9
"""

for sayı in range(1,20):
    print("* " * sayı)
"""
Çıktı
* 
* * 
* * * 
* * * * 
* * * * * 
* * * * * * 
* * * * * * * 
* * * * * * * * 
* * * * * * * * * 
* * * * * * * * * * 
* * * * * * * * * * * 
* * * * * * * * * * * * 
* * * * * * * * * * * * * 
* * * * * * * * * * * * * * 
* * * * * * * * * * * * * * * 
* * * * * * * * * * * * * * * * 
* * * * * * * * * * * * * * * * * 
* * * * * * * * * * * * * * * * * * 
* * * * * * * * * * * * * * * * * * * 
"""