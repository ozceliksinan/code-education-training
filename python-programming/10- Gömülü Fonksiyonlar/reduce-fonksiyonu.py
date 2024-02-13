# Yapısı şu şekildedir;

# reduce(function, iterasyon yapılabilen veritipi(liste vb.))

# reduce() fonksiyonu değer olarak aldığı fonksiyonu soldan başlayarak listenin ilk 2 elemanına uygular ve 
# daha sonra çıkan sonucu listenin 3. elemanına uygular ve bu şekilde devam ederek liste bitince bir tane değer döner. 
# Anlamak için örneğimize ve görselimize bakalım.

##################################################################################################################
from functools import reduce  # reduce fonksiyonu son sürümlerde functools modülüne taşındı.

reduce(lambda x,y : x + y , [12,18,20,10])

"""
Çıktı

60
"""

# Burada sonuç neden 60 çıkıyor bakalım. 
# İlk önce 12 ve 18 değeri fonksiyona argüman olarak gidiyor ve toplanarak sonuç 30 çıkıyor. 
# Daha sonra 30 değeriyle bir sonraki eleman olan 20 değeri toplanıyor ve sonuç 50 çıkıyor. 
# En son 50 değeriyle listenin en son elemanı olan 10 değeri toplanıyor ve liste bittiği için sonuç 60 çıkıyor. 
# Bunu aşağıdaki resimde görebiliriz.

from IPython.display import Image
Image(filename='reduce.png')
##################################################################################################################

# Birkaç örnek daha yapalım.

# Bakın 5'in faktöriyelini bulduk.
reduce(lambda x,y : x * y , [1,2,3,4,5])
"""
Çıktı

120
"""
##################################################################################################################

reduce(lambda x,y : x * y , [3,4,5,10])
"""
Çıktı

600
"""

##################################################################################################################

# max fonksiyonu()
max([1,2,3,4,5,6])

"""
Çıktı

6
"""

##################################################################################################################

# reduce ile max fonksiyonu
def maksimum(x,y):
    if (x > y):
        return x
    else:
        return y

reduce(maksimum, [-2,1,100,35,32])
"""
Çıktı

100
"""
##################################################################################################################