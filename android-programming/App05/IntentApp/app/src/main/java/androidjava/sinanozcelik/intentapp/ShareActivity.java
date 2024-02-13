package androidjava.sinanozcelik.intentapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class ShareActivity extends AppCompatActivity {
    EditText etShare;
    Button btnShareText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_share);

        // Eşleştirmeler yapıldı. (Değişkenler ile)
        etShare=findViewById(R.id.et_Share);
        btnShareText=findViewById(R.id.btn_ShareText);

        btnShareText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Paylaşılacak olan mesajımız, ilgili değişkene aktarıldı.
                String text=etShare.getText().toString();
                // ACTION_SEND -> Paylaşma intent yapımız bu şekildedir.
                Intent share=new Intent(Intent.ACTION_SEND);
                // Paylaşacağımız mesajımızın text tipinde olacağını belirttik.
                share.setType("text/plain");
                // EXTRA_TEXT -> Text göndereceğimizi intent yapısına yerleştirmiş olduk ve gönderilmeye hazır durumdadır.
                // Button'a tıklanıldığında ilgili mesaj paylaşılacaktır.
                share.putExtra(Intent.EXTRA_TEXT,text);
                // createChooser -> Paylaş görünümü açılır. Pencere açılır. Pencere başlığı "Select platform" olur.
                // Paylaşılacak olan platformlar listelenir. Telefonda hangi sosyal medya uygulamaları varsa,
                // WhatsApp, Twitter, ... gibi sosyal medya uygulamaları listelenir ve birini seçmenizi bekler.
                // createChooser denilmez ise default olarak paylaşma uygulaması açılır. Örnek olarak email paylaşma
                // uygulamasında 5 tane email uygulaması olduğunu düşünelim. Burdaki default uygulama gmail ise
                // gmail uygulaması açılır. Ama createChooser metodu kullanılırsa bu uygulamalar arasında bize
                // seçenekleri gösterir ve paylaşılacak uygulamanın seçilmesi beklenir.
                startActivity(Intent.createChooser(share,"Select platform"));
            }
        });
    }
}