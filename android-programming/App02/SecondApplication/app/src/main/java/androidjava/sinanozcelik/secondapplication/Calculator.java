package androidjava.sinanozcelik.secondapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

// onClickListener bizden interface bekler, ama biz bu uygulamamızda class yapısı olarak gönderdik.
// Interface yapılardan implements edilir.
// Super Class'lardan ise extends ile kalıtım yapılır.
// implements View.OnClickListener -> Calculator class'ımız artık onClickListener'ı implements ediyor.
// Yani direkt onClickListener interface'ini çağırmış oluyoruz. Bunun çalışması için onClickListener
// metodu override edilmesi lazımdır. Yani kısaca 4 buttonumuz var bu uygulamada. Her button için ayrı ayrı
// metot tanımlamak yerine tek bir metodu override  ederek işlemlerimizi daha rahat bir şekilde gerçekleştirmiş
// oluyoruz.


public class Calculator extends AppCompatActivity implements View.OnClickListener {

    // Burada tanımlanan view değişkenleri ile layouttaki view elemanları ile bir bağlantı yoktur.
    // İsimlendirmeleri aynı olsa bile bir birlerini tanımazlar.
    // Değer (Veri) set etmediğimiz sürece ilişkilendirmeye veya değişken tanımlamaya gerek yoktur.
    // Görsel amaçlı ve açıklayıcı amaçlı view elemanlarımız kalsın.

    // Aşağıda değişkenleri tanımladık ama layout ile bir bağlantıları yoktur.
    EditText etNumber1,etNumber2;
    TextView tvResult;
    Button btnAdd,btnSubtract,btnMultiply,btnDivision;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculator);

        // İlişkilendirme işlemlerini gerçekleştirdik. (Layout'taki ilgili yerlere)
        etNumber1=findViewById(R.id.et_Number1);
        etNumber2=findViewById(R.id.et_Number2);
        tvResult=findViewById(R.id.tv_Result);
        btnDivision=findViewById(R.id.btn_Division);
        btnMultiply=findViewById(R.id.btn_Multiply);
        btnSubtract=findViewById(R.id.btn_Subtract);
        btnAdd=findViewById(R.id.btn_Add);

        // this -> Class yapısının kendisi demektir.
        btnAdd.setOnClickListener(this);
        btnSubtract.setOnClickListener(this);
        btnMultiply.setOnClickListener(this);
        btnDivision.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        // Button'larımızın ID yapılarına göre yapacakları işlemleri belirtelim.
        int id=view.getId();
        // Programımızdaki text alanlarından girilen verileri (şuan string tipinde),
        // double veri tipine dönüştürme işlemini gerçekleştirelim.
        double number1=Double.parseDouble(etNumber1.getText().toString());
        double number2=Double.parseDouble(etNumber2.getText().toString());
        // Sonuç değişkenimizi oluşturalım ve daha sonrasında çıkan işlem sonuçlarını bu değişkenimize aktaralım.
        double result=0.0;
        switch (id){
            case R.id.btn_Add:result=number1+number2; break;
            case R.id.btn_Subtract: result=number1-number2;break;
            case R.id.btn_Multiply: result=number1*number2;break;
            case R.id.btn_Division: result=number1/number2;
        }
        // Çıkan sonucumuzu ekranda yazdıralım. (Verimizi set edelim)
        tvResult.setText("Sonuc="+result);
    }
}