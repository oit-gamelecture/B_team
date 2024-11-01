using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public int aisu;
    // Start is called before the first frame update
    void Start()
    {
        aisu = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            aisu = 1;
        }
    }
}
