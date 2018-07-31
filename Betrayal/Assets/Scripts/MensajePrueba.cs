using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MensajePrueba : MonoBehaviour {
    public Text prueba;
    public Text mision;

    void Start()
    {
        //Text sets your text to say this message
        
    }


    public void BuidarText()
    {
        prueba.text = "";
        mision.text = "";
    }

    public void TitleTest(int test, string idioma)
    {
        
        switch (idioma)
        {
            case "español"://IDIOMA = ESPAÑOL
                switch (test)
                {
                    case 1:
                        
                        prueba.text = "1ra Prueba: Libera a Brooke";
                        mision.text = "Encuentra la llave";
                        break;
                    case 2:

                        prueba.text = "2a Prueba: ";
                        mision.text = "¿Dónde esta la luz?";
                        break;
                }
                
                break;
            case "english": //IDIOMA = ENGLISH
                switch (test)
                {
                    case 1:
                        prueba.text = "1st Test: Liberate Brooke";
                        mision.text = "Find the key";
                        break;
                    case 2:

                        prueba.text = "2nd Test:";
                        mision.text = "Where is the light?";
                        break;
                }
                break;
        }
    }

    IEnumerator Wait(int time)
    {
        yield return new WaitForSeconds(time);
    }

}

