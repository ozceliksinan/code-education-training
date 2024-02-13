import sys
import os

from PyQt5.QtWidgets import QWidget,QApplication,QTextEdit,QLabel,QPushButton,QVBoxLayout,QFileDialog,QHBoxLayout

from PyQt5.QtWidgets import QAction,qApp,QMainWindow

class Notepad(QWidget):
    def __init__(self):
        super().__init__()
        self.init_ui()

    def init_ui(self):
        self.yazi_alani = QTextEdit() # Text Edit şeklinde bir bölüm oluşturalım.

        self.temizle = QPushButton("Temizle") # Temizle butonumuzu oluşturalım.
        self.ac = QPushButton("Aç") # Aç butonumuzu oluşturalım.
        self.kaydet = QPushButton("Kaydet") # Kaydet butonumuzu oluşturalım.

        h_box = QHBoxLayout()

        h_box.addWidget(self.temizle)
        h_box.addWidget(self.ac)
        h_box.addWidget(self.kaydet)

        v_box = QVBoxLayout()

        v_box.addWidget(self.yazi_alani)

        v_box.addLayout(h_box)

        self.setLayout(v_box)

        self.setWindowTitle("NotePad  Uygulamamız")
        self.temizle.clicked.connect(self.yaziyi_temizle) # Temizle butonumuza fonksiyon ekleyelim.
        self.ac.clicked.connect(self.dosya_ac) # Dosya açma butonumuza fonksiyon ekleyelim.
        self.kaydet.clicked.connect(self.dosya_kaydet) # Kaydetme butonumuza fonksiyon ekleyelim.

    def yaziyi_temizle(self): # Yazılan yazıları temizleme fonksiyonumuz.
        self.yazi_alani.clear()

    def dosya_ac(self):
        dosya_ismi = QFileDialog.getOpenFileName(self,"Dosya Aç",os.getenv("HOME")) 
        # Fonksiyon demet döndürür. Seçilen dosyanın yol uzantsı döner. (Bilgisayardaki yeri)
        with open(dosya_ismi[0],"r") as file: # Açılan dosyanın okunması
            self.yazi_alani.setText(file.read())

    def dosya_kaydet(self):
        dosya_ismi = QFileDialog.getSaveFileName(self,"Dosya Kaydet",os.getenv("HOME"))

        with open(dosya_ismi[0],"w") as file:

            file.write(self.yazi_alani.toPlainText())

class Menu(QMainWindow):

    def __init__(self):

        super().__init__()

        self.pencere = Notepad()

        self.setCentralWidget(self.pencere)

        self.menuleri_olustur()
    def menuleri_olustur(self):

        menubar = self.menuBar()

        dosya = menubar.addMenu("Dosya")

        dosya_ac = QAction("Dosya Aç",self)
        dosya_ac.setShortcut("Ctrl+O")

        dosya_kaydet = QAction("Dosya Kaydet",self)

        dosya_kaydet.setShortcut("Ctrl+S")

        temizle = QAction("Dosyayı Temizle",self)
        temizle.setShortcut("Ctrl+D")

        cikis = QAction("Çıkış",self)

        cikis.setShortcut("Ctrl+Q")

        dosya.addAction(dosya_ac)
        dosya.addAction(dosya_kaydet)
        dosya.addAction(temizle)
        dosya.addAction(cikis)

        dosya.triggered.connect(self.response)

        self.setWindowTitle("Metin Editörü")

        self.show()

    def response(self,action):

        if action.text() == "Dosya Aç":
            self.pencere.dosya_ac()

        elif action.text() == "Dosya Kaydet":
            self.pencere.dosya_kaydet()
        elif action.text() == "Dosyayı Temizle":
            self.pencere.yaziyi_temizle()

        elif action.text() == "Çıkış":
            qApp.quit()

app = QApplication(sys.argv)

menu = Menu()


sys.exit(app.exec_())