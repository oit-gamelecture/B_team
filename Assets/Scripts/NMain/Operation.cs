using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Operation : MonoBehaviour
{
    public GameObject sumaho;
    public GameObject mail;
    public GameObject Canvas;
    public GameObject map;
    public GameObject mapGround;
    public GameObject Canvasbuck;
    public int a = 0;
    public bool see=false;
    public GameObject mailmail;
    private Quiz messe;

    void Start()
    {
        sumaho.SetActive(false);
        mail.SetActive(false);
        Canvas.SetActive(false);
        Canvasbuck.SetActive(false);
        map.SetActive(false);
        mapGround.SetActive(false);
        messe = mailmail.GetComponent<Quiz>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&a==0)
        {
            see = !see;
            sumaho.SetActive(see);
            Canvas.SetActive(true);
            Canvasbuck.SetActive(true);
            mail.SetActive(false) ;
            map.SetActive(false);
            mapGround.SetActive(false);
        }

    }
 
    public void mailButton()
    {
         mail.SetActive(true); 
        Canvas.SetActive(false);
        Canvasbuck.SetActive(false);
        if(messe.queue.Count>0)
        {
            messe.Mailmessage();
            messe.Button.SetActive(true);
        }

    }
    public void buck()
    {
        Canvas.SetActive(true);
        Canvasbuck.SetActive(true);
        mail.SetActive(false) ;
    }
    public void mapButton()
    {
        map.SetActive(true);
        mapGround.SetActive(true);
        Canvas.SetActive(false);
        Canvasbuck.SetActive(false);
    }
    public void Nextmail()
    {
        if (messe.queue.Count > 0)
        {
            messe.Mailmessage();
            messe.Button.SetActive(true);
            messe.NextButton.SetActive(false);
        }

    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="clearwall")
        {
            SceneManager.LoadScene("ClearScene1");
        }
    }
}
