#######################################
# Writed by Sinan Özçelik             #
#######################################

import sys
from PyQt5 import  QtWidgets

class Pencere(QtWidgets.QWidget):
    def __init__(self):

        super().__init__()

        self.init_ui() # Ekstra özellikler oluşturmak için fonksiyon oluşturduk.

    def init_ui(self):
        self.yazı_alanı = QtWidgets.QLineEdit() # Yazı alanımızı oluşturduk.
        self.temizle = QtWidgets.QPushButton("Temizle") # Button oluşturduk.
        self.yazdır = QtWidgets.QPushButton("Yazdır")   # Button oluşturduk.

        v_box = QtWidgets.QVBoxLayout() # Vertical (Dikey) Box Layout oluşturalım.

        v_box.addWidget(self.yazı_alanı)
        v_box.addWidget(self.temizle)
        v_box.addWidget(self.yazdır)
        v_box.addStretch()

        self.setLayout(v_box) # Yukarıda oluşan özellikleri penceremize ekleyelim.

        self.temizle.clicked.connect(self.click) # Temizle butonuna tıklanıldığında çalışacak olan fonksiyonu belirtelim.
        self.yazdır.clicked.connect(self.click) # Yazdır butonuna tıklanıldığında çalışacak olan fonksiyonu belirtelim.

        self.show() # Penceremizi açalım.

    def click(self): # 2 buttonumuz var hangisini basıldığını bilmemiz için if şart bloklarını kullanalım.
        sender = self.sender()

        if sender.text() == "Temizle": # Üzerindeki yazıdan yakalayalım. (Hangi butona basıldığını)
            self.yazı_alanı.clear() # Yazı alanımızı temizleyelim.

        else:
            print(self.yazı_alanı.text()) # Girilen değeri yazdıralım. Konsola yazar.

app = QtWidgets.QApplication(sys.argv)

pencere = Pencere()

sys.exit(app.exec_())