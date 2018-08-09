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
        Debug.Log("Abrir");
        cajon.clip = abrir;
        cajon.Play();
    }

    public void CerrarCajon()
    {
        Debug.Log("Cerrar");
        cajon.clip = cerrar;
        cajon.Play();
    }



}
