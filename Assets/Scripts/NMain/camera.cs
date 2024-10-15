using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Moba;
    private Operation Operation;
    // Start is called before the first frame update
    void Start()
    {
        Operation = Moba.GetComponent<Operation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Operation.see ==false)
        {
            float mx = Input.GetAxis("Mouse X");
            transform.RotateAround(transform.position, Vector3.up, mx);
        }
    }
}
