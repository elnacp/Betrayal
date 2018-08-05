using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    float theTime;
    public float speed;
    public float time;

    void Start()
    {
        
        text = GetComponent<Text>();
    }
    void Update()
    {
       if( variablesGlobals.prova5 == true)
        {
            if (time >= 0)
            {
                time -= Time.deltaTime * speed;
                string minutes = ((time % 3600) / 60).ToString("00");
                string seconds = (time % 60).ToString("00");
                text.text = minutes + ":" + seconds;
            }

            if (time < 0)
            {
                text.text = "FINAAL";
            }
        }
        


    }



}
