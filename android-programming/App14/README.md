<h4>JSON</h4>

- Json (JavaScript Object Notation) : veri taşıma formatıdır.
- Hem makineler hem de insalar için kolay anlaşılan bir yapısı vardır.
- Programlama dillerinden bağımsızdır ve bir çok programlama dili tarafından desteleniyor.
- 2 veri yapısı kullanır. <br>
  1 : Anahtar-değer iklilerini içeren bir koleksiyon (Json object) <br>
  2 : Sadece değerler içeren bir dizi

- Bir Json objesi {} dir. Arasında anahtar-değer ikilileri bulunur.

- Bir Json dizisi [] dir. Arasında dizi değerleri bulunur.

- Değerler bir string,number,true,false,null,Json object , Json dizisi olabilir.

- Bir Json verisini internetten çekebiliriz. Bunun için URI connection nesnesi kullanılabilir (şuan tercih edilmiyor) veya
  Bu amaçla olşuturulmuş bir kütüphaneyi uygulamamıza ekleyebiliriz. Örneğin : Volley kütüphanesi
  
- İnternnetten json verisi çekmek için internet izni olması gerekir. 
  ```<uses-permission android:name="android.permission.INTERNET"/> android manifeste eklenir.```
- Verilerin düzngün çkilebilmesi için  android manifest application tagının altına ```android:usesCleartextTraffic="true"``` eklenir.
- volley kütüphanesini kullanabilmek için  ``` implementation 'com.android.volley:volley:1.1.1'```   satırı   build.gradle(Module) dependencies altında eklenir.


<h5> Volley kütüphanesi :</h5> 

- **StringRequest  :** bir client olarak sunucudan json verisi çekmek için kullanılır. Dönen değer bir RequestQueue 'e eklenmesi gerekir.

- **parametreler :** request methodu , veri çekilecek adres(url) , gelen cevapları dinleyen ResponseListener nesnesi, hataları dinleyen ErrorListener nesnesi

- ResponseListener'ın onResponse methoduna gelen veriler parametre olarak atanır. Json verisinin parse işlemi
  bu method içerisinde gerçekleşir.
  
- parse işlemi gelen json verisine ögre değişir.

- Örneğin Json verimiz bu şekildeyse : 

```Json
- {
  "Companies": [
    {
      "Heading": "Cloud NX",
      "Detail": "For cloud solution, waiting for you",
      "ImageURL": "http://web.karabuk.edu.tr/yasinortakci/dokumanlar/web_dokumanlari/image1.png"
    },
    {
      "Heading": "Microsoft",
      "Detail": "Best solution for system programs",
      "ImageURL": "http://web.karabuk.edu.tr/yasinortakci/dokumanlar/web_dokumanlari/image2.png"
    },
    {
      "Heading": "Oracle",
      "Detail": "Spatial database is supported now",
      "ImageURL": "http://web.karabuk.edu.tr/yasinortakci/dokumanlar/web_dokumanlari/image3.png"
    }
  ]
} 

```
- onResponse() içerisine bu kodu yazarak ilk nesnenin değerlerini alabiliriz.

```Java
- JSONObject jsonObject=new JSONObject(response);
  JSONArray jsonArray=jsonObject.getJSONArray("Companies");
  
  //Bu kod parçasıyla dizide bulunan ilk Json objesi alınır. (loop ile tüm veriler alınabilir.)
  JSONObject company=jsonArray.getJSONObject(0);
  String heading = company.getString("Heading");
  String detail = company.getString("Detail");
  String imagerUrl = company.getString("ImageURL");
```

<h5>Picasso kütüphenesi : </h5>

- İmage indirmek için kullanılan kütüphanedir. 
implementation 'com.squareup.picasso:picasso:2.71828'

- **kullanım :** 
```Picasso.get().load("http://i.imgur.com/DvpvklR.png").into(imageView);```