#######################################
# Writed by Sinan Özçelik             #
#######################################

class Yazılımcı():
    def __init__(self,isim,soyisim,numara,maaş,diller):
        self.isim = isim
        self.soyisim = soyisim
        self.numara = numara    # Yazılımcı objelerinin özellikleri 
        self.maaş = maaş
        self.diller = diller
# yazılımcı1 objesi
yazılımcı1 =  Yazılımcı("Sinan Program","Soyisimdeneme",12345,3000,["Python","C","Java"])
yazılımcı2 = Yazılımcı("Program","Soyisimdeneme",23456,3500,["Matlab","R","Java"])
print(yazılımcı1.diller)
print(yazılımcı2.soyisim)
"""
Çıktı
['Python', 'C', 'Java']
'Soyisimdeneme'
"""

# Önceki dersten bunların nasıl yapıldığını biliyoruz. Peki bu class’a metodlarımızı nasıl tanımlayabiliriz ? 
# Aynı init metodunu tanımladığımız gibi bir class’a da istediğimiz kadar metod tanımlayabiliriz. 
# Örneğin ,Yazılımcı classına bilgilerigöster isimli bir metod tanımlayalım.

class Yazılımcı():
    def __init__(self,isim,soyisim,numara,maaş,diller):
        self.isim = isim
        self.soyisim = soyisim
        self.numara = numara    # Yazılımcı objelerinin özellikleri 
        self.maaş = maaş
        self.diller = diller
    def bilgilerigöster(self):
        print("""
        Çalışan Bilgisi:
        İsim :  {}
        Soyisim : {}
        Şirket Numarası: {} 
        Maaş :  {}
        Diller: {}
        """.format(self.isim,self.soyisim,self.numara,self.maaş,self.diller))
yazılımcı1 =  Yazılımcı("Sinan Program","Soyisimdeneme",12345,3000,["Python","C","Java"])
yazılımcı1.bilgilerigöster()
"""
Çıktı
Çalışan Bilgisi:     
İsim :  Sinan Program      
Soyisim : Soyisimdeneme      
Şirket Numarası: 12345    
Maaş :  3000      
Diller: ['Python', 'C', 'Java']
"""


# Burada bilgilerigöster isimli metod tanımlayarak her bir özelliğimizin değeri ekrana derli toplu bir şekilde yazdırmış olduk. 
# Metodlarımızı yazarken dikkat etmemiz gerek nokta, her metodun birinci parametresinin self referansı olması gerektiğidir. 
# Ayrıca objelerimizin özelliklerine mutlaka self referansıyla erişmemiz gerekiyor.
# İsterseniz bu classa 2 tane daha metod yazalım.
class Yazılımcı():
    def __init__(self,isim,soyisim,numara,maaş,diller):
        self.isim = isim
        self.soyisim = soyisim
        self.numara = numara    # Yazılımcı objelerinin özellikleri 
        self.maaş = maaş
        self.diller = diller
    def bilgilerigöster(self):
        print("""
        Çalışan Bilgisi:
        İsim :  {}
        Soyisim : {}
        Şirket Numarası: {}
        Maaş :  {}
        Diller: {}
        """.format(self.isim,self.soyisim,self.numara,self.maaş,self.diller))
    def dil_ekle(self,yeni_dil):
        print("Dil ekleniyor.")
        self.diller.append(yeni_dil)
    def maas_yukselt(self,zam_miktarı):
        print("Maaş yükseliyor...")
        self.maaş += 250
yazılımcı1 =  Yazılımcı("Sinan Program","Soyisimdeneme",12345,3000,["Python","C","Java"])
yazılımcı1.bilgilerigöster()
"""
Çıktı
Çalışan Bilgisi:  
İsim :  Sinan Program        
Soyisim : Soyisimdeneme       
Şirket Numarası: 12345      
Maaş :  3000     
Diller: ['Python', 'C', 'Java']
"""
yazılımcı1.maas_yukselt(500)
yazılımcı1.bilgilerigöster()
"""
Çıktı
Maaş yükseliyor...
Çalışan Bilgisi:     
İsim :  Sinan Program     
Soyisim : Soyisimdeneme      
Şirket Numarası: 12345     
Maaş :  3250     
Diller: ['Python', 'C', 'Java']
"""
yazılımcı1.dil_ekle("Javascript")
yazılımcı1.bilgilerigöster()
"""
Çıktı
Maaş yükseliyor...
Çalışan Bilgisi:    
İsim :  Sinan Program    
Soyisim : Soyisimdeneme    
Şirket Numarası: 12345    
Maaş :  3250   
Diller: ['Python', 'C', 'Java','Javascript']
"""