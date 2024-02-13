#######################################
# Writed by Sinan Özçelik             #
#######################################

# Koşullu Durumlar – if – elif – else koşullu durumları

# if-elif-else Blokları

# if koşul: 
#     Yapılacak İşlemler
# elif başka bir koşul:
#      Yapılacak İşlemler
# elif başka bir koşul:
#      Yapılacak İşlemler
 
#         //
#         //
# else:
#      Yapılacak İşlemler

# Programlarımızda, Kaç tane koşulumuz var ise o kadar elif bloğu oluşturabiliriz. Ayrıca else in yazılması zorunlu değildir. 
# if – elif – else kalıplarında, hangi koşul sağlanırsa program o bloğu çalıştırır ve if-elif-blokları sona erer. 
# Şimdi isterseniz kullanıcıya işlem seçtirdiğimiz bir programla , bu kalıbı öğrenmeye başlayalım.

işlem =  int(input("İşlem seçiniz:")) # 3 tane işlemimiz olsun.
 
if işlem == 1:
    print("1. işlem seçildi.")
elif işlem == 2:
    print("2. işlem seçildi.")
elif işlem == 3:
    print("3. işlem seçildi.")
else:
    print("Geçersiz İşlem!")