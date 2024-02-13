#######################################
# Writed by Sinan Özçelik             #
#######################################

import sys

from PyQt5.QtWidgets import QApplication,QAction,qApp,QMainWindow

class Menu(QMainWindow):

    def __init__(self):

        super().__init__()

        menubar = self.menuBar() # Menübar oluşturalım.

        # 2 tane menü ekleyelim.
        dosya = menubar.addMenu("Dosya") # Menü - 1
        duzenle = menubar.addMenu("Düzenle") # Menü - 2

        # 3 tane Action oluşturalım.
        dosya_ac = QAction("Dosya Aç",self) # 1. Action - Dosya menüsüne tıklanınca açılacak olan profili atayalım. 
        dosya_ac.setShortcut("Ctrl+O") # Dosya menüsünün kısa yol tuşlarını belirtelim.

        dosya_kaydet = QAction("Dosya Kaydet",self) # 2. Action
        dosya_kaydet.setShortcut("Ctrl+S") # Kısa yol tuşlarını belirtelim.

        cikis = QAction("Çıkış", self) # 3. Action
        cikis.setShortcut("Ctrl+Q") # Kısa yol tuşlarını belirtelim.

        # Actionlar oluşturuldu. Aksiyonlar menübar'da gözükmüyor. Menübara aksiyonlarımızı ekleyelim.
        dosya.addAction(dosya_ac)
        dosya.addAction(dosya_kaydet)
        dosya.addAction(cikis)

        # Düzenleye action ekleyelim.
        ara_ve_degistir = duzenle.addMenu("Ara ve Değiştir")

        # Alt menüleri oluşturalım.
        ara = QAction("Ara",self) # Action tanımlayalım.
        degistir = QAction("Değiştir",self) # Action tanımlayalım.

        temizle = QAction("Temizle",self) # Action tanımlayalım.

        # Alt menüleri bu şekilde tanımlayabiliyoruz.
        ara_ve_degistir.addAction(ara) # Menübara actionlarımızı ekleyelim.
        ara_ve_degistir.addAction(degistir)
        
        # Düzenle menüsünün altına ekledik.
        duzenle.addAction(temizle)

        cikis.triggered.connect(self.cikis_yap)

        dosya.triggered.connect(self.response)

        self.setWindowTitle("Menüler")

        self.show()

    def cikis_yap(self):
        qApp.quit()
    def response(self,action):

        if action.text() == "Dosya Aç":
            print("Dosya Aç'a basıldı.")
        elif action.text() == "Dosya Kaydet":
            print("Dosya Kaydet'e basıldı.")
        elif action.text() == "Çıkış":
            print("Çıkış'a basıldı.")

app = QApplication(sys.argv)

menu = Menu()

sys.exit(app.exec_())