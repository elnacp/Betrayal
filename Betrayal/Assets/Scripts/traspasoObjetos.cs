using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traspasoObjetos : MonoBehaviour {

    public GameObject brooke;
    public GameObject key;
    

   


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.name);
        switch (other.name)
        {
            case "Llave":
                if (variablesGlobals.lang.Equals("español")) { brooke.GetComponent<AudioBrooke>().ActivateAudio(18); }
                if (variablesGlobals.lang.Equals("english")) { brooke.GetComponent<AudioBrooke>().ActivateAudio(65); }
                

            break;
        }
        
      

    }
}
