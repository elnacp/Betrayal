using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_linterna : MonoBehaviour {

    private bool isInside;


    // Use this for initialization
    private void OnTriggerStay(Collider other)
    {
        if( other.tag == "cajon")
        {
            isInside = true;
        }


    }

    

}
