<h4>Google Maps</h4>

-Ugulamamızda google maps servisini kullanabilmek için google'dan bir api key almamız gerekir.

- Andorid'de google maps için hazır template bulunur. Bu template seçildiğinde bir kaç dosya oluşur ve konfigurasyon ayarlanır.
  Values klasöründe oluşan google_maps_api.xml  dosyasında api key oluşturmak için uygulamaya özel bir url bulunur.
  Bu url den api key alınır ve  aynı dosyada bulunan your_key_here yazan yere yapıştırılır. Uygulama artık maps servisini kullanmaya hazır durumdadır.
  
- **onMapReady()** harita hazır duruma geçtiğinde çalışan mehoddur. Bu method içerisinde örneğin kullanıcının konumunu gösterebiliriz.

- **GeoCoder :** enlem boylamı adrese(sokak,caddde,bölge...) veya tersi işlem yapmaya yarayan sınıftır. Bu sınıfın **getFromLocationName()** methodu, verilen string ifadeye 
göre Address listesi döndürür. Address listesi bir int parametre ile sınırlandırılabilir. Örneğin 2 parametresini verirsek string ifadeye göre en populer 2 address döner.

- **Address :** enlem,boylam,ülke ismi,sokak adı,cadde adı,posta kodu... gibi değerleri tutan sınıftır.

- **LatLng :**  enlem ve boylamı tutan  sınıftır.

- mMap nesnesi, harita üzerinde işlemler yapmak için **GoogleMaps** referansıdır. Harita hazır olduğunda haritamız bu referansa initialize edilir.

- mMap nesnesinin: <br>
**addMarker()**  methodu ile herhangi bir konuma marker ekleyebiliriz. MarkerOption parameteresi alır. <br>
**moveCamera()** methodu ile kamerayı başka konuma yönlendirebiliriz.  <br>
**setMapType()** methodu ile haritanın tipini değiştirebiliriz. <br>
**setMyLocationEnabled()** methodu ile kullanıcının konumunu gösterebiliriz. (izin gerekli) 