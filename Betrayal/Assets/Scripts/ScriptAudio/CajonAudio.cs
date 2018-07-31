using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajonAudio : MonoBehaviour {



    public AudioClip abrir;
    public AudioClip cerrar;
    public AudioSource cajon;



    void Start()
    {
        cajon.GetComponent<AudioSource>();    
    }

    public void AbrirCajon()
    {
        cajon.clip = abrir;
        cajon.Play();
    }

    public void CerrarCajon()
    {
        cajon.clip = cerrar;
        cajon.Play();
    }



}
