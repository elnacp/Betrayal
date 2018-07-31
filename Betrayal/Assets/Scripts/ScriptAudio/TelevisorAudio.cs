using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelevisorAudio : MonoBehaviour {


    public AudioSource televisor;
    public AudioClip isOn;


    void Start()
    {
        televisor.GetComponent<AudioSource>();
    }


    public void ActivarTelevisor()
    {
        televisor.clip = isOn;
        televisor.Play();
    }


    public void DesactivarTelevisor()
    {
        televisor.clip = null;
        televisor.Play();
    }


}
