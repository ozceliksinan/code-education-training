#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################

"""
Problem 1
Elinizde uzunca bir string olsun.

            "ProgramlamaÖdeviİleriSeviyeVeriYapılarıveObjeleripynb"


Bu string içindeki harflerin frekansını (bir harfin kaç defa geçtiği) bulmaya çalışın.

İpucu : Kodlama egzersizimizde buna çok benzer bir şey yapmıştık.
"""

s =  "ProgramlamaÖdeviİleriSeviyeVeriYapılarıveObjeleripynb"
frekans = dict()

for karakter in s:
    if (karakter in frekans):
        frekans[karakter] += 1
    else:
        frekans[karakter] = 1
for i,j in frekans.items():
    
    print(i,":",j)

"""
Çıktı

P : 1
r : 6
o : 1
g : 1
a : 5
m : 2
l : 4
Ö : 1
d : 1
e : 8
v : 3
i : 5
İ : 1
S : 1
y : 2
V : 1
Y : 1
p : 2
ı : 2
O : 1
b : 2
j : 1
n : 1

"""

##################################################################################################################

"""
Problem 2
"şiir.txt" şeklinde bir dosya oluşturun ve içinde şu satırlar yer alsın.

                    Memlekete sis çökmüş bir gece 
                    Usulca yanağıma sen düşüyorsun
                    Sabah saat dokuzu beş geçe
                    Terk edip bizleri gidiyorsun
                    Ayrılık bu kadar yakmamıştı içimizi
                    Farkında mısın bilmiyorum
                    Aldın beraberinde cumhuriyetimizi
                    Korkunç bir veda, sararmıştı her yer
                    Ellerini uzat tutmak istiyoruz
                    Masmavi gözleri kaybetmiş çocuk
                    Aldı bir sabah ruhumuzu
                    Lakin nasıl bölmesin yokluğun uykumuzu

Bu dosyanın herbir satırını okuyun. Satırların baş harflerini birbirine ekleyerek bir string oluşturun ve bu string'i ekrana yazdırın.

"""

bas_harfler = ""

with open("şiir.txt","r",encoding="utf-8") as file:
    for satır in file:
        bas_harfler += satır[0]
print(bas_harfler)

"""
Çıktı

MUSTAFAKEMAL
"""

##################################################################################################################

"""
Problem 3
Elinizde "mailler.txt" adında , maillerin ve bazı yazıların bulunduğu bir dosya olsun. 
Bu dosyanın her bir satırını okuyun ve sadece mail formatına uygun olanları ekrana yazdırın.

                    info@sinanprogram.com
                    denemeee@denemeee.com
                    sinanprogram.com
                    sinanprogram@sinanprogram.com
                    deneme@deneme.com

                           //
                           //
                           //


İpucu: Stringlerde bulunan endswith ve find metodlarını kullanabilirsiniz.

"""

with open("mailler.txt","r",encoding="utf-8") as file:
    for satır in file:
        satır = satır[:-1]
        if (satır.endswith(".com") and satır.find("@") != -1):
            print(satır)

"""
Çıktı

info@sinanprogram.com
denemeee@denemeee.com
sinanprogram@sinanprogram.com
deneme@deneme.com

"""

##################################################################################################################

"""
Problem 4
Elinizde 2 tane liste bulunsun. Bu listelerden isim ve soyisimleri birleştirerek , ekrana isim ve soyisimleri isimlere göre sıralı bir şekilde yazdırmaya çalışın.

        isim -----> ["Kerim","Tarık","Ezgi","Kemal","İlkay","Şükran","Merve"]

        soyisim ------> ["Yılmaz","Öztürk","Dağdeviren","Atatürk","Dikmen","Kaya","Polat"]

"""

isim = ["Kerim","Tarık","Ezgi","Kemal","İlkay","Şükran","Merve"]

soyisim = ["Yılmaz","Öztürk","Dağdeviren","Atatürk","Dikmen","Kaya","Polat"]

liste = list(zip(isim,soyisim))

liste.sort()

for i,j in liste:
    print(i,j)

"""
Çıktı

Ezgi Dağdeviren
Kemal Atatürk
Kerim Yılmaz
Merve Polat
Tarık Öztürk
İlkay Dikmen
Şükran Kaya

"""
##################################################################################################################