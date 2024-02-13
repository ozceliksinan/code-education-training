package androidjava.sinanozcelik.secondapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    // Design kısmında button'ların metotları tanımlandığı için burda ayrı bir değişken oluşturup,
    // layout ile bağlantı yapmaya gerek yoktur.

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void ButtonClick(View v){
        // id'ler int tipinde olduğu için, hangi button'a tıklanıldıysa ilgili id yakalanır ve değişkene
        // aktarılır.
        int id = v.getId();
        Intent intent; // Activity'ler arası geçiş yapmak için intent yapısını kullanıyoruz.
        switch (id){
            case R.id.btn_Calc:
                intent=new Intent(MainActivity.this,Calculator.class);
                startActivity(intent);
                break;
            case R.id.btn_Mass:
                intent=new Intent(MainActivity.this,BodyMass.class);
                startActivity(intent);
                break;
            case R.id.btn_Age:
                intent=new Intent(MainActivity.this,AgeActivity.class);
                startActivity(intent);
                break;
        }
    }
}