using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class stand : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("barara", true);
            StartCoroutine(butukaru());
        }
    }
    IEnumerator butukaru()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("barara",false);
    }
}
