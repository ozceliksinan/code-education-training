#######################################
# Writed by Sinan Özçelik             #
#######################################

class Çalışan():
    def __init__(self,isim,maaş,departman):
        print("Çalışan sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
    def bilgilerigoster(self):
        print("Çalışan sınıfının bilgileri.....")
        print("İsim : {} \nMaaş: {} \nDepartman: {}\n".format(self.isim,self.maaş,self.departman))
    def departman_degistir(self,yeni_departman):
        print("Departman değişiyor....")
        self.departman = yeni_departman

# Çalışan sınıfını oluşturduk şimdi de Yönetici sınıfını bu Çalışan sınıfından türetmeye çalışalım.

class Yönetici(Çalışan): # Çalışan sınıfından miras alıyoruz.
    pass # Pass Deyimi bir bloğu sonradan tanımlamak istediğimizde kullanılan bir deyimdir.

# Burada, yönetici sınıfında herhangi bir şey tanımlamadık ancak Çalışan sınıfından bütün özellikleri ve metodları miras aldık. 
# Bakalım burada Çalışan sınıfının metodlarını kullanabilecek miyiz ?

yönetici1 = Yönetici("İnclude Program",3000,"İnsan Kaynakları") # yönetici objesi
"""
Çıktı
Çalışan sınıfının init fonksiyonu
"""

yönetici1.bilgilerigoster()
"""
Çıktı
Çalışan sınıfının bilgileri.....
İsim : İnclude Program 
Maaş: 3000 
Departman: İnsan Kaynakları
"""

yönetici1.departman_degistir("Halkla İlişkiler")
"""
Çıktı
Departman değişiyor....
"""

yönetici1.bilgilerigoster()
"""
Çıktı
Çalışan sınıfının bilgileri.....
İsim : İnclude Program 
Maaş: 3000 
Departman: Halkla İlişkiler
"""

# Burada gördüğümüz gibi bütün özellikleri ve metodları Çalışan sınıfından miras aldığımız için kullanabiliyoruz. 
# Bunu dir() fonksiyonu ile de görebiliriz.

# Peki biz Yönetici sınıfına ekstra fonksiyonlar ve özellikler ekleyebiliyor muyuz ? 
# Örnek olması açısından zam_yap isimli bir metod ekleyelim.

class Yönetici(Çalışan):
    def zam_yap(self,zam_miktarı):
        print("Maaşa zam yapılıyor....")
        self.maaş += zam_miktarı  

yönetici2 = Yönetici("İnclude Program Python",3000,"Bilişim") # yönetici objesi
"""
Çıktı
Çalışan sınıfının init fonksiyonu
"""

yönetici2.bilgilerigoster()
"""
Çıktı
Çalışan sınıfının bilgileri.....
İsim : İnclude Program Python 
Maaş: 3000 
Departman: Bilişim
"""

yönetici2.zam_yap(500) # Ekstra eklediğimiz fonksiyonu da kullanabiliyoruz.
"""
Çıktı
Maaşa zam yapılıyor....
"""

yönetici2.bilgilerigoster()
"""
Çıktı
Çalışan sınıfının bilgileri.....
İsim : İnclude Program Python 
Maaş: 3500 
Departman: Bilişim
"""

# İşte biz bir sınıftan miras alarak oluşturduğumuz sınıflara ekstra metodlar ve özellikler de ekleyebiliyoruz.

# Overriding (İptal Etme)
# Eğer biz miras aldığımız metodları aynı isimle kendi sınıfımızda tekrar tanımlarsak , 
# artık metodu çağırdığımız zaman miras aldığımız değil kendi metodumuz çalışacaktır. 
# Buna Nesne Tabanlı Programlamada bir metodu override etmek denmektedir.
# Örneğin artık Çalışan sınıfının init metodunu kullanmak yerine Yönetici sınıfında init metodunu override edebiliriz. 
# Böylelikle Yönetici sınıfına ekstra özellikler(attribute) ekleyebiliriz.

class Çalışan():
    def __init__(self,isim,maaş,departman):
        print("Çalışan sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
    def bilgilerigoster(self): 
        print("Çalışan sınıfının bilgileri.....") 
        print("İsim : {} \nMaaş: {} \nDepartman: {}\n".format(self.isim,self.maaş,self.departman))
    def departman_degistir(self,yeni_departman):
        print("Departman değişiyor....")
        self.departman = yeni_departman
class Yönetici(Çalışan):
    def __init__(self,isim,maaş,departman,kişi_sayısı): # Sorumlu olduğu kişi sayısı
        print("Yönetici sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
        self.kişi_sayısı = kişi_sayısı # Yeni eklenen özellik
    def zam_yap(self,zam_miktarı):
        print("Maaşa zam yapılıyor....")
        self.maaş += zam_miktarı

a = Yönetici("İnclude Program Python",3000,"Bilişim",10) # Yönetici sınıfının init fonksiyonu. Override edildi.
"""
Çıktı
Yönetici sınıfının init fonksiyonu
"""

# İsterseniz şimdi de bilgilerigoster metodunu override edelim.

class Çalışan():
    def __init__(self,isim,maaş,departman):
        print("Çalışan sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
    def bilgilerigoster(self):
        
        print("Çalışan sınıfının bilgileri.....")
        
        print("İsim : {} \nMaaş: {} \nDepartman: {}\n".format(self.isim,self.maaş,self.departman))
    def departman_degistir(self,yeni_departman):
        print("Departman değişiyor....")
        self.departman = yeni_departman
 
class Yönetici(Çalışan):
    
    def __init__(self,isim,maaş,departman,kişi_sayısı): # Sorumlu olduğu kişi sayısı
        print("Yönetici sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
        self.kişi_sayısı = kişi_sayısı # Yeni eklenen özellik
    def bilgilerigoster(self):
        
        print("Yönetici sınıfının bilgileri.....")
        
        print("İsim : {} \nMaaş: {} \nDepartman: {}\nSorumlu kişi sayısı: {}".format(self.isim,self.maaş,self.departman,self.kişi_sayısı))
    def zam_yap(self,zam_miktarı):
        print("Maaşa zam yapılıyor....")
        self.maaş += zam_miktarı

b =  Yönetici("İnclude Program",2500,"Pazarlama",5)
"""
Çıktı
Yönetici sınıfının init fonksiyonu
"""

b.bilgilerigoster() # Kendi yazdığımız fonksiyon çağrıldı. Overriding
"""
Çıktı
Yönetici sınıfının bilgileri.....
İsim : İnclude Program 
Maaş: 2500 
Departman: Pazarlama
Sorumlu kişi sayısı: 5
"""

# super Anahtar Kelimesi
# super anahtar kelimesi özellikle override ettiğimiz bir metodun içinde aynı 
# zamanda miras aldığımız bir metodu kullanmak istersek kullanılabilir. 
# Yani super en genel anlamıyla miras aldığımız sınıfın metodlarını alt sınıflardan kullanmamızı sağlar. 
# Hemen örnek üzerinden anlamaya çalışalım.

class Çalışan():
    def __init__(self,isim,maaş,departman):
        print("Çalışan sınıfının init fonksiyonu")
        self.isim = isim
        self.maaş = maaş
        self.departman = departman
    def bilgilerigoster(self):
        
        print("Çalışan sınıfının bilgileri.....")
        
        print("İsim : {} \nMaaş: {} \nDepartman: {}\n".format(self.isim,self.maaş,self.departman))
    def departman_degistir(self,yeni_departman):
        print("Departman değişiyor....")
        self.departman = yeni_departman
 
class Yönetici(Çalışan):
    
    def __init__(self,isim,maaş,departman,kişi_sayısı): # Sorumlu olduğu kişi sayısı
        super().__init__(isim,maaş,departman) # 3 tane özelliği Çalışan fonksiyonunun init fonksiyonuyla hallediyoruz.
        
        print("Yönetici sınıfının init fonksiyonu")
        
        self.kişi_sayısı = kişi_sayısı # Ekstra özelliği de kendimiz yazıyoruz.
    def bilgilerigoster(self):
        
        print("Yönetici sınıfının bilgileri.....")
        
        print("İsim : {} \nMaaş: {} \nDepartman: {}\nSorumlu kişi sayısı: {}".format(self.isim,self.maaş,self.departman,self.kişi_sayısı))
    def zam_yap(self,zam_miktarı):
        print("Maaşa zam yapılıyor....")
        self.maaş += zam_miktarı

# Burada super().__init() diyerek Çalışan sınıfının metodunu özel olarak çağırarak isim, maaş, 
# departman özelliklerini bu metodla belirledik.

c = Yönetici("Deneme İsim",3000,"İnsan Kaynakları",4)
"""
Çıktı
Çalışan sınıfının init fonksiyonu
Yönetici sınıfının init fonksiyonu
"""