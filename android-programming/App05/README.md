<h4>Intent </h4>

- Activity'ler arası geçiş
- Activity'ler arası veri transferi
- Broadcast Receiver çağırma
- Service çağırma
- Sistemde bulunan diğer uygulamaları çağırma (sms,browser,mail,sosyal medya...) 
- ... gibi amaçlar ile kullanılır.

<strong>Not : </strong> Her uygulama faklı özelliklere sahip olduğundan intent tipimiz ve  intent'e set etiğimiz veriler , intentimizi
karşılamasını istediğimiz uygulamaya uygun olmalıdır.

<strong> Intent ile başka bir activity'den veri alıp geri dönebiliriz</strong>

- startActivityForResult() ile veri almak istediğimiz Activity'e geçiş yapılır.
- Bu method gerekli intent ve request_code paramtrelerini alır.
- request_code herhangi bir int sayıdır ve doğrulama amacıyla kullanılır. <br><br>
- setResult() ile veri aldığımız activity'den geri döneriz.
- Bu method gerekli datayı set ettiğimiz intent ve sabit int bir değer (ör :RESULT_OK) paramtrelerini alır. <br><br>
- Gelen datayı karşılamak için onActivityResult() override edilir.
- requestCode ve ResultCode parametreleri ile gelen datanın istekte bulunduğumuz data olup olmadığı kontrol edilir.
- kontrol geçilirse data parametresi istekte bulunduğumuz datadır.