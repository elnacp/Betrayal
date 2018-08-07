using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReloj : MonoBehaviour {

    public AudioSource audio;
    public AudioClip tictac;
    public AudioClip final;


    private void Start()
    {
        audio.GetComponent<AudioSource>();
    }

    public void ActivarReloj()
    {
        audio.clip = tictac;
        audio.loop = true;
        audio.Play();

    }

    public void FinalReloj()
    {
        audio.clip = tictac;
        audio.loop = false;
        audio.Play();
    }


    public void DesactivarReloj()
    {
        audio.clip = null;
    }

}
