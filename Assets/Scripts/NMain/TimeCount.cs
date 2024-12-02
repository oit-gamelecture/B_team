using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public float TimerCount;
    public double time;
    public float Maxtime;
    public Image Timer;
    // Start is called before the fidrst frame update
    void Start()
    {
        Maxtime = 150f;
        TimerCount = Maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        TimerCount-=Time.deltaTime;
        float percent = (float)TimerCount / Maxtime;
        Timer.fillAmount = percent;
        ScoerClass.TimeSC = percent;
        if (percent<=0)
        {
            SceneManager.LoadScene("clearscene2");
        }
    }
}
