using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    float theTime;
    public float speed;
    public float time = 840;

    void Start()
    {
        
        text = GetComponent<Text>();
    }
    void Update()
    {
        time -= Time.deltaTime * speed;
        string minutes = ((time % 3600) / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        text.text = minutes + ":" + seconds;
        /*theTime = Time.deltaTime * speed;
        string minutes = ((theTime % 3600)/60).ToString("00");
        string seconds = (theTime % 60).ToString("00");
        text.text = minutes + ":" + seconds;*/

    }



}
