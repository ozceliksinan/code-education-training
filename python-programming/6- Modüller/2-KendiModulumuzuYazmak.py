#######################################
# Writed by Sinan Özçelik             #
#######################################

# Kendi Modüllerimizi Yazmak
# Bu konuda kendi modüllerimizi nasıl yazacağımızı öğrenmeye çalışacağız. Ancak bu derste Python dosyaları oluşturacağımız için kendi 
# bilgisayarımızda konuyu anlatmaya çalışacağım. 
# Uygulayacağımız adımlar şu şekilde;
#       1. Herhangi bir tane klasör oluşturuyoruz.
#       2. Modülümüz ve deneme Python dosyamız aynı dizinde olması gerektiği için 2 tane Python dosyasını da bu klasör altında oluşturuyoruz.
#       3. modul1.py ve deneme.py dosyası oluşturuyoruz.
#       4. modul1.py dosyasının içine istediğimiz kadar fonksiyonu yazıyoruz.
#       5. Son olarak da deneme.py dosyasının içinde bu modul1.py modülünü kullanıyoruz.
# Peki yazdığımız bir modülü her yerden kullanmak için ne yapacağız ? Bunun için yazdığımız modul1.py dosyasının 
# Python35/Lib klasörünün altına atmamız gerekiyor. 
# Böylelikle bu modülü de math modülü gibi her dosyada kullanabiliriz.

########## modul1.py ###########
programlama_dilleri = ["Python", "PHP", "Java", "C"]

def toplama(a, b, c):
    return a + b + c

def selamla(isim):
    print("Selam : ", isim)


######## deneme.py ###########
import modul1

print(modul1.toplama(3,4,5))

modul1.selamla("Sinan")

print(modul1.programlama_dilleri)


# Oluşturduğumuz modülleri Yerel Disk C: üzerinden python'un kurulu olduğu yerdeki lib klasörünün 
# içine atılırsak istediğimiz zaman bu oluşturudumuz modülleri ana projemize import edebiliriz.