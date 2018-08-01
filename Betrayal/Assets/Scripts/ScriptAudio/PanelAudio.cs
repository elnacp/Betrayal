using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAudio : MonoBehaviour {

    public AudioSource panel;

    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip click;

    private void Start()
    {
        panel.GetComponent<AudioSource>();

    }

    public void IncorrectCode()
    {
        panel.clip = incorrect;
        panel.Play();

    }

    public void CorrectCode()
    {
        panel.clip = correct;
        panel.Play();
    }

    public void ClickCode()
    {
        panel.clip = click;
        panel.Play();
    }



}
