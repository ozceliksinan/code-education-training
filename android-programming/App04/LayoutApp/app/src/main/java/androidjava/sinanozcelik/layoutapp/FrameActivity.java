package androidjava.sinanozcelik.layoutapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class FrameActivity extends AppCompatActivity {
    Button btnVisible;
    ImageView iv1,iv2;

    // FrameLayout ekran üzerinde 9 çerçeveye bölünmüştür.
    /*
        android:visibility="invisible" <!-- Şuan Görünmez modda -->
        android:layout_gravity="top|center" <!-- 9 bölümlü kısımdan nerde görüleceğini söyledik (Tam orta) -->
    */

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_frame);
        btnVisible=findViewById(R.id.btn_Visible);
        iv1=findViewById(R.id.iv_1);
        iv2=findViewById(R.id.iv_2);
        btnVisible.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Görünür görünmez ayarı yapıldı.
                iv1.setVisibility(View.VISIBLE);
                iv2.setVisibility(View.INVISIBLE);
            }
        });
    }
}
