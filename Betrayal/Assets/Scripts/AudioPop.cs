using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPop : MonoBehaviour {

    public AudioSource popAudio;
    public AudioClip pop;

	// Use this for initialization
	void Start () {
        popAudio = GetComponent<AudioSource>();
	}
	
	public void PopAudio()
    {
        popAudio.clip = pop;
        popAudio.Play();
    }
}
