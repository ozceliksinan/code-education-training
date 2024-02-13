"""
PyQt 5 Nedir?
Kullanıcılarına grafiksel arayüz (GUI) deneyimi sunmak için geliştirilmiş Python kütüphanesidir. 
Python kullanarak sadece komut satırları hazırlayarak programlar yazmamız mümkündür. 
Kullanıcıya arayüz sunmak için bunu tasarlamamızı gerçekleştirecek ek bir kütüphaneye ihtiyaç vardır. 
PyQt bu ihtiyaca cevap vermek için oluşturulmuş bir kütüphane olarak karşımıza çıkmaktadır. 

PyQt5 Kurulumu

Bu bölümle birlikte artık PyQt5 arayüz geliştirme işlemlerimize başlıyoruz. 

PyQt5 , Python ile hazır olarak gelmediği için bunu ilk olarak kurmamız gerekiyor.

Linux Dağıtımlar İçin Kurulum
        1. Terminali açıyoruz. 
        2. İlk olarak şu komutu çalıştırıyoruz. "sudo apt-get install python3-pyqt5"
        3. Daha sonra şu komutu çalıştırıyoruz. "sudo apt-get install python3-pyqt5.qtsql"
        4. En son şu komutu çalıştırıyoruz. "sudo apt-get install qttools5-dev-tools"

Windows İşletim Sistemi İçin Kurulum
1.İlk olarak şu linke gidiyoruz. https://sourceforge.net/projects/pyqt/files/PyQt5/PyQt-5.6/

2.Buradan 32 bit .exe dosyasını indiriyoruz.

3.İndirdiğimiz dosyayı çalıştırdığımızda bilgisayarımız bunu PyQt5 olarak C:\Python35\Lib\site-packages altına yükleyecek.

4.Artık PyQt5 ile arayüz geliştirebiliriz.

PyQt5' e nasıl çalışmalıyız ?
Şimdi burada yapmam gereken birkaç uyarı var. 
Öncelikle PyQt5 çok kapsamlı modüllerden oluştuğu için sadece en gerekli temel bilgileri ve arayüz geliştirmenin temel mantığını öğretmeye çalışacağım. 
Bu sebeple, her sınıfı , her fonksiyonu ezberlemeye çalışmak pek akılcı olmayacaktır. 
Ayrıca derslerden bağımsız her dersin sonunda mutlaka öğrendiklerimizle ilgili alıştırma yapmalısınız. 
Aceleci davranırsanız maalesef mantığını öğrenemezsiniz. 
Ancak eğer Arayüz Geliştirme mantığını kavrarsanız başka bir programlama dilinde Arayüz Geliştirme mantığına direk aşina olmuş olacaksınız.

"""

import sys

from PyQt5 import QtWidgets, QtGui

def Pencere():

    app = QtWidgets.QApplication(sys.argv)

    pencere = QtWidgets.QWidget() # Bir tane pencere objemiz oluştu.

    pencere.setWindowTitle("PyQt5 Penceremiz") # Penceremizin başlığı.

    etiket1 = QtWidgets.QLabel(pencere) # Etiket penceremizin üzerine yapıştırıldı.
    etiket2 = QtWidgets.QLabel(pencere) # Etiket penceremizin üzerine yapıştırıldı.

    etiket2.setPixmap(QtGui.QPixmap("python.png")) # Resim pencereye eklenmiş oldu.
    etiket1.setText("Burası bir yazıdır!")

    etiket1.move(150,30) # Etiketimiz pencere içerisinde yeri değiştirildi (Width x Height)
    etiket2.move(70, 100)

    pencere.setGeometry(100, 100, 500, 500) # (100x100 Ekrandaki konumu), (500x500 Pencere Boyutu)

    pencere.show() # Application içerisinde göstermek için show komutunu kullanalım.

    sys.exit(app.exec_()) # Program kapatılmadığı sürece çalış anlamına gelir.

Pencere()