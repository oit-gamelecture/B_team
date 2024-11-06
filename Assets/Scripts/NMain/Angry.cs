using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Angry : MonoBehaviour
{
    public double angry;
    public int MaxAngry;
    public Image angryGage;
    
    void Start()
    {
        angry = 0;
    }

    void Update()
    {
        ScoerClass.hyouka = angry;
        if(angry>=0.5)
        {
            angry = 0.5;
            SceneManager.LoadScene("ClearScene3");
        }
        float percent = (float)angry / MaxAngry;
        angryGage.fillAmount = percent;
    }
    
}
