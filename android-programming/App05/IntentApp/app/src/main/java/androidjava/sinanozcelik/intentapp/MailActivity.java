package androidjava.sinanozcelik.intentapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MailActivity extends AppCompatActivity {
    // XML design kısmında oluşturduğumuz view nesnelerimizi değişken olarak burada tutalım.
    Button btnSendMail;
    EditText etMailAddress,etSubject,etMailText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mail);

        // Değişkenlerimiz ile ilişkilendirilmesini yapalım.
        btnSendMail=findViewById(R.id.btn_SendMail);
        etMailText=findViewById(R.id.et_MailText);
        etSubject=findViewById(R.id.et_Subject);
        etMailAddress=findViewById(R.id.et_Mail);

        // Button'a tıklanıldığında çalışacak olan fonksiyonumuzu yazalım.
        btnSendMail.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String mailAddress=etMailAddress.getText().toString();
                String subject=etSubject.getText().toString();
                String mailText=etMailText.getText().toString();

                // Mail gönderirken -> ACTION_SEND hazır metodu eklenir.
                Intent mail = new Intent(Intent.ACTION_SEND);
                // Gönderdiğimiz mailin e-mail olduğunu belirtmek için setType kullanırız.
                mail.setType("message/rfc822");
                // Mail içeriğimizi EXTRA_TEXT hazır metodu ile mail uygulamamıza göndeririz.
                mail.putExtra(Intent.EXTRA_TEXT,mailText);
                // Kullanıcı birden fazla kişiye mail gönderebilir. Kullanıcı ',' aracılığı ile birden fazla
                // kişiye mail gönderdiği varsayılarak, buradaki mailAddress değişkenimizi string dizisi olarak
                // almamız en mantıklı seçenek olacaktır.
                mail.putExtra(Intent.EXTRA_EMAIL,new String[]{mailAddress});
                // Mail içeriğinin konu kısmını dolduralım.
                mail.putExtra(Intent.EXTRA_SUBJECT,subject);
                // Intent yapımızı oluşturalım.
                startActivity(mail);
            }
            // Uygulama email göndermiyor, email bilgilerini doldurur ve kullanıcının telefonundaki default mail uygulamasını
            // açar ve bilgileri doldurur. Göndermek yine kullancıya kalmıştır. İzin alınmadan veri gönderimi yapılamaz.
        });
    }
}