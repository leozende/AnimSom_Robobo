using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioClip _passoDireito;
	public AudioClip _passoErquerdo;
	private AudioSource audio;

	void Start(){
		audio = gameObject.GetComponent<AudioSource> ();
	}

	void passoDireito(float volume){
		audio.clip = _passoDireito;
		audio.volume = volume;
		audio.Play ();
	}


	void passoEsquerdo(float volume){
		audio.clip = _passoErquerdo;
		audio.volume = volume;
		audio.Play ();
	}
}
