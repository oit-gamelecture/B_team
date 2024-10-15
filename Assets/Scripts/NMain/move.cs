using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float PlayerSpeed;
    public Animator animator;
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
