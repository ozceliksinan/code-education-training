#######################################
# Writed by Sinan Özçelik             #
#######################################

import  sys
import sqlite3
from PyQt5 import QtWidgets

class Pencere(QtWidgets.QWidget):

    def __init__(self):
        super().__init__()
        self.baglanti_olustur()
        self.init_ui()

    def baglanti_olustur(self):
        baglanti = sqlite3.connect("database.db") # Veritabanı bağlantısı gerçekleştirildi.
        self.cursor = baglanti.cursor() # Veritabanı üzerinde işlem gerçekleştirebilmek için cursor değişkeni oluşturalım.
        self.cursor.execute("Create Table If not exists üyeler (kullanıcı_adı TEXT,parola TEXT)") # Sorgu çalıştıralım. Execute-> Sorgu çalıştırma kodu
        baglanti.commit() # Veritabanı çalıştırılır.
        # INSERT INTO üyeler VALUES("sinanprogram", 123456) sqlite kısmında bu sorguyu çalıştıralım. (Yönetici ekleyelim.)

    def init_ui(self):
        self.kullanici_adi =  QtWidgets.QLineEdit()
        self.parola = QtWidgets.QLineEdit()
        self.parola.setEchoMode(QtWidgets.QLineEdit.Password) # Girilen karakterler gözükmeyecektir.
        self.giris = QtWidgets.QPushButton("Giriş Yap")
        self.yazi_alani = QtWidgets.QLabel("")

        v_box = QtWidgets.QVBoxLayout()
        v_box.addWidget(self.kullanici_adi)
        v_box.addWidget(self.parola)
        v_box.addWidget(self.yazi_alani)
        v_box.addStretch()
        v_box.addWidget(self.giris)

        h_box = QtWidgets.QHBoxLayout()
        h_box.addStretch()
        h_box.addLayout(v_box)
        h_box.addStretch()


        self.setLayout(h_box)
        self.setWindowTitle("Kullanıcı Girişi") # Pencere başlığı
        self.giris.clicked.connect(self.login) # Buttona tıklanıldığında çalışacak olan fonksiyon belirtildi.

        self.show() # Penceremizi gösterelim.

    def login(self):
        adi = self.kullanici_adi.text() # Formda girilen kullanıcı adı yakalandı
        par = self.parola.text() # Formda girilen şifre yakalandı.

        # Yukarıda yakalanan 2 değeri veritabanımıza gönderelim.
        self.cursor.execute("Select * From üyeler where kullanıcı_adı = ? and parola = ?",(adi,par)) # Sorgulama işlemi yapılır.

        data = self.cursor.fetchall() # Sorgudan herhangi bir değer dönerse fetchall ile yakalanır ve data değişkenimize atanır.

        if len(data) == 0:
            self.yazi_alani.setText("Böyle bir kullanıcı yok\nLütfen tekrar deneyin.")
        else:
            self.yazi_alani.setText("Hoşgeldiniz " + adi)

app = QtWidgets.QApplication(sys.argv)

pencere = Pencere()

sys.exit(app.exec_())