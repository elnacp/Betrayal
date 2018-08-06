using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opcionFinal : MonoBehaviour {

    public GameObject jane;
    public GameObject brooke;
    public bool isClick;


    public void opcionAbandonar()
    {
        Debug.Log("OPCION ABANDONAR");
        variablesGlobals.opcion = true;

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
        variablesGlobals.opcion = true;

        if(variablesGlobals.lang.Equals("español"))
        {
            jane.GetComponent<AudioJane>().ActivateAudio(5);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            jane.GetComponent<AudioJane>().ActivateAudio(12);
        }
        isClick = true;
    }



}
