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
        if( acomulador == 3)
        {
            //se activa el audio 51/ - 37
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
