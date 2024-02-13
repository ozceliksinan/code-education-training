Android Studio'da izinler Android Manifest dosyasında tutulur. Hangi izni ekleyip, hangisini kaldırmak istiyorsanız ilgili izin isteklerinizi manifest dosyasından silip ekleyebilirsiniz.

```XML
<uses-permission android:name=” ile başlar. application tag ‘inden öncesinde yazılır.
```

Push Notification için kullanılan bu izin Google Servisler’de varolan bağlantıyı kullanır. Android sürüm 3.0 öncesindeki cihazlarda bu izin kullanıcının Google account’ı kurmasını gerektirir.Google account izni Android 4.0.4 ve daha üst sürümlerde gerekli değildir.Eğer GoogleCloudMessaging.register ‘ı kullanılıyorsa herhangi bir Android versiyonunda google accountı konfigürasyonunu yapmaya gerek kalmaz.GoogleCloudMessaging.register kullanılıyorsa eğer gereklidir.Bu izin store’da uygulamanın izinler kısmında kimlik doğrulayıcısı olarak görünür.

GCM ‘den mesajların kullanıcıya ulaşması için :

```XML
<uses-permission android:name="com.google.android.c2dm.permission.RECEIVE" />
```

Uygulamada internet kullanmasına izin verir.

```XML
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name=”android.permission.ACCESS_NETWORK_STATE”/>
<uses-permission android:name=”android.permission.ACCESS_WIFI_STATE” />
```

Uygulama içerisinden telefon numarasının aranmasını sağlar.Bu izin Google Play Store ‘da uygulamanın izinler kısmında telefon olarak görünür.

```XML
<uses-permission android:name="android.permission.CALL_PHONE"/>
```

Kullanıcının rehber(contacts) kısmına erişilmesini sağlar.

```XML
<uses-permission android:name="android.permission.READ_CONTACTS" />
```

Kullanıcının mevcut konumuna erişilmesini sağlar.Ayrıca harita servisi için kullanılan diğer izin(.MAPS_RECEIVE) Google Play Services 3.1.59 sürümünden sonra gereksizdir,silinebilir. Bu izin kullanılırken app kısmını uygulamanızın package ismi verilmesi gerekir.

```XML
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION"/>
<uses-permission android:name=”app.permission.MAPS_RECEIVE” />
```

Uygulama içerisinden kamera veya galeriye erişmeyi sağlamak için aşağıdaki izinler kullanılır.

```XML
<uses-permission android:name=”android.permission.CAMERA” />
<uses-permission android:name=”android.permission.WRITE_EXTERNAL_STORAGE” />
```

Mikrofon kullanılması için aşağıdaki izin gereklidir.

```XML
<uses-permission android:name="android.permission.RECORD_AUDIO" />
```

Takvim'in uygulamada kullanılması, okunup yazılması için gerekli olan izinler :

```XML
<uses-permission android:name="android.permission.READ_CALENDAR" />
<uses-permission android:name="android.permission.WRITE_CALENDAR" />
```

Google Play Servislerin kullanılmasını sağlayan izin :

```XML
<uses-permission android:name="com.google.android.providers.gsf.permission.READ_GSERVICES"/>
```

Kısaca, izinler Android ‘de çok önemlidir. Uygulamanın her kısmı (activities,views,intents,services,notifications,contentproviders) ile etkileşim halindedir.

Api 23 (Marshmallow) öncesi tüm izinler uygulama indirilirken verilirdi. Api 23 ve sonrası için başlangıç izinleri yerine
anlık izinlere geçildi.

<h5>İzin Algoritması</h5>

Örneğin uygulama kameraya erişmek istesin.

- 1- Öncelikle izin kontrolu yapılır. (Kullanıcı bu uygulama için daha önceden kamera erişim izni vermiş mi ?)
- 2- Platform kontrolü yapılır. (Api 23 öncesi mi sonrası mı ? - buna şuan(2020) gerek yok- yerine ActivityCompat geldi)
- 3- Gerekli izin ile ilgili açıklama yapılır (isteğe bağlı)
- 4- izin isteğide bulunulur
- 5- izin isteğine verilen yanıt kontrol edilir. (izin verilmişse kameraya erişilir.) <br><br>

- 1- checkSelfPermission()
- 2- if(Build.VERSION.SDK_INT >=23)  
- 3- shouldShowRequestPermissionRationale() --> Kullanıcının kafası karışıksa true döner - açıklama yaparız. <br>
<stong>Kafası karışık olma durumu :</strong><br>
Uygulama ilk kez çalıştırılıyorsa false döner . (kullanıcının kafası karışık değil) <br>
Uygulama 2.kez veya daha fazla çalıştırılmışsa <br>
--> Eğer izne daha önceden olumsuz yanıt verilmiş ise ve bir daha sorma **işaretlenmişse** false döner . (Kafa karışık değil) <br>
--> Eğer izne daha önceden olumsuz yanıt verilmiş ise ve bir daha sorma **işaretlenmemişse** true döner (Kafa karışık -açıklama yaparız) <br>
- 4- requestPermissions() --> gerekli izinler dizi olarak verilir. Ayrıca doğrulama amaçlı reuest_code verilir.
- 5-onRequestPermissionResult()-->  verilen tüm izinleri bu method karşılar. Bu nedenle override edilmesi gerekir. Request code ile kullanıcının verdiği iznin istediğimiz izin olup olmadığı kontrol edilir.

Not : Anlık izinler sadece dangerous permission için gereklidir.  Ör : kamera,konum,galeri…