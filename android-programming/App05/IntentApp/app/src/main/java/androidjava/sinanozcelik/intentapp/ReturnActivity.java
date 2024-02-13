package androidjava.sinanozcelik.intentapp;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class ReturnActivity extends AppCompatActivity {
    EditText etReturn;
    Button btnReturnText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_return);

        etReturn=findViewById(R.id.et_Return);
        btnReturnText=findViewById(R.id.btn_ReturnText);

        btnReturnText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Text alanına girilen mesaj, değişkenimizde tutuluyor.
                String name=etReturn.getText().toString();
                // Intent yapımızı oluşturalım.
                Intent returnIntent=new Intent();
                // Geriye gönderilecek olan mesaj değerimiz.
                returnIntent.putExtra("NAME",name);
                // setResult -> RESULT_OK -> Result sonucumuzu OK olarak göndeririz. Yani başarılı bir şekilde
                // geriye gönderildi paketi ile gönderilir ve RAM yapımızdan çıkarılır. (Bellek esnekliği sağlar)
                setResult(Activity.RESULT_OK,returnIntent);
                finish();
            }
        });
    }
}