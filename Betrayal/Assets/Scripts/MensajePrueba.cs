using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MensajePrueba : MonoBehaviour {
    public Text prueba;
    public Text mision;
    public GameObject pop;
    
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
        if (!variablesGlobals.finalPartida)
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
                            mision.text = "¿Cómo se abre la luz?";
                            break;
                        case 3:
                            prueba.text = "3a Prueba: Caja Fuerte";
                            mision.text = "Introduce la combinación";
                            break;
                        case 4:
                            prueba.text = "4a Prueba: Desactivar Bomba";
                            mision.text = "";
                            break;
                        case 41:
                            prueba.text = "4a Prueba: Desactivar Bomba";
                            mision.text = "¿Dónde esta la figura?";
                            break;
                        case 42:
                            prueba.text = "4a Prueba: Desactivar Bomba";
                            mision.text = "¿Cables?";
                            break;
                        case 43:
                            prueba.text = "4a Prueba: Desactivar Bomba";
                            mision.text = "¿Dónde están las tenazas?";
                            break;
                        case 5:
                            prueba.text = "5a Prueba: ";
                            mision.text = "Milk puzle";
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
                            mision.text = "How does the light open?";
                            break;
                        case 3:
                            prueba.text = "3rd Test: Safe";
                            mision.text = "Enter the combination";
                            break;
                        case 4:
                            prueba.text = "4th Test: Deactivate Bomb";
                            mision.text = "";
                            break;
                        case 41:
                            prueba.text = "4th Test: Deactivate Bomb";
                            mision.text = "Where is the figure?";
                            break;
                        case 42:
                            prueba.text = "4th Test: Deactivate Bomb";
                            mision.text = "Cables?";
                            break;
                        case 43:
                            prueba.text = "4th Test: Deactivate Bomb";
                            mision.text = "Where are the pincers?";
                            break;
                        case 5:
                            prueba.text = "5th Test: ";
                            mision.text = "Milk puzle";
                            break;
                    }
                    break;
            }

            pop.GetComponent<AudioPop>().PopAudio();
        }
        



    }

    IEnumerator Wait(int time)
    {
        yield return new WaitForSeconds(time);
    }

}

