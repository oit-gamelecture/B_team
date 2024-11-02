using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossCon : MonoBehaviour
{
    public float speed;
    public bool strike = false;
    public bool isFeatureActive = true;


    private Animator anim;
    private Rigidbody rb;
    private int currentLane = 3;
    private Vector3 verticalTargetPosition;
    private bool canMove = false;

    public float setTimer = 10;
    private float timer = 0;
    private bool isTurn = false; 


    //Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        //StartCoroutine(ReadyGoCoroutine());
        canMove = false;
    }


    //Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= setTimer){
            if(isTurn == false){
                transform.Rotate(0,180,0);
                isTurn = true;
            }
        }

        if (canMove)
        {
            anim.SetTrigger("idle");


            verticalTargetPosition.y = Mathf.MoveTowards(verticalTargetPosition.y, 0, 5 * Time.deltaTime);
            Vector3 targetPosition = new Vector3(verticalTargetPosition.x, verticalTargetPosition.y, transform.position.z);
            // transform.position = Vector3.MoveTowards(transform.position, targetPosition, laneSpeed * Time.deltaTime);
        }
    }

    /* private void FixedUpdate()
    {
        if (canMove)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "StopPos")
        {
            speed = 0;
            anim.SetTrigger("Stop");
            canMove = false;
            anim.SetTrigger("Stop");

            Debug.Log("触れた");
        }
    }
    void OnTriggerStay(Collider other)
    {
        anim.SetTrigger("Stop");
    }

    IEnumerator ReadyGoCoroutine()
    {
        speed = 0;
        canMove = false;
        yield return new WaitForSeconds(100);
        /*canMove = true;
        anim.SetTrigger("idle");
        //speed = 10;*/
    //} 
}
