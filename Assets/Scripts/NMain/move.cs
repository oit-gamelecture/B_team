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
    public bool down3;
    public bool down4;
    public bool down5;
    public bool down6;
    public bool down7;
    public bool down8;
    public bool down9;
    public bool down10;
    public bool down11;
    public bool down12;
    public GameObject[] otherCanvases;
    public bool kabeSE;
    public bool big;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        myTransform = this.transform;
        fastright = 0;
        fastleft = 0;
        GetA = so.GetComponent<a>();
        LAndRmove = 0;
        kabeSE = false;
        big = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
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
        if (!buck && !Nbuck && !down && !down2 &&!down3&&!down4 && !leftTurn && !rightTurn && !down5 && !down6 )
        {
            animator.SetBool("run", true);
            speed.z = runSpeed;
            Vector3 rotation = transform.localEulerAngles;
            rotation.y = (int)(rotation.y / 85) * 90;
            transform.localEulerAngles = rotation;
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
        else if (Nbuck && buck == false && down == false && down2 == false && !down3 && !down4 && !down5 && !down6 && !down7 && !down8 && !down9 && !down10&&!down11 && !down12)
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
            a = -180f * Time.deltaTime;
            if (b + a < -45f)
            {
                a = -45 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b <= -45f)
            {
                b = 0f;
                down = false;
                down2 = true;
            }
        }
        if (down2 == true)
        {
           
                a = 180f * Time.deltaTime;
                if (b + a > 45f)
                {
                    a = 45 - b;
                }
                b += a;

                myTransform.Rotate(0, a, 0);
                if (b >= 45f)
                {
                    b = 0f;
                    down2 = false;
                    down3 = true;
            }
        }
        if (down3 == true)
        {
            a = 180f * Time.deltaTime;
            if (b + a > 45f)
            {
                a = 45 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b >= 45f)
            {
                b = 0f;
                down3 = false;
                down4 = true;
            }
        }
        if (down4 == true)
        {
            a = -180f * Time.deltaTime;
            if (b + a < -45f)
            {
                a = -45 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b <= -45f)
            {
                b = 0f;
                down4 = false;
                down5 = true;
                
            }
            
        }
        if (down5 == true)
        {
            a = -180f * Time.deltaTime;
            if (b + a < -45f)
            {
                a = -45 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b <= -45f)
            {
                b = 0f;
                down5 = false;
                down6 = true;
                big = true;
            }
        }
        if (down6 == true)
        {

            a = 180f * Time.deltaTime;
            if (b + a > 45f)
            {
                a = 45 - b;
            }
            b += a;

            myTransform.Rotate(0, a, 0);
            if (b >= 45f)
            {
                b = 0f;
                down6 = false;
                animator.SetBool("buck", false);
            }
        }

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

                LAndRmove = -1;
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
                LAndRmove = 1;
            
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
            foreach (var canvas in otherCanvases)
            {
                canvas.SetActive(false);
            }
            kabeSE = true;
            hukitobe = transform.forward;
            buck = true;
            HP -= 2;
            runSpeed = 0;
            buckSpeed = -20f;
            StartCoroutine(buckNow());
        }
        if (other.gameObject.tag == "NPCs"&&buck==false)
        {
            foreach (var canvas in otherCanvases)
            {
                canvas.SetActive(false);
            }
            kabeSE = true;
            hukitobe = transform.forward;
            HP -= 1;
            runSpeed = 0;
            NbuckSpeed = -8f;
            Nbuck = true;
            StartCoroutine(running());
        }
        if (other.gameObject.CompareTag("buckwall"))
        {
            Vector3 correctedPosition = transform.position;
            correctedPosition.x = Mathf.Round(correctedPosition.x); // 位置を丸めて補正
            transform.position = correctedPosition;
            correctedPosition.z = Mathf.Round(correctedPosition.z); // 位置を丸めて補正
            transform.position = correctedPosition;
        }
        if (other.gameObject.CompareTag("NPCs") && buck == false)
        {
            Vector3 correctedPosition = transform.position;
            correctedPosition.x = Mathf.Round(correctedPosition.x); // 位置を丸めて補正
            transform.position = correctedPosition;
            correctedPosition.z = Mathf.Round(correctedPosition.z); // 位置を丸めて補正
            transform.position = correctedPosition;
        }
    }

    IEnumerator buckNow()
    {
        animator.SetBool("buck", true);
        yield return new WaitForSeconds(1);

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
        yield return new WaitForSeconds(0.2f);
        transform.position += transform.right * 0.23f*Time.deltaTime;
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
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
        {

        }
        else if (Input.GetKeyDown(KeyCode.A) && LAndRmove >= 0 && GetA.aisu == 0&&down==false&&down2==false&&!leftTurn&&!rightTurn &&Time.timeScale==1)
        {

            Vector3 Ponta = transform.position;
            Vector3 left = -transform.right;
            Ray ray = new Ray(Ponta, left);
            RaycastHit hit;
            if (!Physics.Raycast(ray, out hit, 6))
            {
                Debug.DrawRay(Ponta, left, Color.red);
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
                    Debug.Log(88);
                }


            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && LAndRmove >= 0 && GetA.aisu == 1 && down == false && down2 == false&&!leftTurn && !rightTurn && Time.timeScale == 1)
        {
            speed = Vector3.left * 6;
            LAndRmove -= 1;
        }

            if (Input.GetKeyDown(KeyCode.D) && LAndRmove <= 0&& GetA.aisu==0 && down == false && down2 == false && !leftTurn && !rightTurn && Time.timeScale == 1)
            {
                Vector3 Ponta = transform.position;
                Vector3 right = transform.right;
                Ray ray = new Ray(Ponta, right);
                RaycastHit hit;
                if (!Physics.Raycast(ray, out hit, 6))
                {
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

            }else if(Input.GetKeyDown(KeyCode.D) && LAndRmove <= 0 && GetA.aisu == 1 && down == false && down2 == false && !leftTurn && !rightTurn && Time.timeScale == 1)
        {
            speed = Vector3.right * 6;
            LAndRmove += 1;
        }
        transform.Translate(speed, Space.Self);
    }
}

