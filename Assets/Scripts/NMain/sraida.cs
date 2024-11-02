using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sraida : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject oto;
    private ESCG mu;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        mu= oto.GetComponent<ESCG>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mu.Panel.activeSelf)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            //audioSource.loop = false;
        }
        else
        {
            //audioSource.loop = true;
            if (!audioSource.isPlaying)
            {
                audioSource.Play(); 
            }
        }
    }
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        audioSource.volume = newSliderValue;
    }
}
