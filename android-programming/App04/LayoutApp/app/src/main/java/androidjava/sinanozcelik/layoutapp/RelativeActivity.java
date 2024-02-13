package androidjava.sinanozcelik.layoutapp;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.RelativeLayout;

public class RelativeActivity extends AppCompatActivity {
    RelativeLayout relativeLayout;
    ImageView ivImage;

    // Button veya nesneler bir birlerine göre yerleştirilirler.
    // android:layout_alignParentStart="true" -> Sol tarafta gözükür.
    // android:layout_alignParentEnd="true" -> Sağ tarafta gözükür.

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_relative);
        relativeLayout=findViewById(R.id.relative);
        ivImage=findViewById(R.id.iv_Image);
    }
    public void ButtonClick(View v){
        int ID=v.getId();
        if(ID==R.id.btn_Color)
            relativeLayout.setBackgroundColor(Color.BLUE);
        else if(ID==R.id.btn_Image){
            // Resmi al ve image ekle.
            ivImage.setImageDrawable(getResources().getDrawable(R.drawable.ic_launcher_background));
        }
    }
}
