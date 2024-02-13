#######################################
# Writed by Sinan Özçelik             #
#######################################

###############################################################################################################################
#Kullanıcıdan aldığınız 3 tane sayıyı çarparak ekrana yazdırın. Ekrana yazdırma işlemini format metoduyla yapmaya çalışın.
a = int(input("a:"))
b = int(input("b:"))
c = int(input("c:"))
 
çarpım = a * b * c
 
print("{} x {} x {} = {} dir".format(a,b,c,çarpım))

###############################################################################################################################
#Kullanıcıdan aldığınız boy ve kilo değerlerine göre kullanıcının beden kitle indeksini bulun. Beden Kitle İndeksi : Kilo / Boy(m) Boy(m)
boy = float(input("Boy:"))
kilo = int(input("Kilo:"))
 
print("Beden Kitle İndeksi:",kilo / (boy ** 2))

###############################################################################################################################
#Bir aracın kilometrede ne kadar yaktığı ve kaç kilometre yol yaptığı bilgilerini alın ve sürücünü toplam ne kadar ödemesini gerektiğini hesaplayın.
yakan_miktar = float(input("Kilometrede yakan miktar:"))
 
kilometre = int(input("Kaç km yol yaptınız:"))
 
print("Tutar: {} tl".format(yakan_miktar * kilometre))

###############################################################################################################################
#Kullanıcıdan ad,soyad ve numara bilgisini alarak bunları alt alta ekrana yazdırın.

ad = input("Ad:")
soyad = input("Soyad:")
numara = input("Numara:")
print("\nBilgiler...\n")
print("{}\n{}\n{}".format(ad,soyad,numara))

###############################################################################################################################
#Kullanıcıdan iki tane sayı isteyin ve bu sayıların değerlerini birbirleriyle değiştirin.

a = input("a:")
b = input("b:")
 
print("Değiştirilmeden Önce Değerler\na: {} b: {}\n".format(a,b))
 
a,b = b,a
 
print("Değiştirildikten Sonraki Değerler\na: {} b: {}\n".format(a,b))

###############################################################################################################################

#Kullanıcıdan bir dik üçgenin dik olan iki kenarını(a,b) alın ve hipotenüs uzunluğunu bulmaya çalışın. Hipotenüs Formülü: a^2 + b^2 = c^2
a = int(input("a:"))
 
b = int(input("b:"))
 
c =  (a ** 2 + b ** 2) ** 0.5
 
print("Hipotenüs: ",c)

###############################################################################################################################














