package androidjava.sinanozcelik.useroperationsapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    // Nesnelerimizi tanımlayalım.
    TextView tvNewUser;
    EditText etLoginUN,etLoginPass;
    Button btnLogin,btn_AllUsers;
    SQLiteHelper database;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        // Tanımlanan nesnelerimizi view alanındaki id'ler ile eşleştirelim.
        tvNewUser=findViewById(R.id.tv_NewUSer);
        etLoginUN=findViewById(R.id.et_LoginUN);
        etLoginPass=findViewById(R.id.et_LoginPass);
        btnLogin=findViewById(R.id.btn_Login);
        btn_AllUsers=findViewById(R.id.btn_AllUsers);

        // Tüm kullanıcıları görüntüle butonu'na basıldığında çalışacak olan fonksiyonumuzu yazalım.
        btn_AllUsers.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i=new Intent(MainActivity.this,UserListActivity.class);
                startActivity(i);
            }
        });

        // Kullanıcı girişi yapılacak olan fonksiyonumuzu tanımlayalım.
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Kullanıcı adı ve şifre bilgileri alındı.
                String userName=etLoginUN.getText().toString();
                String password=etLoginPass.getText().toString();

                //
                database = new SQLiteHelper(MainActivity.this);
                String realPassword=database.findUser(userName);
                if(realPassword.equals(password)){
                    Intent i=new Intent(MainActivity.this,WelcomeActivity.class);
                    i.putExtra("USERNAME",userName);
                    startActivity(i);
                }
            }
        });

        // Yeni kullanıcı oluşturmak istenildiğinde çalışacak olan fonksiyonumuzu yazalım.
        tvNewUser.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(MainActivity.this,RegisterActivity.class);
                startActivity(i);
            }
        });
    }
}