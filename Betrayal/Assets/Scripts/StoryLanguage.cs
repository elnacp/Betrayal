using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryLanguage : MonoBehaviour {

    public GameObject textoE;
    public GameObject textoS;

    private string lang; 

    private void Start()
    {
        lang = variablesGlobals.lang;
        if(lang.Equals("español"))
        {
            textoE.SetActive(true);
            textoS.SetActive(false);
        }
        if (lang.Equals("english"))
        {
            textoE.SetActive(false);
            textoS.SetActive(true);
        }


    }


}
