using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    GameObject[] NPCs;
    GameObject[] pNPCs;
    public int NPCCount = 11;
    public int pNPCCount = 4;
    void Start()
    {
        NPCs = new GameObject[NPCCount];
        pNPCs = new GameObject[pNPCCount];
        for (int i = 0; i < NPCCount; i++)
        {
            NPCs[i] = Instantiate(prefab1, new Vector3(0, 0.5f, 0), Quaternion.identity);
            NPCs[i].tag = "NPCs";
        }
        for (int i = 0;i < pNPCCount; i++)
        {
            pNPCs[i] = Instantiate(prefab2, new Vector3(0, 0, 0), Quaternion.identity);
            pNPCs[i].tag = "NPCs";
        }
        NPCs[0].transform.position = new Vector3(172, 1, 140);
        NPCs[1].transform.position = new Vector3(351, 1, 200);
        NPCs[2].transform.position = new Vector3(173, 1, 266);
        NPCs[3].transform.position = new Vector3(-8, 1, 383);
        NPCs[4].transform.position = new Vector3(456, 1, 450);
        NPCs[5].transform.position = new Vector3(600, 1, 260);
        NPCs[6].transform.position = new Vector3(524, 1, 851);
        NPCs[7].transform.position = new Vector3(-7, 1, 716);
        NPCs[8].transform.position = new Vector3(730, 1, 570);
        NPCs[9].transform.position = new Vector3(152, 1, 850);
        NPCs[10].transform.position = new Vector3(734, 1, 1060);

        pNPCs[0].transform.position = new Vector3(725,1,329);
        pNPCs[1].transform.position = new Vector3(306,1,260);
        pNPCs[2].transform.position = new Vector3(522,1,272);
        pNPCs[3].transform.position = new Vector3(130,1,133);
    }


    void Update()
    {

    }
}
