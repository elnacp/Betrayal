using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAlex : MonoBehaviour {

    public GameObject mensaje;
    public GameObject brooke;
    

    AudioSource alex;

    //AUDIOS EN ESPAÑOL
    public AudioClip audio33;
    public AudioClip audio34;
    public AudioClip audio35;
    public AudioClip audio36;
    public AudioClip audio37;
    public AudioClip audio38;
    public AudioClip audio39;
    public AudioClip audio40;
    public AudioClip audio41;
    public AudioClip audio42;
    public AudioClip audio43;
    public AudioClip audio44;
    public AudioClip audio45;
    public AudioClip audio46;
    
    //AUDIOS EN INGLES
    public AudioClip audio47;
    public AudioClip audio48;
    public AudioClip audio49;
    public AudioClip audio50;
    public AudioClip audio51;
    public AudioClip audio52;
    public AudioClip audio53;
    public AudioClip audio54;
    public AudioClip audio55;
    public AudioClip audio56;
    public AudioClip audio57;
    public AudioClip audio58;
    public AudioClip audio59;
    public AudioClip audio60;

    private string lang;
    private bool español = false;
    private bool english = false;

    private int personatge;
    private int numeroAudio;


	// Use this for initialization
	void Start () {
        lang = variablesGlobals.lang;
        
        
        if (lang.Equals("español"))
        {
            español = true;
            Wait(5);
            alex = GetComponent<AudioSource>();
            alex.clip = audio33;
            alex.Play();
            personatge = 2;
            numeroAudio = 15;
            Invoke("PedirActivar", alex.clip.length);
            
            //GetComponent<AudioBrooke>().ActivateAudioBrooke(15); 
            

        }

        if (lang.Equals("english"))
        {
            english = true;
            Wait(30);
            alex = GetComponent<AudioSource>();
            alex.clip = audio47;
            alex.Play();
            personatge = 2;
            numeroAudio = 62;
            Invoke("PedirActivar", alex.clip.length);
        }

    }

    private void PedirActivar( )
    {
        switch (personatge)
        {
            case 2: // BROOKE
                brooke.GetComponent<AudioBrooke>().ActivateAudio(numeroAudio);
                break;
            case 3: //JANE
                break;
        }
    }

    public void ActivateAudio(int num)
    {
        switch (num)
        {

            //DIALOGO EN ESPAÑOL
            case 34:
                alex.clip = audio34;
                alex.Play();
                numeroAudio = 16;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 35:
                alex.clip = audio35;
                alex.Play();
                numeroAudio = 17;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
           
            //DIALOGO EN INGLES
            case 48:
                alex.clip = audio48;
                alex.Play();
                numeroAudio = 63;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 49:
                alex.clip = audio49;
                alex.Play();
                numeroAudio = 64;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
        }

        
    }




    IEnumerator Wait(int time)
    {
        yield return new WaitForSeconds(time);
    }

}
