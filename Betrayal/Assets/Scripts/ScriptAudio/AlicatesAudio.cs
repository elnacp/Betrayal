using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlicatesAudio : MonoBehaviour {

    public GameObject alex;
    private bool isInside = false;


    private void Start()
    {
        alex.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "hand")
        {
            if(!isInside)
            {
                if (variablesGlobals.lang.Equals("español"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(46);
                }
                if (variablesGlobals.lang.Equals("english"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(56);
                }
                isInside = true;
            }
            
        }

    }





}
