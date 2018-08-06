using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traspasoObjetos : MonoBehaviour {

    public GameObject brooke;
    public GameObject key;
    public GameObject cono;
    public GameObject alicates;

    
   


    void OnTriggerEnter(Collider other)
    {
        if(!variablesGlobals.finalPartida)
        {
            switch (other.name)
            {
                case "Llave":
                    if (variablesGlobals.prova1 == true)
                    {
                        if (variablesGlobals.lang.Equals("español"))
                        {
                            brooke.GetComponent<AudioBrooke>().ActivateAudio(18);
                        }
                        if (variablesGlobals.lang.Equals("english"))
                        {
                            brooke.GetComponent<AudioBrooke>().ActivateAudio(65);
                        }
                        variablesGlobals.prova1 = true;
                    }

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
                        Destroy(cono);
                    }
                    break;
                case "Alicates":
                    if (variablesGlobals.prova43)
                    {
                        if (variablesGlobals.lang.Equals("español"))
                        {
                            brooke.GetComponent<AudioBrooke>().ActivateAudio(31);
                        }
                        if (variablesGlobals.lang.Equals("english"))
                        {
                            brooke.GetComponent<AudioBrooke>().ActivateAudio(74);
                        }
                        variablesGlobals.prova43 = false;
                        variablesGlobals.prova5 = true;
                        Destroy(alicates);

                    }
                    break;
                default:
                    if (variablesGlobals.prova41)
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
}
