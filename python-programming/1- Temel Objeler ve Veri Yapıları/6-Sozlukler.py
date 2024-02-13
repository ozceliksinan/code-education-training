# Sözlükler
# Sözlüğün içindeki her bir eleman indeks ile değil, anahtar (key), değer (value) olarak tutulur. 
# Bu anlamda gerçek hayattaki sözlüklere oldukça benzerler. Örneğin, elimize bir ingilizce-Türkçe sözlük alıp 
# freedom kelimesini(key ya da anahtar) aradığımız zaman karşılık değer özgürlük (değer ya da value) olarak karşımıza çıkar.

# Sözlük Oluşturmak
# Süslü Parantez ve iki nokta (:) ile anahtar değerlerimizi yerleştirelim.
sözlük1 = {"sıfır":0,"bir":1,"iki":2,"üç":3}
 
print(sözlük1)

# Sözlük Değerlerine Erişmek ve Sözlüğe Değer Eklemek
# Sözlük veritipinin gerçek hayattaki sözlüklere çok benzediğini söylemiştik. 
# Öyleyse, bir değeri (value) elde etmek için, indeksleri değil anahtarları (key) kullanacağız.

print(sözlük1)
# "bir" anahtarına karşılık gelen değeri buluyoruz.
print(sözlük1["bir"])
# "iki" anahtarına karşılık gelen değeri buluyoruz.
print(sözlük1["iki"])

# Başka bir örnek
a = {"bir" : [1,2,3,4], "iki": [[1,2],[3,4],[5,6]],"üç" : 15}
print(a)
# "iki" anahtarının değeri
print(a["iki"])
# İçiçe listeleri biliyoruz.
print(a["iki"][1][1])
print(a["üç"])
a["üç"] += 5
print(a["üç"])
print(a)

# Bir sözlüğe dinamik olarak da eleman ekleyebiliriz.
# Sözlük oluşturalım.
a = {"bir":1,"iki":2,"üç":3}
a["dört"] = 4 
print(a)
# Dikkat ederseniz yeni eklediğimiz anahtar ve değer sözlüğün sonuna eklenmedi. 
# Burada sözlüklerin bir özelliğini daha görüyoruz. Sözlükler diğer veritiplerinden farklı olarak sıralı olmayan bir veritipidir.

# İç içe Sözlükler
# Tıpkı listeler gibi, iç içe sözlükler de oluşturulabilir.
a = {"sayılar":{"bir":1,"iki":2,"üç":3},"meyveler":{"kiraz":"yaz","portakal":"kış","erik":"yaz"}}
print(a["sayılar"]["bir"])
print(a["meyveler"]["kiraz"])

# Temel Sözlük Metodları
yeni_sözlük = {"bir":1,"iki":2,"üç":3}
# values() metodu sözlüğün değerlerini(value) bir liste olarak döner.
print(yeni_sözlük.values())
# keys() metodu sözlüğün anahtarlarını(key) bir liste olarak döner.
print(yeni_sözlük.keys())
# items() metodu sözlüğün anahtar ve değerlerini bir liste içinde demet olarak döner.
print(yeni_sözlük.items())