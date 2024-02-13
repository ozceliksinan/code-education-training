<h4>SQLite</h4>

- SQLite local veritabanı oluşturmak için kullanılan kütüphanedir. Android mimrasine gömülü olarak geldiğinden ekstra olarak uygulamaya eklemeye gerek yoktur.

- Local veritabanı : dışarıya açık olmayan , verilerin cihaz hafızasında tutulduğu  , uygulamaya özel olan veritabandır.

- Bir SQLite veri tabanı oluşturmak için **SQLiteOpenHelper** soyut sınıfını miras alıp ihtiyacımıza uygun olarak özelleştiririz.

- Veritabanının adı bu sınıfın Constructor'ına verilir.

- onCreate() methodu sadece uygulama yüklenirken bir kere çalıştırılan methoddur. Bu nedenle ihtiacımız olan tabloları bu method içerisinde oluştururuz.

- Tablo oluşturma, tabloya eleman ekleme ,silme,güncelleme... işlemleri için **SQLiteDatabase** nesnesi kullanılır.

- **ContentValues** nesnesi, veritabanına eleman ekleme,güncelleme için gerekli veri formatıdır.

- **Cursor nesnesi**, sorguya göre veritabanından çekilen kayıtları tutmak için kullanılır.