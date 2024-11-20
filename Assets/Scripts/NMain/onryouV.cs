using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class onryouV : MonoBehaviour
{
    private AudioSource[] audioSources;
    // Start is called before the first frame update
    void Start()
    {
        audioSources = gameObject.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = newSliderValue;
        }
    }
}
