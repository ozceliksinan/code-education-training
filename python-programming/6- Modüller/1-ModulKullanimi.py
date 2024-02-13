#######################################
# Writed by Sinan Özçelik             #
#######################################

# Pythonda aslında her bir dosya bir modüldür ve her bir modül içinde fonksiyonlar, sınıflar ve objeler barındırır. 
# Biz de bu modülleri programımıza dahil ederek içindeki fonksiyonlardan, sınıflardan ve objelerden faydalanabiliriz.

# Pythonda da modül kavramı oldukça önemli bir kavramdır. 
# Bir Python modülünü programımıza dahil ederek bu modüller içinde yazılan fonksiyonlardan ve 
# sınıflardan kullanabilir ve programlarımızı daha efektif bir şekilde yazabiliriz. 
# Eğer modül diye bir kavram olmasaydı, programlarımızdaki herbir fonksiyonu ve sınıfı kendimiz yazmak zorunda kalacaktık.

# Modül Kullanımı – math Modülü

# Yöntem1 – import modül_adı
# Bir modülü içeri aktarmak yani programımıza dahil etmek için import modül_adı yazabiliriz. 
# İsterseniz bunun için math modülünü içeri aktaralım.

import math # Modülü içeri aktarıyoruz. Artık bu modülün tüm fonksiyonlarını kullanabiliriz.
print(dir(math)) # Math modülünün içindekileri görmek için dir fonksiyonunu kullanabiliriz.
print(help(math)) # Fonksiyonların görevlerini görebilmek için help fonksiyonunu kullanabiliriz.

# Peki bu içeri aktarma yöntemiyle math modülünün herhangi bir fonksiyonunu nasıl kullanacağız ?

# modül_adı.fonksiyonadı()

# Örneğin ilk olarak math modülünün içindeki factorial fonksiyonu ne iş yapıyor bakalım.
print(help(math.factorial))
"""
Çıktı
Help on built-in function factorial in module math:
factorial(...)
    factorial(x) -> Integral
    
    Find x!. Raise a ValueError if x is negative or non-integral.
"""
print(math.factorial(5))
print(math.factorial(10))
"""
Çıktı
120
3628800
"""

# Peki biz bir modülü kendi belirlediğimiz isimle nasıl kullanıyoruz ? Bunun için de şu şekilde bir şey yapacağız.
import math as matematik
print(matematik.factorial(6)) # Modülü artık matematik ismiyle kullanabiliriz.
print(matematik.factorial(0))
"""
Çıktı
720
1
"""

# Yöntem2 – from modül_adı import *
# Bir modülü programımıza dahil etmek için bu yöntemi de kullanabiliriz. 
# İsterseniz math modülünü bu yöntem içeri aktaralım.
# Not: Öncelikle IDLE üzerinden veya Jupyter üzerinden çalışıyorsanız programları tekrardan başlatın.

from math import * # Yıldızın anlamı math modülünün içindeki bütün fonksiyonları almak istediğimizi belirtiyor.

# Peki böyle bir durumda math modülünün içindeki fonksiyonları nasıl kullanacağız. 
# Bunun için modül ismini yazmamıza gerek kalmamaktadır.
# fonksiyon_adı()

print(factorial(5))
"""
Çıktı
120
"""

from math import factorial,floor # Sadece 2 tanesini dahil ettik.
print(factorial(5))
print(floor(3.5))
"""
Çıktı
120
3
"""
ceil(3.4) # Dahil etmediğimiz için hata verdi.