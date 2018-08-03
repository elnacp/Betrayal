using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcomuladorPiezas : MonoBehaviour {

    private int acomulador = 7;  // el acomulador de piezas del puzle
    public GameObject alex;      // audio de alex
    public GameObject pieza10;   // pieza del puzle que falta


    

    public void aumentarAcomulador()
    {
        
        acomulador++;
        Debug.Log(acomulador);
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
            Debug.Log("HELLO");
            //se cambia el puzle por una imagen
        }



    }

    





}
