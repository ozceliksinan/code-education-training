#######################################
# Writed by Sinan Özçelik             #
#######################################

##################################################################################################################

# upper() ve lower()
# upper() metodu stringin tüm karakterlerini büyük harfe çevirir.

# lower() metodu stringin tüm karakterlerini küçük harfe çevirir.

"python".upper()
# 'PYTHON'
"PYTHON".lower()
# 'python'
"PythOn".upper()
# 'PYTHON'
"PythOn".lower()
# 'python'

##################################################################################################################

# replace()

# replace(x,y) : Stringteki x değerlerini y ile değiştirir.

"Herkes ana baba bacı gardaş".replace("a","o")
# 'Herkes ono bobo bocı gordoş'
"Kunduz".replace("duz","zun")
# 'Kunzun'
"Python Programlama Dili".replace(" ","-")
# 'Python-Programlama-Dili'

##################################################################################################################

# startswith() ve endswith()
# startswith(x) : String x ile başlıyorsa True, başlamıyorsa False değeri döndürür.

# endswith(x) : String x ile bitiyorsa True, bitmiyorsa False değeri döndürür.

"Python".startswith("py")
# False
"Python".startswith("Py")
# True
"Python".endswith("on")
# True
"Python".endswith("az")
# False

##################################################################################################################

# split()
# split(a) : Verilen bir a değerine göre string parçalara ayrılarak herbir parça listeye atılır.

liste = "Python Programlama Dili".split(" ") # Boşluk karakterine göre ayrıldı.
print(liste)
# ['Python', 'Programlama', 'Dili']

liste2 = "Python-Php-Java-C-Javascript".split("-")
print(liste2)
# ['Python', 'Php', 'Java', 'C', 'Javascript']

##################################################################################################################

# strip() , lstrip() ve rstrip()
# strip(x) : Stringin başında ve sonunda bulunan x değerlerini siler.

# lstrip(x) : Stringin sadece başında bulunan x değerlerini siler.

# rstrip(x) : Stringin sadece sonunda bulunan x değerlerini siler.

"                   python                          ".strip() # değer göndermezsek varsayılan olarak boşluk karakteri
# 'python'

">>>>>>>>>>>>>>Mustafa>>>>>>>>>>>>>>>>>>>>>>>>>>".strip(">")
# 'Mustafa'

"                            python      ".lstrip()
# 'python      '

"                            python      ".rstrip()
# '                            python'

##################################################################################################################

# join() Listenin elemanlarını bir string değeriyle birleştirmemizi sağlar.

liste = ["21","02","2014"]
"/".join(liste)
# '21/02/2014'

liste = ["T","B","M","M"]
".".join(liste)
# 'T.B.M.M'

##################################################################################################################

# count()
# count(x): Stringin içindeki x değerlerini sayar.

count(x,index): Stringin içindeki x değerlerini verilen index değerinden başlayarak saymaya başlar.

"ada kapısı yandan çarklı".count("a")
# 6
"ada kapısı yandan çarklı".count(" ")
# 3
"ada kapısı yandan çarklı".count("a",2)
# 5

##################################################################################################################

# find() ve rfind()
# find(x) : x değerini baştan itibaren string içinde arar ve bulursa ilk bulduğu indeksi döndürür. Bulamazsa "-1" değerini verir.

# rfind(x) : x değerini sondan itibaren string içinde arar ve bulursa ilk bulduğu indeksi döndürür. Bulamazsa "-1" değerini verir.

"araba".find("a")
# 0
"araba".find("s")
# -1
"araba".rfind("a")
# 4
"araba".rfind("s")
# -1
##################################################################################################################