#######################################
# Writed by Sinan Özçelik             #
#######################################

# input() fonksiyonu kullanımı
a = input("Lütfen bir sayı giriniz:") 
# Kullanıcıdan aldığımız değer a değişkenine eşit olacak.
print("Kullanıcının girdiği değer:",a)

# Kullanıcının girdiği değer input fonksiyonundan string olarak bize döner!!!!!!!!!
a = input("Lütfen bir sayı giriniz:")
print(type(a))

# Eğer biz bir sayı ile işlem yapacaksak kullanıcıdan aldığımız değere (stringi) float ya da 
# int fonksiyonuyla veri tipi dönüştürme işlemi yapmamız gerekir. Çünkü aşağıdaki gibi bir program yanlış çalışacaktır.

# Hatalı Çalışma
a = input("Lütfen bir sayı giriniz:")
print(a * 3) 
# Girdiğimiz değer 5 ise sonucu 15 bekleriz. Ancak sonuç 555 şeklinde ortaya çıkar.
 
# Doğru Çalışma
a = int(input("Lütfen bir sayı giriniz:")) # Veri tipi dönüşümü
print(a * 3) 