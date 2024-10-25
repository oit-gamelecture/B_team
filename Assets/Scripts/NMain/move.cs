using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float PlayerSpeed;
    public float runSpeed;
    public Animator animator;
    public bool leftTurn;
    public bool rightTurn;
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        if (!Input.GetKey(KeyCode.S))
        {
            var speed = Vector3.zero;
            animator.SetBool("run", true);
            speed.z = runSpeed;
            transform.Translate(speed);
        }
        else
        {
            animator.SetBool("run", false);
        }
        Move();
        if (leftTurn && b > -90f)
        {
            a = -90f * Time.deltaTime;
            if (b + a < -90f)
            {
                a = -90 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b <= -90f)
            {
                leftTurn = false;
                b = 0f;
            }
        }

        if (rightTurn && b < 90f)
        {
            a = 90f * Time.deltaTime;
            if(b+a>90f)
            {
               a=90-b ;
            }
            b += a;
            myTransform.Rotate(0, a, 0);
            if (b >= 90f)
            {
                rightTurn = false;
                b = 0f;
            }
        }
        }
        public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftwall")
        {
            leftTurn =true;
        }
        if (other.gameObject.tag == "rightwall")
        {
            rightTurn =true;
        }
    }
    void Move()
    {
        var speed = Vector3.zero;
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
