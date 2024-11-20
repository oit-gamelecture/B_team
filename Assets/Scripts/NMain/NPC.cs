using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    GameObject[] NPCs;
    GameObject[] pNPCs;
    private int NPCCount = 24;
    private int pNPCCount = 4;
    void Start()
    {
        NPCs = new GameObject[NPCCount];
        pNPCs = new GameObject[pNPCCount];
        for (int i = 0; i < NPCCount; i++)
        {
            NPCs[i] = Instantiate(prefab1, new Vector3(0, 0.5f, 0), Quaternion.identity);
            NPCs[i].tag = "NPCs";
        }
        for (int i = 0; i < pNPCCount; i++)
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
        NPCs[11].transform.position = new Vector3(344, 1, 232);
        NPCs[12].transform.position = new Vector3(306.19f, 1, 267.37f);
        NPCs[13].transform.position = new Vector3(243.19f, 1, 267.37f);
        NPCs[14].transform.position = new Vector3(122.39f, 1, 267.37f);
        NPCs[15].transform.position = new Vector3(96.8f, 1, 267.37f);
        NPCs[16].transform.position = new Vector3(66.589f, 1, 268);
        NPCs[17].transform.position = new Vector3(351, 1, 180);
        NPCs[18].transform.position = new Vector3(290.90f, 1, 145);
        NPCs[19].transform.position = new Vector3(320.41f, 1, 140.96f);
        NPCs[20].transform.position = new Vector3(258.54f, 1, 140.96f);
        NPCs[21].transform.position = new Vector3(240.44f, 1, 140.96f);
        NPCs[22].transform.position = new Vector3(141.75f, 1, 139.95f);
        NPCs[23].transform.position = new Vector3(148.05f, 1, 145);



        pNPCs[0].transform.position = new Vector3(725,1,329);
        pNPCs[1].transform.position = new Vector3(265,1,260);
        pNPCs[2].transform.position = new Vector3(522,1,272);
        pNPCs[3].transform.position = new Vector3(130,1,133);
    }


    void Update()
    {

    }
}
