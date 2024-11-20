using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCG : MonoBehaviour
{
    public GameObject Panel;
    private AudioSource[] audioSources;
    public GameObject[] otherCanvases;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        audioSources = gameObject.GetComponents<AudioSource>();
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
                ScoerClass.oto = false;
                foreach(var source in audioSources)
                    
                {
                    if (source.isPlaying)
                    {
                        source.Stop();
                    }
                    source.loop = false;
                }


                foreach (var canvas in otherCanvases)
                {
                    canvas.SetActive(false);
                }
            }
            else
            {
                Time.timeScale = 1;
                ScoerClass.oto = true;
                foreach (var source in audioSources)
                {
                    source.loop = true;


                    if (!source.isPlaying)
                    {
                        source.Play();
                    }
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
