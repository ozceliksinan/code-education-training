package androidjava.sinanozcelik.useroperationsapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class WelcomeActivity extends AppCompatActivity {
    TextView tvName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);
        tvName=findViewById(R.id.tv_Name);
        String userName=getIntent().getStringExtra("USERNAME");
        tvName.setText("Welcome "+ userName);
    }
}