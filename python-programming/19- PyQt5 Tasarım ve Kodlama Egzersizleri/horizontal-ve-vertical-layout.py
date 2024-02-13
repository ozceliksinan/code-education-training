#######################################
# Writed by Sinan Özçelik             #
#######################################

import sys

from PyQt5 import QtWidgets

def Pencere():

    # Horizontal Layout: Yatay Şekil
    # Vertical Layout: Dikey Şekil

    app = QtWidgets.QApplication(sys.argv)
    okay = QtWidgets.QPushButton("Tamam")
    cancel = QtWidgets.QPushButton("İptal")

    h_box = QtWidgets.QHBoxLayout() # Horizontal Box Layout (Yatay kutu)

    h_box.addStretch() 
    # addStretch(): Sağ tarafa doğru yaslandı. 
    # Eğer buttonlar eklendikten sonra yapılsaydı sağa yaslardı. 
    # Ortaya konulsaydı iki buttonu ayırırdı
    h_box.addWidget(okay)
    h_box.addWidget(cancel)

    v_box = QtWidgets.QVBoxLayout()

    v_box.addStretch()
    v_box.addLayout(h_box) # Horizontal Box Layout penceremize eklendi.

    pencere = QtWidgets.QWidget()
    pencere.setWindowTitle("PyQt5 Ders 4")

    pencere.setLayout(v_box)

    pencere.setGeometry(100,100,500,500)

    pencere.show()

    sys.exit(app.exec_())

Pencere()