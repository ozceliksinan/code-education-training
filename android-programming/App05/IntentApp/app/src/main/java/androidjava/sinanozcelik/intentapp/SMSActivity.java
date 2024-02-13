package androidjava.sinanozcelik.intentapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class SMSActivity extends AppCompatActivity {
    // Nesne değişkenlerimizi oluşturalım.
    Button btnSendSMS;
    EditText etSMSText, etPhoneNumber;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sms);

        // Değişken olarak oluşturduğumuz nesnelerimizi bir birleri ile ilişkilendirelim.
        btnSendSMS=findViewById(R.id.btn_SendSMS);
        etSMSText=findViewById(R.id.et_SMSText);
        etPhoneNumber=findViewById(R.id.et_PhoneNumber);

        // Button'a tıklanıldığında çalışacak olan fonksiyonumuzu yazalım.
        btnSendSMS.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Telefon numaramazı alıp değişkenimize atayalım
                String phoneNumber=etPhoneNumber.getText().toString();
                // Mesaj içeriğimizi alıp değişkene atayalım.
                String text=etSMSText.getText().toString();

                // Telefon numara kısmımız boş değilse sms göndersin. Bunu yazalım.
                if(!TextUtils.isEmpty(phoneNumber)){
                    // Intent.ACTION_SENDTO -> SMS servisine erişmek için bu metot kullanılır.
                    // SMS servisi açıldıktan sonra aldığımız verileri ilgili yerlere set etmemiz gereklidir.
                    Intent sms = new Intent(Intent.ACTION_SENDTO);
                    // Verilerimizi set edelim.
                    sms.setData(Uri.parse("smsto:"+phoneNumber)); // Telefon numarası alanı
                    sms.putExtra("sms_body",text); // Mesaj içeriği alanı
                    // Gerekli veriler set edildi. Intent yapımızı başlatalım.
                    startActivity(sms);
                }
                // Button'a tıklanıldığında sms göndermez. Sms servisi açılır ve ilgili yerlere girilen parametrelerdeki değerler
                // yazılır. Kullanıcının telefonunda açılan sms uygulamasına bilgiler girildi ve kullanıcı gönder button'una basmadığı
                // sürece uygulamamız sms göndermez.
            }
        });
    }
}