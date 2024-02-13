package androidjava.sinanozcelik.layoutapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class GridActivity extends AppCompatActivity {

    /*
        Grid: Matrisli yapıdır. Matristeki her bir eleman bir birinden bağımsız elemanlar olacaktır.
        3 Satır 2 Sütundan oluşacağını belirttik.
        android:columnCount="2"
        android:rowCount="3"
    */

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_grid);
    }
}
