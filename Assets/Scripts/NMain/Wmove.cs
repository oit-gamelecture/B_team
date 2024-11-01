using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wmove : MonoBehaviour
{
    private float forceMagnitude = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log(9);
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            Vector3 collisionDirectin = (other.transform.forward);
            playerRb.AddForce(collisionDirectin*forceMagnitude);

        }
    }
}
