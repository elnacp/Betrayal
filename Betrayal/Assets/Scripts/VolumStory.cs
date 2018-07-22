using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumStory : MonoBehaviour {

    public GameObject On;
    public GameObject Off;

    private void Start()
    {
        On.SetActive(true);
        Off.SetActive(false);
    }


    public void ChangeMute(GameObject obj)
    {

        if( obj.name == "ON")
        {
            On.SetActive(false);
            Off.SetActive(true);
        }
        if( obj.name == "OFF")
        {
            On.SetActive(true);
            Off.SetActive(false);
        }

    }


}
