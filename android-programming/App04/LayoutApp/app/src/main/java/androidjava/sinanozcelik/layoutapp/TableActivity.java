package androidjava.sinanozcelik.layoutapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class TableActivity extends AppCompatActivity {

    // android:layout_span="2" -> Yazıldığında 2 katı yer kaplasın anlamına gelir.

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_table);
    }
}
