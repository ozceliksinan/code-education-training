package androidjava.sinanozcelik.basiccalculator;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    // Aşağıdaki iki özellik bir değişkendir, design kısmındaki tanımlanan işlevler ise layoutddaki
    // bir id'dir. Bir bağlantıları yokdur. (isimleri aynı olsa bile)
    Button button0, button1, button2, button3, button4, button5, button6,
            button7, button8, button9, buttonToplama, buttonCikarma, buttonBolme,
            buttonCarpma, buttonNokta, buttonSifirla, buttonEsittir;
    EditText editTextNumber;

    // 2 tane float sayı tanımlayalım.
    float number1, number2;

    // Dört işlem buttonlarına tıklanıldıktan sonra eşittire basıldığında hangi buttona tıklanıldığı
    // bilgisini boolean ifadeler ile true-false şeklinde tutalım.
    boolean toplama, cikarma, carpma, bolme;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Layouttaki değişken ile burdaki yerel değişken bir birine bağlandı (ilişkilendirildi)
        /**************************************************/
        /*                      BUTTON                    */
        /**************************************************/
        button0 = (Button) findViewById(R.id.button0);
        button1 = (Button) findViewById(R.id.button1);
        button2 = (Button) findViewById(R.id.button2);
        button3 = (Button) findViewById(R.id.button3);
        button4 = (Button) findViewById(R.id.button4);
        button5 = (Button) findViewById(R.id.button5);
        button6 = (Button) findViewById(R.id.button6);
        button7 = (Button) findViewById(R.id.button7);
        button8 = (Button) findViewById(R.id.button8);
        button9 = (Button) findViewById(R.id.button9);
        buttonToplama = (Button) findViewById(R.id.buttonToplama);
        buttonCikarma = (Button) findViewById(R.id.buttonCikarma);
        buttonCarpma = (Button) findViewById(R.id.buttonCarpma);
        buttonBolme = (Button) findViewById(R.id.buttonBolme);
        buttonNokta = (Button) findViewById(R.id.buttonNokta);
        buttonEsittir = (Button) findViewById(R.id.buttonEsittir);
        buttonSifirla = (Button) findViewById(R.id.buttonSifirla);
        /**************************************************/
        /*                    EDIT TEXT                   */
        /**************************************************/
        editTextNumber = (EditText) findViewById(R.id.editTextNumber);

        button1.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "1");
            }
        });

        button2.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "2");
            }
        });

        button3.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "3");
            }
        });

        button4.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "4");
            }
        });

        button5.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "5");
            }
        });

        button6.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "6");
            }
        });

        button7.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "7");
            }
        });

        button8.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "8");
            }
        });

        button9.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "9");
            }
        });

        button0.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText(editTextNumber.getText() + "0");
            }
        });

        buttonNokta.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                if (editTextNumber == null)
                {
                    editTextNumber.setText(editTextNumber.getText() + "0.");
                }
                else
                {
                    editTextNumber.setText(editTextNumber.getText() +".");
                }
            }
        });

        buttonToplama.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                number1 = Float.parseFloat(editTextNumber.getText() + "");
                toplama = true;
                // Buttona tıklandıktan sonra edittext'i sıfırlayalım.
                editTextNumber.setText(null);
            }
        });

        buttonCikarma.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                number1 = Float.parseFloat(editTextNumber.getText() + "");
                cikarma = true;
                // Buttona tıklandıktan sonra edittext'i sıfırlayalım.
                editTextNumber.setText(null);
            }
        });

        buttonCarpma.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                number1 = Float.parseFloat(editTextNumber.getText() + "");
                carpma = true;
                // Buttona tıklandıktan sonra edittext'i sıfırlayalım.
                editTextNumber.setText(null);
            }
        });

        buttonBolme.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                number1 = Float.parseFloat(editTextNumber.getText() + "");
                bolme = true;
                // Buttona tıklandıktan sonra edittext'i sıfırlayalım.
                editTextNumber.setText(null);
            }
        });

        buttonEsittir.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                number2 = Float.parseFloat(editTextNumber.getText() + "");

                if (toplama == true)
                {
                    editTextNumber.setText(number1 + number2 + "");
                    toplama = false;
                }

                if (cikarma == true)
                {
                    editTextNumber.setText(number1 - number2 + "");
                    cikarma = false;
                }

                if (carpma == true)
                {
                    editTextNumber.setText(number1 * number2 + "");
                    carpma = false;
                }

                if (bolme == true)
                {
                    editTextNumber.setText(number1 / number2 + "");
                    bolme = false;
                }
            }
        });

        buttonSifirla.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v) {
                editTextNumber.setText("");
            }
        });
    }
}