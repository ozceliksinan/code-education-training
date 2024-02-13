package androidjava.sinanozcelik.secondapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.util.Calendar;

public class AgeActivity extends AppCompatActivity {

    // Burada tanımlanan view değişkenleri ile layouttaki view elemanları ile bir bağlantı yoktur.
    // İsimlendirmeleri aynı olsa bile bir birlerini tanımazlar.
    // Değer (Veri) set etmediğimiz sürece ilişkilendirmeye veya değişken tanımlamaya gerek yoktur.
    // Görsel amaçlı ve açıklayıcı amaçlı view elemanlarımız kalsın.

    // Aşağıda değişkenleri tanımladık ama layout ile bir bağlantıları yoktur.
    Button btnComputeAge;
    EditText etBirthYear;
    TextView tvAge;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_age);

        // İlişkilendirme işlemini gerçekleştirelim.
        btnComputeAge=findViewById(R.id. btn_ComputeAge);
        etBirthYear=findViewById(R.id.et_BirthYear);
        tvAge=findViewById(R.id.tv_Age);

        // button'a tıklanıldığına çalışacak olan kodlarımızı yazalım.
        btnComputeAge.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                tvAge.setText(""); // Text alanımızı fonksiyon çalıştırıldığı anda initialize(sıfırlama) işlemini yapalım.
                String birthYear = etBirthYear.getText().toString(); // View alanımıza girilen verimizi değişkenimize kaydedelim.
                // Kullanıcı tarih girdi mi, girmedi mi kontrolunu sağlayalım.
                if(!TextUtils.isEmpty(birthYear)){
                    int currentYear= Calendar.getInstance().get(Calendar.YEAR); // Şimdiki yılın bilgisini alalım.
                    // Şimdiki yılıb bilgisini almamızın sebebi kullanıcı 2021 girerse hata mesajı göndermek içindir.
                    int year=Integer.parseInt(birthYear); // Yukarda string ile tuttuğumuz veriyi int veri tipine çevirelim.
                    if(year<currentYear) { // Kontrol sağlandı
                        int age = currentYear - year; // Hesaplama işlemini yapalım.
                        tvAge.setText("You are " + age + " years old.");
                    }else{
                        // Hata mesajı yayınladık.
                        // Toast mesajı ise telefonun alt bölümünde kutucuk şeklinde mesaj göstermek için kullanılabilir.
                        Toast.makeText(getApplicationContext(),"You should enter a previous date",Toast.LENGTH_SHORT).show();
                    }
                }else{
                    // Toast mesajı ise telefonun alt bölümünde kutucuk şeklinde mesaj göstermek için kullanılabilir.
                    Toast.makeText(getApplicationContext(),"You did not enter a birth year",Toast.LENGTH_SHORT).show();
                }

            }
        });

    }
}