using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcomuladorPiezas : MonoBehaviour {

    private int acomulador = 13;  // el acomulador de piezas del puzle
    public GameObject alex;      // audio de alex
    public GameObject pieza10;   // pieza del puzle que falta
    public GameObject cuadro;

    

    public void aumentarAcomulador()
    {
        
        acomulador = acomulador + 1;
        
        if (acomulador == 23)
        {
            if (variablesGlobals.lang.Equals("español"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(41);
            }
            if (variablesGlobals.lang.Equals("english"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(57);
            }
            pieza10.SetActive(true);
        }

        if(acomulador == 24)
        {
            if (variablesGlobals.lang.Equals("español"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(42);
            }
            if (variablesGlobals.lang.Equals("english"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(58);
            }
            cuadro.SetActive(true);
            Destroy(pieza10);

        }

        

    }

    





}
