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
        NPCspeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Vector3.zero;
        speed.z = NPCspeed;
        transform.Translate(speed);
        Transform myTransform = this.transform;
        if (NPCLeft)
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
                NPCLeft = false;
                b = 0f;
            }
        }
            if (NPCRight)
            {
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
            }
        }
        if (NPCTurn)
        {
            a = 90f * Time.deltaTime;
            if (b + a > 180f)
            {
                a = 180 - b;
            }
            b += a;
            myTransform.Rotate(0, a, 0);
            if (b >= 180f)
            {
                NPCTurn = false;
                b = 0f;
            }
        }
        if (NPCLeftTurn)
        {
            a = -90f * Time.deltaTime;
            if (b + a <- 180f)
            {
                a = -180 - b;
            }
            b += a;
            myTransform.Rotate(0, a, 0);
            if (b <= -180f)
            {
                NPCLeftTurn = false;
                b = 0f;
            }
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
        if (other.gameObject.tag == "NPCLeftTurn")
        {
            NPCLeftTurn = true;
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
        NPCspeed = 0.1f;
    }

}
