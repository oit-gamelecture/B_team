using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCMove : MonoBehaviour
{
    public bool NPCLeft;
    public bool NPCRight;
    public bool NPCTurn;
    public bool NPCLeftTurn;
    public float a;
    public float b;
    public Animator animator;
    public float NPCspeed;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("walk", true);
        NPCspeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Vector3.zero;
        speed.z = NPCspeed;
        transform.Translate(speed*Time.deltaTime);
        Transform myTransform = this.transform;
        Vector3 rotation = transform.localEulerAngles;
        rotation.y = (int)(rotation.y / 85) * 90;
        transform.localEulerAngles = rotation;
        if (NPCLeft)
        {
            rotation.y = (int)(rotation.y - 90);
            transform.localEulerAngles = rotation;
            NPCLeft = false;
            /* a = -90f * Time.deltaTime;
             if (b + a < -90f)
             {
                 a = -90 - b;
             }
             b += a;

             myTransform.Rotate(0, a, 0);
             if (b <= -90f)
             {
                 NPCLeft = false;
                 b = 0f;
             }*/
        }
            if (NPCRight)
            {
            rotation.y = (int)(rotation.y + 90);
            transform.localEulerAngles = rotation;
            NPCRight = false;
            /*
            a = 90f * Time.deltaTime;
                if (b + a > 90f)
                {
                    a = 90 - b;
                }
                b += a;
                myTransform.Rotate(0, a, 0);
                if (b >= 90f)
                {
                    NPCRight = false;
                    b = 0f;
            }*/
        }
        if (NPCTurn)
        {
            rotation.y = (int)(rotation.y + 180);
            transform.localEulerAngles = rotation;
            NPCTurn = false;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPCLeft")
        {
            NPCLeft = true;
        }
        if (other.gameObject.tag == "NPCRight")
        {
            NPCRight = true;
        }
        if(other.gameObject.tag =="NPCTurn")
        {
            NPCTurn = true;
        }


        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("walk", false);
            NPCspeed = 0;
            StartCoroutine(tomaru());
        }
    }
    IEnumerator tomaru()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("walk", true);
        NPCspeed = 3f;
    }

}
