using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public Sprite normal;
    public Sprite stay;
    public GameObject exit;
   
   


    private void OnTriggerEnter(Collider other)
    {
        exit.GetComponent<SpriteRenderer>().sprite = stay;
    }

    private void OnTriggerStay(Collider other)
    {
        if( other.tag == "hand")
        {
            if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Three)) // comprueba si se mantiene dentro y clica la A 
            {
                 ChangeToScene(0); 
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        exit.GetComponent<SpriteRenderer>().sprite = normal;
    }


    public void ChangeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}
