#######################################
# Writed by Sinan Özçelik             #
#######################################

# init metodu
# init metodunu kendimiz tanımlarsak artık kendi init fonksiyonumuz çalışacaktır.

class Kitap():
    def __init__(self,isim,yazar,sayfa_sayısı,tür): 
        print("Kitap Objesi oluşuyor....")
        self.isim = isim
        self.yazar = yazar
        self.sayfa_sayısı = sayfa_sayısı
        self.tür = tür
kitap1 = Kitap("İstanbul Hatırası","Ahmet Ümit",561,"Polisiye") # Kendi metodumuz 
"""
Çıktı
Kitap Objesi oluşuyor....
"""

#---------------------------------------------------------------------------------------------#
# str metodu
# Normalde print(kitap1) ifadesi ekrana şöyle bir yazı yazdırıyor.

print(kitap1)
"""
Çıktı
<__main__.Kitap object at 0x000000CEE886EAC8>
 Bunu yazdırmak yerine kendi istediğimiz yazıyı yazdırabiliriz.
"""
# Ancak eğer str metodunu kendimiz tanımlarsak artık ekrana kitap1 in içeriğini daha anlaşılır yazabileceğiz.

class Kitap():
    def __init__(self,isim,yazar,sayfa_sayısı,tür): 
        print("Kitap Objesi oluşuyor....")
        self.isim = isim
        self.yazar = yazar
        self.sayfa_sayısı = sayfa_sayısı
        self.tür = tür
    def __str__(self):
        # Return kullanmamız gerekli
        return "İsim: {}\nYazar: {}\nSayfa Sayısı: {}\nTür: {}".format(self.isim,self.yazar,self.sayfa_sayısı,self.tür)

kitap1 = Kitap("İstanbul Hatırası","Ahmet Ümit",561,"Polisiye")
"""
Çıktı
Kitap Objesi oluşuyor....
"""

print(kitap1)
"""
Çıktı
İsim: İstanbul Hatırası
Yazar: Ahmet Ümit
Sayfa Sayısı: 561
Tür: Polisiye
"""


#---------------------------------------------------------------------------------------------#
# len metodu
# len metodu normalde özel olarak biz tanımlamazsak tanımlanan bir metod değil. 
# Onun için bu metodu kendimiz tanımlamamız gereklidir.

class Kitap():
    def __init__(self,isim,yazar,sayfa_sayısı,tür): 
        print("Kitap Objesi oluşuyor....")
        self.isim = isim
        self.yazar = yazar
        self.sayfa_sayısı = sayfa_sayısı
        self.tür = tür
    def __str__(self):
        # Return kullanmamız gerekli
        return "İsim: {}\nYazar: {}\nSayfa Sayısı: {}\nTür: {}".format(self.isim,self.yazar,self.sayfa_sayısı,self.tür)
    def __len__(self):
        return self.sayfa_sayısı

kitap1 = Kitap("İstanbul Hatırası","Ahmet Ümit",561,"Polisiye")
print(len(kitap1)) # KEndi __len__ metodumuz çağrıldı.

"""
Çıktı
561
"""
#---------------------------------------------------------------------------------------------#

# del metodu
# del metodu Pythonda bir objeyi del anahtar kelimesiyle sildiğimiz zaman çalıştırılan metoddur. 
# Bu metodu kendimiz tanımlayarak ekstra özellikler ekleyebiliriz.

class Kitap():
    def __init__(self,isim,yazar,sayfa_sayısı,tür): 
        print("Kitap Objesi oluşuyor....")
        self.isim = isim
        self.yazar = yazar
        self.sayfa_sayısı = sayfa_sayısı
        self.tür = tür
    def __str__(self):
        # Return kullanmamız gerekli
        return "İsim: {}\nYazar: {}\nSayfa Sayısı: {}\nTür: {}".format(self.isim,self.yazar,self.sayfa_sayısı,self.tür)
    def __len__(self):
        return self.sayfa_sayısı
    def __del__(self):
        print("Kitap objesi siliniyor.......")
 
kitap1 = Kitap("İstanbul Hatırası","Ahmet Ümit",561,"Polisiye")
del kitap1
"""
Çıktı
Kitap Objesi oluşuyor....
Kitap objesi siliniyor.......
"""

# Siz de bunlar gibi çoğu özel metodu ihtiyacınız olduğu zaman kendiniz yazabilirsiniz. 