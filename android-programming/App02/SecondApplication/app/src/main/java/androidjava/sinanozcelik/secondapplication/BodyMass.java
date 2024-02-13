package androidjava.sinanozcelik.secondapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class BodyMass extends AppCompatActivity {

    // Burada tanımlanan view değişkenleri ile layouttaki view elemanları ile bir bağlantı yoktur.
    // İsimlendirmeleri aynı olsa bile bir birlerini tanımazlar.
    // Değer (Veri) set etmediğimiz sürece ilişkilendirmeye veya değişken tanımlamaya gerek yoktur.
    // Görsel amaçlı ve açıklayıcı amaçlı view elemanlarımız kalsın.

    // Aşağıda değişkenleri tanımladık ama layout ile bir bağlantıları yoktur.
    Button btnComputeMass;
    EditText etWeight,etHeight;
    TextView tvMassResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bodymass);

        // Yukarıda tanımlanan değişkenlerimnizi layout'taki view elemanlarımız ile ilişkilendirelim.
        btnComputeMass=findViewById(R.id.btn_ComputeMass);
        etHeight=findViewById(R.id.et_Height);
        etWeight=findViewById(R.id.et_Weight);
        tvMassResult=findViewById(R.id.tv_MassResult);

        // setOnClickListener -> İlgili button'a tıklanıldığında, ve onu dinleyen bir listener (interface)
        // tanımlamış olduk. Abstract class olarak görev alırlar. İçeriğini biz kendimiz doldururuz.
        // Metot içerisinde class tanımlama imkanı sunar bize android programlama.
        // Bu metot çağrıldığı zaman içini doldurmamız gereklidir.

        btnComputeMass.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Basit bir vücud kitle indeksini hesaplayalım. (Değerler yaklaşıktır gerçek değildir)
                // View'deki veriler string tipindedir.
                // Double.parseDouble -> yazıldığı zaman double veri tipine çevirme işlemini gerçekleştirmiş olduk.
                double height=Double.parseDouble(etHeight.getText().toString()); // Boy bilgisini view'dan aldık
                double weight=Double.parseDouble(etWeight.getText().toString()); // Kilo bilgisini view'dan aldık
                double massIndex=weight/Math.pow(height,2);
                if (massIndex>25)
                    tvMassResult.setText("Obez"); // Hesaplanan değerdeki sonucu ekranımıza yazalım.
                else
                    tvMassResult.setText(String.valueOf(massIndex));
            }
        });
    }
}