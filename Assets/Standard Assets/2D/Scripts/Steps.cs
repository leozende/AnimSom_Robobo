using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField]private AudioClip aClipLeft;
    [SerializeField]private AudioClip aClipRight;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void leftStep(float volumeMinimo = 0.8f)
    {
        audioSource.Stop();
        audioSource.clip = aClipLeft;
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.volume = Random.Range(volumeMinimo, volumeMinimo + 0.2f);
        audioSource.Play();
    }
    
    void rightStep(float volumeMinimo = 0.8f)
    {
        audioSource.Stop();
        audioSource.clip = aClipRight;
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.volume = Random.Range(volumeMinimo, volumeMinimo + 0.2f);
        audioSource.Play();
    }

}
