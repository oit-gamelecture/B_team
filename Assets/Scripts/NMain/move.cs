using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float PlayerSpeed;
    public Animator animator;
    public bool leftTurn;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftwall")
        {
            Transform myTransform = this.transform;
            Vector3 worldAngle = myTransform.eulerAngles;
            worldAngle.y = 90f;
        }
    }
    void Move()
    {
        var speed = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            speed.z = PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed.z = -PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            speed.x = -PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            speed.x = PlayerSpeed;
        }
        transform.Translate(speed);
    }
}
