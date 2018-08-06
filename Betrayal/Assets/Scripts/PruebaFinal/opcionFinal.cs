using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opcionFinal : MonoBehaviour {

    public GameObject jane;
    public GameObject brooke;
    public GameObject alex;
    public bool isClick;

    public Light d1;
    public Light d2;
    public Light d3;
    public Light d4;

    public void opcionAbandonar()
    {
        Debug.Log("OPCION ABANDONAR");

        if (variablesGlobals.lang.Equals("español"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(32);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(78);
        }

        isClick = true;

        

    }

    public void opcionPerdonar()
    {
        Debug.Log("OPCION PERDONAR");
        
        if(variablesGlobals.lang.Equals("español"))
        {
            jane.GetComponent<AudioJane>().ActivateAudio(5);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            jane.GetComponent<AudioJane>().ActivateAudio(12);
        }
        isClick = true;
        d1.color = Color.red;
        d2.color = Color.red;
        d3.color = Color.red;
        d4.color = Color.red;
    }


    


}
