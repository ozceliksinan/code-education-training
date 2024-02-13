#######################################
# Writed by Sinan Özçelik             #
#######################################

# --------------------------------------------------------------------------------------------------------------------------------------------------- #
# Sqlite Veritabanı ve Tablo Oluşturma
# Bu konuyla beraber Python ile Sqlite Veritabanı nasıl kullanılır öğrenmeye çalışacağız. 
# Veritabanı konusu çok çok uzun incelenmesi gereken bir konu olduğu için bu bölümde sadece Sqlite veritabanını basit anlamda incelemeye çalışacağız.

# Veritabanı nedir ?
# Veritabanı uygulamalarımızda , websitelerimizde veya en genel anlamda programlarımızda gerekli olan bilgileri depoladığımız bir yapıdır. 
# Örneğin , Facebook'un kullanıcıları, gönderileri tuttuğu veritabanları gibi. Günümüzde kullanılan bazı veritabanı türleri şunlardır;


# 			Relational Database (İlişkisel Veritabanları) : Tablolardan oluşur. Mysql, Sqlite vs.
#           DocumentBased Database (Doküman Veritabanları) : Dokümanlardan oluşur. MongoDb, Azure DocumentDb
#                                //
#                                //
#                                //

# Bizim bu bölümde inceleyeceğimiz veritabanı Sqlite ilişkisel bir veritabanıdır ve bu veritabanı tablolardan oluşur. 
# Her bir tablo veritabanında belli gruplanmış verileri tutar. Örnek bir tablo yapısı şu şekildedir;

from IPython.display import Image
Image(filename='Tablo.png')

# Buradaki tabloda , İsim,Yazar,Yayınevi,Sayfa Sayısı gibi özellikler bizim 
# tablomuzun özellikleridir ve her bir satırda herhangi bir kitabın özellikleri saklanır. 
# Tabloları tıpkı bir excel dosyası gibi düşünebilirsiniz.
"""
Sqlite Veritabanı
Bu bölümde göreceğimiz Sqlite veritabanı diğer veritabanları gibi sunucu kurmamızı gerektirmez, yani sunucusuz bir veritabanıdır. 
Bu anlamda herhangi bir programımızın yanına direk olarak kurulabilir. Peki bu veritabanı üzerinde tablo oluşturma, 
veri ekleme gibi işlemlerimizi nasıl gerçekleştireceğiz ? İlişkisel veritabanları tablo işlemlerini SQL(Structured Query Language) 
adında bir sorgulama diliyle gerçekleştirir. Ancak bu sorgulama dili çok kapsamlı olduğu için bu bölümde sadece belli başlı sorguları göstermeye çalışacağım.

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

Sqlite Veritabanı Oluşturma
	1. import sqlite3 -  Modülümüzü dahil ediyoruz.
	2. con = sqlite3.connect("kütüphane.db") - kütüphane.db veritabanını oluşturup bağlanıyoruz.
	Eğer öyle bir veritabanı varsa bağlanıyoruz. Bağlantıyı con isimli bir değişkene atıyoruz.
	3.  Database üzerinde Sql sorgularını çalıştırmak için cursor bir tane imleç oluşturuyoruz. 
	"cursor =  con.cursor()
	4. Veritabanı işlemlerinin sonunda con.close() ile bağlantımızı koparıyoruz.

veritabanına bağlantı işlemini şu şekilde bir kod ile yapabiliriz. Bu işlemleri bilgisayarınızda yapmaya çalışın.

"""

import sqlite3 # Sqlite'yı dahil ediyoruz

con = sqlite3.connect("kütüphane.db") # Tabloya bağlanıyoruz.

cursor = con.cursor() # cursor isimli değişken veritabanı üzerinde işlem yapmak için kullanacağımız imleç olacak.

con.close() # Bağlantıyı koparıyoruz.

# --------------------------------------------------------------------------------------------------------------------------------------------------- #
"""

Kitaplık Tablosu oluşturma
Veritabanında kitaplık isimli bir tablo oluşturmak için şu 2 sorgudan birini kullanabiliriz.
CREATE TABLE kitaplık (İsim TEXT, Yazar TEXT, Yayınevi TEXT , Sayfa_Sayısı INT) 
- Bu sorgu kitaplık isimli bir tablo oluşturacak ve bu tablonun özellikleri 
İsim (TEXT --> String),Yazar(TEXT --> String),Yayınevi (TEXT ---> String), Sayfa_Sayısı(INT --- int) olacak. 
Ancak bu sorguyu arda arda çalıştırırsak "Tablo Already Exists" hatası alacağız.

CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT, Yazar TEXT, Yayınevi TEXT , Sayfa_Sayısı INT) 
- Bu sorgu tablo yoksa oluşturacak, tablo varsa hata vermeyecektir. 
Kodlarımız şu şekilde;

"""

