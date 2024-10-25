using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab;
    GameObject[] NPCs;
    public int NPCCount = 10;
    void Start()
    {
        NPCs = new GameObject[NPCCount];
        for (int i = 0; i <NPCCount; i++)
        {
            NPCs[i] = Instantiate(prefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
            NPCs[i].transform.position = new Vector3(1, 1, 1);
            NPCs[i].tag = "NPCs";

        }



    }


    void Update()
    {

    }
}
