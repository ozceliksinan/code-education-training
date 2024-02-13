#######################################
# Writed by Sinan Özçelik             #
#######################################

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# DateTime Modülü
# DateTime modülü Pythonda zaman ve tarih işlemleri için kullandığımız hazır bir modüldür.

from datetime import datetime # Dosyamızı import edelim.

dir(datetime)

"""
Çıktı

['__add__',
 '__class__',
 '__delattr__',
 '__dir__',
 '__doc__',
 '__eq__',
 '__format__',
 '__ge__',
 '__getattribute__',
 '__gt__',
 '__hash__',
 '__init__',
 '__init_subclass__',
 '__le__',
 '__lt__',
 '__ne__',
 '__new__',
 '__radd__',
 '__reduce__',
 '__reduce_ex__',
 '__repr__',
 '__rsub__',
 '__setattr__',
 '__sizeof__',
 '__str__',
 '__sub__',
 '__subclasshook__',
 'astimezone',
 'combine',
 'ctime',
 'date',
 'day',
 'dst',
 'fold',
 'fromordinal',
 'fromtimestamp',
 'hour',
 'isocalendar',
 'isoformat',
 'isoweekday',
 'max',
 'microsecond',
 'min',
 'minute',
 'month',
 'now',
 'replace',
 'resolution',
 'second',
 'strftime',
 'strptime',
 'time',
 'timestamp',
 'timetuple',
 'timetz',
 'today',
 'toordinal',
 'tzinfo',
 'tzname',
 'utcfromtimestamp',
 'utcnow',
 'utcoffset',
 'utctimetuple',
 'weekday',
 'year']

 """

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

 # Şu anki zamanı alma - now()

şu_an = datetime.now()
print(şu_an)
# Çıktı : 2020-07-11 17:01:36.472991
şu_an.year # Yılı alıyoruz.
# Çıktı : 2020
şu_an.month # Ayı alıyoruz. (7. Ay -- Temmuz)
# Çıktı : 7
şu_an.day # Temmuzun  11'i
# Çıktı : 11
şu_an.hour # Saat 5 
# Çıktı : 17
şu_an.minute # 5'i 1 geçiyor.
# Çıktı : 1
şu_an.second # Saniye 36
# Çıktı : 36
şu_an.microsecond # Milisaniye 472991
# Çıktı : 472991

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# ctime() fonksiyonu
# Şu anki zamanı daha güzel göstermek için ctime() fonksiyonunu kullanabiliriz.

print(datetime.ctime(şu_an)) 

# Çıktı: Tue Jul 11 17:01:36 2020

# Peki şu anki zamanın yıl, ay , gün gibi özelliklerin sadece belli bir kısmını nasıl gösterebiliriz ? 
# Bunun için de strftime fonksiyonunu kullanacağız.

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# strftime() fonksiyonu

"""

Yıl bilgisini almak için : %Y

Ay ismini almak için : %B

Gün ismini almak için : %A

Saat bilgisini almak için : %X

Gün bilgisini almak için : %D

"""

# Şimdi bunları kullanmaya çalışalım.

şu_an = datetime.now()
print(datetime.strftime(şu_an,"%Y"))

print(datetime.strftime(şu_an,"%B"))

print(datetime.strftime(şu_an,"%A"))

print(datetime.strftime(şu_an,"%X"))

print(datetime.strftime(şu_an,"%D"))

"""
Çıktı:

2020
July
Tuesday
17:10:14
07/11/17

"""

print(datetime.strftime(şu_an,"%Y %B"))
# Çıktı 2020 July

print(datetime.strftime(şu_an,"%Y %B %A"))
# Çıktı 2020 July Tuesday

# Buradaki yazıları Türkçe yapmaya çalışalım.

import locale
print(locale.setlocale(locale.LC_ALL,""))

# Turkish_Turkey.1254

print(datetime.strftime(şu_an,"%Y %B %A")) # locale ile bulunduğumuz yerin diline çevirebiliyoruz.

# Çıktı 2020 Temmuz Salı

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# timestamp() ve fromtimestamp()
# Şu anki zamanı saniye cinsinden bulmak için, datetime objemizi (şu_an objesi) timestamp() fonksiyonumuza gönderebiliriz. 
# Aynı zamanda saniye cinsinden verilmiş bir zamanı da fromtimestamp fonksiyonuyla datetime objesine çevirebiliriz.

şu_an
# Çıktı datetime.datetime(2020, 7, 11, 17, 10, 14, 253746)

datetime.timestamp(şu_an)
# Çıktı 1499782214.253746

saniye =  datetime.timestamp(şu_an)
zaman =  datetime.fromtimestamp(saniye)
print(zaman)
# Çıktı 2020-07-11 17:10:14.253746

# --------------------------------------------------------------------------------------------------------------------------------------------------- #

# Belli iki tarih arasındaki farkı bulmak
# Kendimiz bir datetime objesi oluşturmak istersek, yıl,ay,gün,saat,dakika,saniye ve mikrosaniyeleri sırasıyla girmeliyiz. 
# Ancak sadece belli özellikleri de girerek bir tane datetime objesi oluşturabilirsiniz.

tarih = datetime(2022,12,1) 
şu_an = datetime.now()
fark = tarih - şu_an
fark
# Çıktı datetime.timedelta(872, 23304, 341519)

fark.days # 872 gün kalmış
# Çıktı 872

fark.seconds # 23304 gün kalmış
# Çıktı 23304

fark.microseconds # 341519
# Çıktı 341519

# --------------------------------------------------------------------------------------------------------------------------------------------------- #