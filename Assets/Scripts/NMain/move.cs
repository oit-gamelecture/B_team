using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int HP = 10;
    public float rotationSpeed = 180f;
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

        // 左に回転する処理
        if (leftTurn)
        {
            StartCoroutine(RotateOverTime(-90f)); // -90度回転
            leftTurn = false; // コルーチンが処理を引き継ぐのでfalseにする
        }

        // 右に回転する処理
        if (rightTurn)
        {
            StartCoroutine(RotateOverTime(90f)); // 90度回転
            rightTurn = false; // コルーチンが処理を引き継ぐのでfalseにする
        }
    }

    private IEnumerator RotateOverTime(float targetAngle)
    {
        float angle = 0f;
        while (Mathf.Abs(angle) < Mathf.Abs(targetAngle))
        {
            float step = rotationSpeed * Mathf.Sign(targetAngle) * 0.07f; // 0.02秒毎に少しずつ回転
            if (Mathf.Abs(angle + step) > Mathf.Abs(targetAngle))
            {
                step = targetAngle - angle; // 目標角度を超えないように調整
            }

            myTransform.Rotate(0, step, 0);
            angle += step;

            yield return new WaitForSeconds(0.02f); // 0.02秒待機（フレームに依存しない待機）
        }

        StartCooldown();
        /*Move();
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
            if (b + a > 90f)
            {
                a = 90 - b;
            }
            b += a;
            myTransform.Rotate(0, a, 0);
            if (b >= 90f)
            {
                rightTurn = false;
                b = 0f;
                StartCooldown();
            }
        }*/
        /*if (leftTurn)
        {
            float rotationSpeed = 90f; // 回転速度を設定
            Quaternion targetRotation = Quaternion.Euler(0, -90, 0);
            myTransform.rotation = Quaternion.RotateTowards(myTransform.rotation, targetRotation, rotationSpeed);

            if (myTransform.rotation == targetRotation)
            {
                leftTurn = false;
                StartCooldown();
            }

        }

        if (rightTurn)
        {
            float rotationSpeed = 90f; // 回転速度を設定
            Quaternion targetRotation = Quaternion.Euler(0, 90, 0);
            myTransform.rotation = Quaternion.RotateTowards(myTransform.rotation, targetRotation, rotationSpeed);
            myTransform.position +=new Vector3
            if (myTransform.rotation == targetRotation)
            {
                rightTurn = false;
                StartCooldown();
            }
        }*/
    }
        public void OnTriggerEnter(Collider other)
    {
        if (isCooldown)
        {
            return;
        }
        if (other.gameObject.tag == "leftwall")
        {
            if (rightTurn == false)
            {
                leftTurn = true;
            }
        }
        if (other.gameObject.tag == "rightwall")
        {
            if (leftTurn == false)
            {
                rightTurn = true;
            }
            }
            if (other.gameObject.tag == "buckwall")
        {
            animator.SetBool("buck", true);
            buck = true;
            HP -= 2;
            runSpeed = 0;
            buckSpeed = -0.35f;
            StartCoroutine(buckNow());
        }
        if (other.gameObject.tag == "NPCs")
        {
            animator.SetBool("dame", true);
            HP -= 1;
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
        if (HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        yield return new WaitForSeconds(0.5f);
        runSpeed = 0.3f;
    }
    IEnumerator running()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("dame", false);
        Nbuck = false;
        if (HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
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
