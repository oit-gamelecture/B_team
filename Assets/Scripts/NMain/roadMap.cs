using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMap : MonoBehaviour
{
     GameObject[] road=new GameObject[10];
    public GameObject Road;
    public int random;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            random = Random.Range(1, 1000);
            road[i] = Instantiate(Road, new Vector3(500, 0, random), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
