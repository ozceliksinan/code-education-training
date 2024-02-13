<h4>Fragment</h4>

- Fragment kendi layout'u ve sınıfı olan , activity'nin görevlerini yerene getirebilen,  activity'e benzer yapıdır.

- Activity'e göre çok daha az kaynak tüketir ve daha performanslı çalışır.

- Fragmentler bir Activity'e bağlı olarak çalışırlar. Tek başına çalışamazlar.

- Bir Activity birden fazla fragment'e sahip olabilir.

- Fragment bir view'dır. Bir fragment view 'a hangi class ile çalışacağı belirtilmelidir. 

- Fragment bir activity değildir. Bu nedenle fragment class içersinden, activitiye özel methodlara doğrudan erişilemez.

- Fragmentler statik veya dinamik olarak yüklenebilirler.

- statik : fragment activity başlatıldığında yüklenir.

- dinamik : fragment çalışma zamanında, örneğin bir butona tıklandığında oluşturulur.

- onCreateView()  :  fragmentin layoutun'u döndürür. Layout ile ilgili gerekli initialize işlemleri bu method içerisinde yapılır.

- ***Activity içerisinden dinamik olarak fragment yükleme :*** 

```Java
LoginFragment loginFragment = new LoginFragment();
getSupportFragmentManager().beginTransaction().add(R.id.container,loginFragment).commit();
```

- ***Fragment içerisinden dinamik olarak fragment yükleme(değiştirme) :*** 

```Java
RegisterFragment registerFragment = new RegisterFragment();
getFragmentManager().beginTransaction().replace(R.id.container,registerFragment).commit();
```

- registerFragment : yüklenecek fragment
- R.id.container : fragmenin yükleneceği alanın id si

- Not : eğer aynı container'a bir fragment varken add ile başka fragment eklersek öncekinin üzerine eklenir.Bu nedenle replace methodu kullanılır.