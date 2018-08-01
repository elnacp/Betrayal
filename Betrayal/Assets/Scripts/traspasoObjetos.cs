using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traspasoObjetos : MonoBehaviour {

    public GameObject brooke;
    public GameObject key;

    
   


    private void OnTriggerEnter(Collider other)
    {

        
        switch (other.name)
        {
            case "Llave":
                if (variablesGlobals.lang.Equals("español"))
                {
                    brooke.GetComponent<AudioBrooke>().ActivateAudio(18);
                }
                if (variablesGlobals.lang.Equals("english"))
                {
                    brooke.GetComponent<AudioBrooke>().ActivateAudio(65);
                }
                variablesGlobals.prova1 = true;
                break;
            case "ConoRojo":
                if (variablesGlobals.prova41)
                {
                    if (variablesGlobals.lang.Equals("español"))
                    {
                        brooke.GetComponent<AudioBrooke>().ActivateAudio(28);
                    }
                    if (variablesGlobals.lang.Equals("english"))
                    {
                        brooke.GetComponent<AudioBrooke>().ActivateAudio(71);
                    }
                    variablesGlobals.prova41 = false;
                    variablesGlobals.prova42 = true;
                }
                break;
            default:
                if(variablesGlobals.prova41)
                {
                    if (variablesGlobals.lang.Equals("español"))
                    {
                        brooke.GetComponent<AudioBrooke>().ActivateAudio(27);
                    }
                    if (variablesGlobals.lang.Equals("english"))
                    {
                        brooke.GetComponent<AudioBrooke>().ActivateAudio(70);
                    }
                }


                break;
        }
        
      

    }
}
