using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public GameObject sumaho;
    public GameObject mail;
    public GameObject Canvas;
    public GameObject map;
    public int a = 0;
    public bool see=false;
    void Start()
    {
        sumaho.SetActive(false);
        mail.SetActive(false);
        Canvas.SetActive(false);
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&a==0)
        {
            see = !see;
            sumaho.SetActive(see);
            Canvas.SetActive(true);
            mail.SetActive(false) ;
            map.SetActive(false);
        }

    }
    public void mailButton()
    {
         mail.SetActive(true); 
        Canvas.SetActive(false);
    }
    public void buck()
    {
        Canvas.SetActive(true) ;
        mail.SetActive(false) ;
    }
    public void mapButton()
    {
        map.SetActive(true);
        Canvas.SetActive(false) ;
    }
}
