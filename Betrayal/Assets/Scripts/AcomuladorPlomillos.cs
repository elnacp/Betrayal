using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcomuladorPlomillos : MonoBehaviour {

    public int acomulador = 0;
    public GameObject alex;
    public GameObject plomilloAmarillo;
    

    public void acomulaPlomi()
    {
        acomulador++;
        //En el caso de que el acomulador de fusibles sea 4 (FINAL DE LA PRUEBA)
        if ( acomulador == 3)
        {
            
            if(variablesGlobals.lang.Equals("español"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(37);
            }
            if (variablesGlobals.lang.Equals("english"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(51);
            }
            plomilloAmarillo.SetActive(true);
        }

        //En el caso de que el acomulador de fusibles sea 4 (FINAL DE LA PRUEBA)
        if( acomulador == 4)
        {
            if (variablesGlobals.lang.Equals("español"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(38);
            }
            if (variablesGlobals.lang.Equals("english"))
            {
                alex.GetComponent<AudioAlex>().ActivateAudio(52);
            }




        }
    }


}
