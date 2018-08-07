using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAudio : MonoBehaviour {

    public AudioSource porta;
    public AudioClip open;


    private void Start()
    {
        porta = GetComponent<AudioSource>();
    }

    public void doorSound()
    {
        porta.clip = open;
        porta.Play();

    }


}
