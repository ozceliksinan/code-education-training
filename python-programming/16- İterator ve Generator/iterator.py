#######################################
# Writed by Sinan Özçelik             #
#######################################

# "Kareler" isminde bir tane sınıf tanımlayın ve bu sınıfı iterable bir sınıf yapmaya çalışın. 
# Bu sınıfın init fonksiyonu maksimum isimli bir tane parametre alsın ve her next işleminde ekrana üzerinde bulunduğunuz sayının karesi yazdırılsın. 
# StopIteration hatası ekrana maksimum sayıyı geçtiğiniz zaman fırlatılsın.

"""
Örnek olarak;

kareler = Kareler(5)
iteration = iter(kareler)
next(iteration)
1
next(iteration)
4
next(iteration)
9
next(iteration)
16
next(iteration)
25
next(iteration)
---------------------------------------------------------------------------
StopIteration                             Traceback (most recent call last)
<ipython-input-24-94812372e992> in <module>()
----> 1 next(iteration)

<ipython-input-1-105b1e41e5e3> in __next__(self)
     20 
     21             self.sayı = 1
---> 22             raise StopIteration
     23 
     24 

StopIteration: 
"""

class Kareler():
    
    def __init__(self,maksimum):
        self.maksimum = maksimum
        
        self.sayı = 1
        
    def __iter__(self):
        return self
    def __next__(self):
        
        if (self.sayı <= self.maksimum):
            
            sonuc =  self.sayı ** 2
            self.sayı += 1
            return sonuc
        else:
            self.sayı = 1
            raise StopIteration

kareler = Kareler(5)

for i in kareler:
    print(i)

"""
Çıktı:

1
4
9
16
25
"""