# 1'den 1000'e kadar olan sayılardan asal sayıları üreten generator bir fonksiyon yazın.

def asal_mı(sayı):
    i =  2
    
    while i < sayı:
        if (sayı % i == 0):
            return False
        i += 1
    return True
def asal_generator():
    i =  2
    while True:
        if (asal_mı(i)):
            yield i
        i += 1

for sayı in asal_generator():
    if (sayı > 1000):
        break
    print(sayı)

"""
Çıktı:

2
3
5
7
11
13
17
19
23
29
..
..
..
997
"""