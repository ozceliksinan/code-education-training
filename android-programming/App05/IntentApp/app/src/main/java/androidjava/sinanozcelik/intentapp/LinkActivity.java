package androidjava.sinanozcelik.intentapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class LinkActivity extends AppCompatActivity {
    // Değişkenimizi tanımlayalım.
    TextView tvLink;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_link);

        // İlişkilendirme yapıldı.
        tvLink=findViewById(R.id.tv_Link);

        // ButtonLinke tıklanıldığında çalışacak olan fonksiyonumuzu yazalım.
        tvLink.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // ACTION_VIEW -> Link açma metodudur.
                Intent link = new Intent(Intent.ACTION_VIEW);
                // Açılacak olan adres bilgilerimizi girelim.
                link.setData(Uri.parse("https://sinanozcelik.com"));
                // Intent yapımızı başlatalım.
                startActivity(link);
            }
        });
    }
}