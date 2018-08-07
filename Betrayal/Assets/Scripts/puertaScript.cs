using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaScript : MonoBehaviour {

    private Animator anim;
    public bool isOpen;
    public GameObject puerta;
  

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isOpen)
        {
            anim.SetBool("open", true);
            puerta.GetComponent<PuertaAudio>().doorSound();
            isOpen = false;
        }
	}
}
