using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumStory : MonoBehaviour {

    
    public AudioSource volum;
    public AudioClip español;
    public AudioClip english;


   

    private void Start()
    {
        if (variablesGlobals.lang.Equals("español"))
        {
            volum.clip = español;
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            volum.clip = english;
        }
        volum.Play();
       
        
    }


    

    


}