import sqlite3 # Sqlite'yı dahil ediyoruz

con = sqlite3.connect("kütüphane.db") # Tabloya bağlanıyoruz.

cursor = con.cursor() # cursor isimli değişken veritabanı üzerinde işlem yapmak için kullanacağımız imleç olacak.

def tablo_oluştur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT, Yazar TEXT, Yayınevi TEXT, Sayfa_Sayısı INT)") # Sorguyu çalıştırıyoruz.
    con.commit() # Sorgunun veritabanı üzerinde geçerli olması için commit işlemi gerekli.
tablo_oluştur()
con.close() # Bağlantıyı koparıyoruz.
# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Şimdi de kitaplık tablomuza veri eklemeye çalışalım. Çalıştıracağımız sorgu şu olacak;
# INSERT INTO kitaplık VALUES('İstanbul Hatırası','Ahmet Ümit','Everest',561)
# Not : SQL Sorguları büyük veya küçük harfle de yazılabilir. Örnek olarak
# insert into kitaplık values ('İstanbul Hatırası','Ahmet Ümit','Everest',561)
# Insert Into kitaplık Values ('İstanbul Hatırası','Ahmet Ümit','Everest',561)

import sqlite3 # Sqlite'yı dahil ediyoruz

con = sqlite3.connect("kütüphane.db") # Tabloya bağlanıyoruz.

cursor = con.cursor() # cursor isimli değişken veritabanı üzerinde işlem yapmak için kullanacağımız imleç olacak.

def tablo_oluştur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT, Yazar TEXT, Yayınevi TEXT, Sayfa_Sayısı INT)") # Sorguyu çalıştırıyoruz.
    con.commit() # Sorgunun veritabanı üzerinde geçerli olması için commit işlemi gerekli.
    # Ancak bu sorguyu arda arda çalıştırırsak "Tablo Already Exists" hatası alacağız.

def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("INSERT INTO kitaplık VALUES('İstanbul Hatırası','Ahmet Ümit','Everest',261)")
    con.commit()

tablo_oluştur()

con.close() # Bağlantıyı koparıyoruz.

# --------------------------------------------------------------------------------------------------------------------------------------------------- #
# Peki kullanıcıdan aldığımız değerleri tabloya nasıl ekliyoruz ? Onun için de sorgumuzu ve kodumuzu biraz değiştireceğiz.

import sqlite3 

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor() 

