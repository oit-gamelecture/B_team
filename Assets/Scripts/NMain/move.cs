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
    public Vector3 hukitobe;
    public int fastright;
    public int fastleft;
    public GameObject so;
    private a GetA;
    public bool wallTurn1;
    public bool wallTurn2;
    public int wc;
    public bool down;
    public GameObject Came;
    public float Cameee;
    public bool UUPP;
    public bool down2;
    void Start()
    {
        animator = GetComponent<Animator>();
        myTransform = this.transform;
        fastright = 0;
        fastleft = 0;
        GetA= so.GetComponent<a>();
        LAndRmove = 0;
    }

    // Update is called once per frame
    void Update()
    {

        var speed = Vector3.zero;
        if (isCooldown)
        {
            cooldownTimer += Time.deltaTime;
            if (cooldownTimer >= delayTime)
            {
                isCooldown = false;
                cooldownTimer = 0f;
            }
        }
        if (!buck && !Nbuck)
        {
            animator.SetBool("run", true);
            speed.z = runSpeed;

            // transform.Translate(speed * Time.deltaTime);

        }
        else if (buck)
        {

            animator.SetBool("run", false);
            runSpeed = 0f;
            speed.z = buckSpeed;
            transform.position += hukitobe * buckSpeed * Time.deltaTime;
            Vector3 rotation = transform.localEulerAngles;
            rotation.y = (int)(rotation.y / 80) * 90;
            transform.localEulerAngles = rotation;
            transform.Translate(speed * Time.deltaTime);

        }
        else if (Nbuck)
        {
            animator.SetBool("run", false);
            runSpeed = 0f;
            speed.z = NbuckSpeed;
            Debug.Log(hukitobe * NbuckSpeed);
            transform.position += hukitobe * NbuckSpeed * Time.deltaTime;
            Vector3 rotation = transform.localEulerAngles;
            rotation.y = (int)(rotation.y / 85) * 90;
            transform.localEulerAngles = rotation;
            transform.Translate(speed * Time.deltaTime);
        }

        if (down == true)
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
                b = 0f;
                down = false;
                down2 = true;
            }
        }
        if (down2 == true)
        {
            a = 90f * Time.deltaTime;
            if (b + a >90f)
            {
                a = 90 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b >= 90f)
            {
                b = 0f;
                Vector3 rotation = transform.localEulerAngles;
                rotation.y = (int)(rotation.y / 85) * 90;
                transform.localEulerAngles = rotation;
                down2 = false;
            }
        }
        Move();
        if (leftTurn)
        {
            /* leftTurn = false;
             Vector3 rotation = transform.localEulerAngles;
             rotation.y = (int)(rotation.y -90);
             transform.localEulerAngles = rotation;*/
            //LAndRmove += 1;
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
                Vector3 rotation = transform.localEulerAngles;
                rotation.y = (int)(rotation.y / 85) * 90;
                transform.localEulerAngles = rotation;
                StartCooldown();
            }
            if (fastleft == 0)
            {
                fastleft = 1;
                LAndRmove = -1;
            }
        }

        if (rightTurn)
        {
            /*rightTurn = false;
            Vector3 rotation = transform.localEulerAngles;
            rotation.y = (int)(rotation.y + 90);
            transform.localEulerAngles = rotation;*/
            //LAndRmove -= 1;

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
                Vector3 rotation = transform.localEulerAngles;
                rotation.y = (int)(rotation.y / 85) * 90;
                transform.localEulerAngles = rotation;
                StartCooldown();
            }
            if (fastright == 0)
            {
                fastright = 1;
                LAndRmove = 1;
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
            hukitobe = transform.forward;
            buck = true;
            HP -= 2;
            runSpeed = 0;
            buckSpeed = -15f;
            StartCoroutine(buckNow());
        }
        if (other.gameObject.tag == "NPCs")
        {
            hukitobe = transform.forward;
            HP -= 1;
            runSpeed = 0;
            NbuckSpeed = -2f;
            Nbuck = true;
            StartCoroutine(running());
        }
    }

    IEnumerator buckNow()
    {
        animator.SetBool("buck", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("buck", false);
        buck = false;
        down = true;
        Vector3 rotation = transform.localEulerAngles;
        rotation.y = (int)(rotation.y / 85) * 90;
        transform.localEulerAngles = rotation;
        animator.SetBool("run", true);
        if (HP <= 0)
        {
            //SceneManager.LoadScene("GameOver");
        }
        runSpeed = 10f;

        rotation.y = (int)(rotation.y / 80) * 90;
        transform.localEulerAngles = rotation;
    }
    IEnumerator running()
    {
        animator.SetBool("dame", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("dame", false);
        Nbuck = false;
        animator.SetBool("run", true);
        if (HP <= 0)
        {
            //SceneManager.LoadScene("GameOver");
        }
        runSpeed = 10f;
        Vector3 rotation = transform.localEulerAngles;
        rotation.y = (int)(rotation.y / 85) * 90;
        transform.localEulerAngles = rotation;
    }
    private void StartCooldown()
    {
        isCooldown = true;
        cooldownTimer = 0f;
    }
    void Move()
    {
        var speed = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.A) && LAndRmove >= 0 && GetA.aisu == 0)
        {
            Vector3 Ponta = transform.position;
            Vector3 right = transform.right;
            Ray ray = new Ray(Ponta, right);
            RaycastHit hit;
            if (!Physics.Raycast(ray, out hit, 6))
            {
                Debug.DrawRay(Ponta, right, Color.red);
                if (hit.collider != null)
                {
                    if (!hit.collider.CompareTag("NotR"))
                    {
                        speed = Vector3.left * 6;
                        LAndRmove -= 1;
                    }
                }
                else
                {
                    speed = Vector3.left * 6;
                    LAndRmove -= 1;
                }


            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && LAndRmove >= 0 && GetA.aisu == 1)
        {
            speed = Vector3.left * 6;
            LAndRmove -= 1;
        }

            if (Input.GetKeyDown(KeyCode.D) && LAndRmove <= 0&& GetA.aisu==0)
            {
                Vector3 Ponta = transform.position;
                Vector3 right = transform.right;
                Ray ray = new Ray(Ponta, right);
                RaycastHit hit;
                if (!Physics.Raycast(ray, out hit, 6))
                {
                    Debug.DrawRay(Ponta, right, Color.red);
                    if (hit.collider != null)
                    {
                        if (!hit.collider.CompareTag("NotR"))
                        {
                            speed = Vector3.right * 6;
                            LAndRmove += 1;
                        }
                    }
                    else
                    {
                        speed = Vector3.right * 6;
                        LAndRmove += 1;
                    }


                }

            }else if(Input.GetKeyDown(KeyCode.D) && LAndRmove <= 0 && GetA.aisu == 1)
        {
            speed = Vector3.right * 6;
            LAndRmove += 1;
        }
        transform.Translate(speed, Space.Self);
    }
}

