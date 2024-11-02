using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCG : MonoBehaviour
{
    public GameObject Panel;
    private AudioSource audioSource;
    public GameObject[] otherCanvases;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        audioSource = gameObject.GetComponent<AudioSource>();
        foreach(var canvas in otherCanvases)
        {
            canvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(!Panel.activeSelf);
            if (Panel.activeSelf == true)
            {
                Time.timeScale = 0;
                if(audioSource.isPlaying)
                {
                    audioSource.Stop();
                }
                audioSource.loop = false;

                foreach (var canvas in otherCanvases)
                {
                    canvas.SetActive(false);
                }
            }
            else
            {
                Time.timeScale = 1;
                audioSource.loop = true;
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
        }
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
        Time.timeScale = 1;
    }
    public void owari()
    {
        Application.Quit();
        Time.timeScale = 1;
    }
}
