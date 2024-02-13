package androidjava.sinanozcelik.layoutapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class LinearActivity extends AppCompatActivity {
    Button btnLogin;
    EditText etUserName,etPassword;
    String trueUN="includeprogram";
    String truePass="includeprogram";

    // İlk layout -> Linear Layout
    // Linear Layout (Horizontal (Yatay)) -> Üst üste ekler ve yatay şekilde sıralamaya, sığdırmaya
    // çalışır. orientation default olarak horizontaldır. Vertical yapılırsa dikey bir şekilde sıralamaya yarar.
    // Ya dikey ya da yatay şekilde sıralama yapar.
    // Kullanışlı değildir ama kimi zaman kullanıldığı yerler de mevcuttur.

    // Manifest dosyası içerisindeki intet-filter komutları hangi activity içerisindeyse, o activite
    // program derlenip çalıştırıldığında çalışacak olan activity dosyasıdır.

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_linear);
        etPassword=findViewById(R.id.et_Password);
        etUserName=findViewById(R.id.et_UserName);
        btnLogin=findViewById(R.id.btn_Login);
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String userName = etUserName.getText().toString();
                String password = etPassword.getText().toString();
                if (userName.equals(trueUN) && password.equals(truePass)) {
                    // İşlem başarılı olunca bildirim kutucuğu ile bilgilendirsin. (En altta)
                    Toast.makeText(getApplicationContext(), "You have logined", Toast.LENGTH_SHORT).show();
                }
                else{
                    // İşlem başarısız ise bildirim kutucuğu ile bilgilendirsin. (En altta)
                    Toast.makeText(getApplicationContext(), "Username or password is wrong", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}
