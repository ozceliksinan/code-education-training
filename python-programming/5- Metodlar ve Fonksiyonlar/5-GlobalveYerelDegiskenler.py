#######################################
# Writed by Sinan Özçelik             #
#######################################

# Pythonda her bir değişkenin, fonksiyonun ve ileride göreceğimiz sınıfların(class) 
# aslında bir kapsamı(scope) bulunur ve Python herbir değişkeni bir isim alanında (namespace) tanımlar. 
# Değişkenlerin İsim alanı ise, bu değişkenlerin nerelerde var olduğunu ve nerelerde kullanılabileceğini gösterir.
# Pythonda fonksiyonlarda tanımlanan değişkenler Python tarafından Yerel (Local) değişkenler olarak tanımlanırlar. 
# Yani bir fonksiyon bloğunda oluşturulan değişkenler fonksiyona özgüdür ve fonksiyon çalışmasını 
# bitirdikten sonra bu değişkenler bellekten silinir ve yok olur. 
# Böylelikle , fonksiyon içinde tanımlanmış bir değişkene başka bir yerden erişilemez.
# Pythonda en genel kapsama sahip değişkenler ise Global değişkenler olarak tanımlanırlar ve 
# global değişkenlere tanımlandığı andan itibaren programın her yerinden ulaşabiliriz.
# Yerel değişkenleri anlamak için bir tane fonksiyon tanımlayalım.

def fonksiyon():
    a = 10 # Yerel isim alanında bir değişken
    print(a)
fonksiyon() 
print(a)  # a değişkeni yok oldu.
# a degişkeni lokal blokta olduğu için program bunu bulamadı.


a = 5 # Global isim alanında bir değişken .
def fonksiyon():
    print(a) # a değişkeni globalde tanımlandığı için burada tanımlı. 
fonksiyon()
"""
Çıktı
5
"""

c = 10 # Globalde tanımlanmış bir değişken 
def fonksiyon():
    c = 2 # Yerelde tanımlanmış bir değişken
    print(c)  # Yerel değişken kullanılıyor.
fonksiyon()
print(c)
"""
Çıktı
2
10
"""

# Kodumuz çalıştığında ilk olarak c isimli global değişken oluşuyor. 
# Fonksiyon çağrıldığında ise c isimli başka bir yerel değişken oluşuyor gibi düşünebilirsiniz. 
# Böyle bir durumda elimizden iki tane c değişkeni var. 
# Python bu durumda global c değişkeni yerine kendi yerel c değişkenini kullanıyor.



# Global Deyimi
# Peki bir fonksiyonda globalde tanımlanmış bir değişkeni nasıl kullanacağız ? 
# Bunun için Pythonda global ifadesi bulunmaktadır. Şimdi aşağıdaki kodu beraber inceleyelim.

d = 10
def fonksiyon():
    global d
    
    d = 4
    print(d)
fonksiyon()
print(d)
"""
Çıktı
4
4
"""

# Bu durumda kodumuz ne yapıyor ? İlk olarak program başladığı zaman, 
# bir tane global d değişkeni oluşuyor ve 
# fonksiyonumuz çağrıldığında global d ifadesiyle globaldeki d 
# değişkenini kullanmak istediğimizi söylüyoruz. 
# Böyle d = 4 ifadesiyle bir tane daha d değişkeni oluşturmuyoruz. 
# Böylelikle d =4 ifadesiyle globaldeki değişkeninin değerini değiştirmiş oluyoruz.

# İşte Global ve Yerel değişkenler bu şekilde düşünülebilir. 
# Burada gördüğümüz gibi, Yerel değişkenler bir fonksiyon bloğunda içinde tanımlanır. 
# Peki bir if veya while bloğunda yerel bir değişken tanımlanır mı hemen bakalım

if True:
    t = 10
    print(t)
print(t)
"""
Çıktı
10
10
"""

while True:
    deger =  10
    print(deger)
    break
print(deger)
"""
Çıktı
10
10
"""
# Burada gördüğümüz gibi, if ve while bloklarında tanımlanan değişkenler yerel bir 
# değişken yerine global bir değişken olmaktadır.