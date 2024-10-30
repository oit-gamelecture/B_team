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
    public float a;
    public float b;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("walk", true);
    }

    // Update is called once per frame
    void Update()
    {
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
            StartCoroutine(tomaru());
        }
    }
    IEnumerator tomaru()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("walk", true);
    }

}
