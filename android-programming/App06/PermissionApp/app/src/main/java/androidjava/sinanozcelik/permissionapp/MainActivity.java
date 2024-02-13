package androidjava.sinanozcelik.permissionapp;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.Manifest;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;

// Uygulamanın çalışması için AndroidManifest.xml dosyamıza gerekli izin bilgileri girilmelidir.
// <uses-permission android:name="android.permission.CALL_PHONE"></uses-permission>

public class MainActivity extends AppCompatActivity {
    // Değişkenlerimiz oluşturuldu.
    EditText etPhone;
    ImageButton ibCall;

    // Global değişken olarak tanımladık. Diğer fonksiyonların içinde kullanabilmek için.
    String phoneNumber;

    // İstenilen sayı verilebilir. Uygulamanın izni var mı yok mu.
    final static int CALL_REQUEST_CODE=100;

    // NOT: Kullanıcının verdiği cevabı ayrı bir mettota alacağız

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // İlişkilendirme işlemini yapalım. Layout ile buttonlarımız ve ilgili yerler ilişkiliendirldi.
        etPhone=findViewById(R.id.et_Phone);
        ibCall=findViewById(R.id.ib_Call);

        // Arama button'una tıklanıldığında çalışacak olan metodumuzu yazalım.
        ibCall.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Telefon numarasını değişkenimize kayıt edelim.
                phoneNumber=etPhone.getText().toString();
                // Kullanıcı numara girdi mi girmedi mi diye kontrol edelim.
                if(!TextUtils.isEmpty(phoneNumber)){
                    // İzin alındı ve call fonksiyonu çağrılır ve arama gerçekleştirilir.
                    Call();
                }else{
                    // Kullanıcı telefon numarası girmediyse, Toast mesajı ile bilgilendirme yapalım.
                    Toast.makeText(getApplicationContext(),"Enter a phone number",Toast.LENGTH_SHORT).show();
                }
            }
        });
    }

    private void Call() {
        // İlk parametre: Context -> yani kendi classımız.
        // İkinci parametre: Ne izni istediğimiz. CALL_PHONE var mı diye bakarız. PacakgeManager içinden kontrol ederiz.
        // Daha önceden izin verilmiş mi diye sorgular.
        if(ActivityCompat.checkSelfPermission(this, Manifest.permission.CALL_PHONE)== PackageManager.PERMISSION_GRANTED){
            Intent call=new Intent(Intent.ACTION_CALL);
            call.setData(Uri.parse("tel:"+phoneNumber));
            startActivity(call);
        }

        // İzin verilmemişse eğer else çalışır.
        else{
            // Kullanıcının kafası karışmasın diye bu if bloğunu ekleyelim.
            // shouldShowRequestPermissionRationale-> bu izin ile ilgili kullanıcının kafası karışık mı?
            // Alert ile dialog ekleyelim.
            if(ActivityCompat.shouldShowRequestPermissionRationale(this,Manifest.permission.CALL_PHONE)){
                // builder oluşturduk.
                // Gerekli açıklamalar yapılır. Neden izin istenildiğine dair.
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.setTitle("Info");
                builder.setMessage("This application needs CALL permision to call someone");

                // Close basıldığında biz burda basitçe kapattık. Başka şeyler de yapılabilir.
                // Olaylara göre.
                // Intentler açılır veya bu tarz değişik şeyler yapılabilir.
                builder.setPositiveButton("Close", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        dialog.dismiss();
                    }
                });
                builder.show();
            }
            // String dizi tanımlanabilir. Birden fazla izin istenilebilir.
            ActivityCompat.requestPermissions(this,new String[]{Manifest.permission.CALL_PHONE},CALL_REQUEST_CODE);
            // Kullanıcıya pencere açar ve cevabı onRequestPermissionsResult fonksiyonuna düşer.
        }
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        // grantResults-> Kullanıcının verdiği cevap bu parametrede
        // Kullanıcı sms'e izin verip aramaya izin vermeyebilir. Bu gibi durumlar için erişim izin isteği dizilerde tutulur.

        // Request kodlarına bakarak birden fazla izni bir birinden ayırırırz.
        // Aynı buttonlardaki onclick metodu gibi.
        // Buttonlarda id ile ayırıyorsak bu mettota da REQUEST_CODE'lara en başta tanımlanan numeric değerlere göre bakılır.
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        if(requestCode==CALL_REQUEST_CODE){
            // Burda ve veya gibi bağlaçları kullanarak birden fazla izin kontrol edilebilir.
            if(grantResults[0]==PackageManager.PERMISSION_GRANTED){
                // Tek izin istediğimiz için 0. indis yani 1.eleman call izni çekilir.
                // Kullanıcı arama izni verildiyse call metodu ile çağrılır ve işlerimize devam ederiz. İZİN VARDIR
                Call();
            }
            else{
                // İzin verilmedi ve kullanıcıya izin verilmedi ya da işlem başarız gibi mesajlar yazılabilir.
                Toast.makeText(getApplicationContext(),"You denied the call permission",Toast.LENGTH_SHORT).show();
            }
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.option_menu,menu);
        return true;
    }

    // res klasörü altına menu klasörü oluşturalım ve içine option_menu.xml dosyasını oluşturalım.
    // daha sonra oluşturmuş olduğumuz xml dosya yapımızı dolduralım.

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.item_camera:
                Toast.makeText(getApplicationContext(),"Camera is selected",Toast.LENGTH_SHORT).show();
                break;
            case R.id.item_share:
                Toast.makeText(getApplicationContext(),"Share is selected",Toast.LENGTH_SHORT).show();
                break;
            case R.id.item_exit:
                System.exit(0);
        }
        return super.onOptionsItemSelected(item);
    }
}