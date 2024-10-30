using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab;
    GameObject[] NPCs;
    public int NPCCount = 11;
    void Start()
    {
        NPCs = new GameObject[NPCCount];
        for (int i = 0; i <NPCCount; i++)
        {
            NPCs[i] = Instantiate(prefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
            NPCs[i].tag = "NPCs";
        }
        NPCs[0].transform.position = new Vector3(172, 1, 140);
        NPCs[1].transform.position = new Vector3(173, 1, 263);
        NPCs[2].transform.position = new Vector3(350, 1, 200);
        NPCs[3].transform.position = new Vector3(-11, 1, 383);
        NPCs[4].transform.position = new Vector3(456, 1, 450);
        NPCs[5].transform.position = new Vector3(600, 1, 260);
        NPCs[6].transform.position = new Vector3(524, 1, 851);
        NPCs[7].transform.position = new Vector3(-9, 1, 716);
        NPCs[8].transform.position = new Vector3(730, 1, 570);
        NPCs[9].transform.position = new Vector3(152, 1, 850);
        NPCs[10].transform.position = new Vector3(734, 1, 1060);

    }


    void Update()
    {

    }
}
