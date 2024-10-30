using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float PlayerSpeed;
    public float runSpeed;
    public float buckSpeed;
    public float NbuckSpeed;
    public Animator animator;
    public bool leftTurn;
    public bool rightTurn;
    public float a;
    public float b;
    public Transform myTransform;
    public float delayTime = 2.0f;
    private bool isCooldown = false;
    private float cooldownTimer = 0;
    public bool buck;
    public bool Nbuck;
    public int LAndRmove = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Vector3.zero;
        if (isCooldown)
        {
            cooldownTimer += Time.deltaTime;
            if(cooldownTimer >= delayTime )
            {
                isCooldown = false;
                cooldownTimer = 0f;
            }
        }
        if (buck==false&&Nbuck==false)
        {
            animator.SetBool("run", true);
            speed.z = runSpeed;
            transform.Translate(speed);
        }
        else if (buck == true)
        {
            animator.SetBool("run", false);
            speed.z = buckSpeed;
            transform.Translate(speed);
        }else if (Nbuck == true) {
            animator.SetBool("run", false);
            speed.z = NbuckSpeed;
            transform.Translate(speed);
        }
        Move();
        if (leftTurn)
        {
            a = -180f * Time.deltaTime;
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
                StartCooldown();
            }
        }

        if (rightTurn)
        {
            a = 180f * Time.deltaTime;
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
                StartCooldown();
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (isCooldown)
        {
            return;
        }
        if (other.gameObject.tag == "leftwall")
        {
            leftTurn = true;
        }
        if (other.gameObject.tag == "rightwall")
        {
            rightTurn = true;

        }
        if (other.gameObject.tag == "buckwall")
        {
            animator.SetBool("buck", true);
            buck = true;
            runSpeed = 0;
            buckSpeed = -0.35f;
            StartCoroutine(buckNow());
        }
        if (other.gameObject.tag == "NPCs")
        {
            animator.SetBool("dame", true);
            runSpeed = 0;
            NbuckSpeed = -0.02f;
            Nbuck = true;
            StartCoroutine(running());
        }
    }
    IEnumerator buckNow()
    {
        
        yield return new WaitForSeconds(2);
        animator.SetBool("buck", false);
        buck = false;
        yield return new WaitForSeconds(0.5f);
        runSpeed = 0.3f;
    }
    IEnumerator running()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("dame", false);
        Nbuck = false;
        yield return new WaitForSeconds(0.5f);
        runSpeed = 0.3f;
        yield return new WaitForSeconds(3);
    }
    private void StartCooldown()
    {
        isCooldown = true;
        cooldownTimer = 0f;
    }
    void Move()
    {
        var speed = Vector3.zero;
        if (Input.GetKey(KeyCode.S))
        {
            speed.z = -PlayerSpeed;
        }
        if (Input.GetKeyDown(KeyCode.A)&&LAndRmove>=0)
        {
            if (!Physics.Raycast(transform.position, -transform.right, 6))
            {
            speed = Vector3.left*6;
            LAndRmove -= 1;
            }

            
        }
        if (Input.GetKeyDown(KeyCode.D)&&LAndRmove<=0)
        {
            if (!Physics.Raycast(transform.position, transform.right, 6))
            {
                speed = Vector3.right * 6;
                LAndRmove += 1;
            }
        }
        transform.Translate(speed,Space.Self);
    }
}
