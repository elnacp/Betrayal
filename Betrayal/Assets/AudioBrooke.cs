using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBrooke : MonoBehaviour
{

    public GameObject alex;

    AudioSource brooke;

    //AUDIOS EN ESPAÑOL
    public AudioClip audio15;
    public AudioClip audio16;
    public AudioClip audio17;
    /*public AudioClip audio18;
    public AudioClip audio19;
    public AudioClip audio20;
    public AudioClip audio21;
    public AudioClip audio22;
    public AudioClip audio22;
    public AudioClip audio23;
    public AudioClip audio24;
    public AudioClip audio25;
    public AudioClip audio26;
    public AudioClip audio27;
    public AudioClip audio28;
    public AudioClip audio29;
    public AudioClip audio30;
    public AudioClip audio31;
    public AudioClip audio32;
    */
    //AUDIOS EN INGLES
    public AudioClip audio61;
    /*
    public AudioClip audio62;
    public AudioClip audio63;
    public AudioClip audio64;
    public AudioClip audio65;
    public AudioClip audio66;
    public AudioClip audio67;
    public AudioClip audio68;
    public AudioClip audio69;
    public AudioClip audio70;
    public AudioClip audio71;
    public AudioClip audio72;
    public AudioClip audio73;
    public AudioClip audio74;
    public AudioClip audio75;
    public AudioClip audio76;
    public AudioClip audio77;
    public AudioClip audio78;
    */

    private string lang;
    private bool español = false;
    private bool english = false;

    private int personatge;
    private int numeroAudio;



    // Use this for initialization
    void Start () {
        brooke = GetComponent<AudioSource>();
    }



    private void PedirActivar()
    {
        switch (personatge)
        {
            case 1: // BROOKE
                alex.GetComponent<AudioAlex>().ActivateAudio(numeroAudio);
                break;
            case 3: //JANE
                break;
        }
    }





    public void ActivateAudio(int num)
    {
        switch (num)
        {
            case 15:
                brooke.clip = audio15;
                brooke.Play();
                numeroAudio = 34;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 16:
                brooke.clip = audio16;
                brooke.Play();
                numeroAudio = 35;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 17:
                brooke.clip = audio17;
                brooke.Play();
                
                break;
        }

        
    }

}