def tablo_oluştur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT, Yazar TEXT, Yayınevi TEXT, Sayfa_Sayısı INT)") 
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("INSERT INTO kitaplık VALUES(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
isim = input("İsim:")
yazar = input("Yazar:")
yayınevi = input("Yayınevi:")
sayfa_sayısı =  int(input("Sayfa Sayısı:"))


deger_ekle(isim,yazar,yayınevi,sayfa_sayısı)

con.close()

# ? işaretlerinin herbirinin yerine fonksiyona değer olarak gönderdiğimiz isim , yazar, yayıevi ve sayfa sayısı bilgileri gidiyor ve 
# tablomuza bu şekilde veri ekleyebiliyoruz. 

# --------------------------------------------------------------------------------------------------------------------------------------------------- #
# Select * From kitaplık - Tablodaki tüm bilgileri almamızı sağlar.
# Select İsim,Yazar From kitaplık Tablodaki tüm bilgileri sadece İsim ve Yazar özelliklerini almamızı sağlar.
# Select * From kitaplık where Yayınevi = 'Everest' Sadece Yayınevi özelliği Everest olanları alır.
# Şimdi isterseniz ilk sorgumuzu çalıştırdığımız kodumuzu yazalım.

import sqlite3

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor()
def tablo_olustur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT,Yazar TEXT,Yayınevi TEXT,Sayfa_Sayısı INT)")
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("Insert into kitaplık Values(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
def verileri_al():
    cursor.execute("Select * From kitaplık") # Bütün bilgileri alıyoruz.
    data = cursor.fetchall() # Veritabanından bilgileri çekmek için fetchall() kullanıyoruz.
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
    # con.commit() işlemine gerek yok. Çünkü tabloda herhangi bir güncelleme yapmıyoruz.
verileri_al()
con.close()

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# İkinci sorgumuzu çalıştırdığımız kodumuzu da yazalım.

import sqlite3

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor()
def tablo_olustur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT,Yazar TEXT,Yayınevi TEXT,Sayfa_Sayısı INT)")
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("Insert into kitaplık Values(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
def verileri_al():
    cursor.execute("Select * From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al2():
    cursor.execute("Select İsim,Yazar From kitaplık") # Sadece İsim ve Yazar özelliklerini alıyoruz.
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
verileri_al2()
con.close() 

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Son olarak da 3. sorgumuzu çalıştırdığımız kodumuzu da yazalım.

import sqlite3

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor()
def tablo_olustur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT,Yazar TEXT,Yayınevi TEXT,Sayfa_Sayısı INT)")
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("Insert into kitaplık Values(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
def verileri_al():
    cursor.execute("Select * From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al2():
    cursor.execute("Select İsim,Yazar From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al3(yayınevi):
    cursor.execute("Select * From kitaplık where Yayınevi = ?",(yayınevi,)) # Sadece yayınevi ,Everest olan kitapları alıyoruz.
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
verileri_al3("Everest")
con.close()                                                                     

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Verileri Güncelleme
# Tablodaki verileri güncelleme için şöyle bir sorgu kullanabiliriz.
# Update kitaplık set Yayınevi = 'Everest' where Yayınevi = 'Doğan Kitap' -- Yayınevi 'Doğan Kitap' olan kitapların Yayınevi bilgilerini 'Everest' e günceller.
# Şimdi isterseniz bu sorguyu çalıştırdığımız kodumuzu yazalım.

import sqlite3

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor()
def tablo_olustur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT,Yazar TEXT,Yayınevi TEXT,Sayfa_Sayısı INT)")
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("Insert into kitaplık Values(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
def verileri_al():
    cursor.execute("Select * From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al2():
    cursor.execute("Select İsim,Yazar From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al3(yayınevi):
    cursor.execute("Select * From kitaplık where Yayınevi = ?",(yayınevi,))
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verigüncelle(yayınevi):
    cursor.execute("Update kitaplık set Yayınevi = ? where Yayınevi =  ?",("Everest",yayınevi))
    con.commit()

verigüncelle("Doğan Kitap")
con.close()

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Verileri Silme
# Tablodaki verileri silme için şöyle bir sorgu kullanabiliriz.
# Delete From kitaplık where Yazar = 'Ahmet Ümit' -- Yazar özelliği 'Ahmet Ümit' olan kitapları tablodan siler.
# Şimdi isterseniz bu sorguyu çalıştırdığımız kodumuzu yazalım.

import sqlite3

con = sqlite3.connect("kütüphane.db")

cursor = con.cursor()
def tablo_olustur():
    cursor.execute("CREATE TABLE IF NOT EXISTS kitaplık (İsim TEXT,Yazar TEXT,Yayınevi TEXT,Sayfa_Sayısı INT)")
    con.commit()
def deger_ekle(isim,yazar,yayınevi,sayfa_sayısı):
    cursor.execute("Insert into kitaplık Values(?,?,?,?)",(isim,yazar,yayınevi,sayfa_sayısı))
    con.commit()
def verileri_al():
    cursor.execute("Select * From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al2():
    cursor.execute("Select İsim,Yazar From kitaplık")
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verileri_al3(yayınevi):
    cursor.execute("Select * From kitaplık where Yayınevi = ?",(yayınevi,))
    data = cursor.fetchall()
    print("Kitaplık Tablosunun bilgileri.....")
    for i in data:
        print(i)
def verigüncelle(yayınevi):
    cursor.execute("Update kitaplık set Yayınevi = ? where Yayınevi =  ?",("Everest",yayınevi))
    con.commit()
def verilerisil(yazar):
    cursor.execute("Delete  From kitaplık where Yazar = ?",(yazar,))
    con.commit()
    
verilerisil("Ahmet Ümit")
con.close()   

# --------------------------------------------------------------------------------------------------------------------------------------------------- #