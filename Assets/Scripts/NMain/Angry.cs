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
        if(angry>=1)
        {
            angry = 1;
            //SceneManager.LoadScene(angry);
        }
        float percent = (float)angry / MaxAngry;
        angryGage.fillAmount = percent;
    }
}
