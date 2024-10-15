using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public GameObject sumaho;
    public int a = 0;
    private bool see=false;
    // Start is called before the first frame update
    void Start()
    {
        sumaho.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&a==0)
        {
            see = !see;
            sumaho.SetActive(see);
        }
    }
    
}
