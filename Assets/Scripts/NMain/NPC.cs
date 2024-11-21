using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    GameObject[] NPCs;
    GameObject[] pNPCs;
    private int NPCCount = 180;
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
        //NPCs[6].transform.position = new Vector3(524, 1, 851);
        //NPCs[7].transform.position = new Vector3(-7, 1, 716);
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
        NPCs[24].transform.position = new Vector3(276.05f, 1, 148.58f);
        NPCs[25].transform.position = new Vector3(210, 1, 133);
        NPCs[26].transform.position = new Vector3(183.78f, 1, 148.57f);
        NPCs[27].transform.position = new Vector3(357.05f, 1, 160);
        NPCs[28].transform.position = new Vector3(350.97f, 1, 247.11f);
        NPCs[29].transform.position = new Vector3(356.35f, 1, 206);
        NPCs[30].transform.position = new Vector3(198.05f, 1, 147);
        NPCs[31].transform.position = new Vector3(313.95f, 1, 275);
        NPCs[32].transform.position = new Vector3(271.45f, 1, 275);
        NPCs[33].transform.position = new Vector3(268.35f, 1, 273);
        NPCs[34].transform.position = new Vector3(212.57f, 1, 261.26f);
        NPCs[35].transform.position = new Vector3(138.27f, 1, 266.66f);
        NPCs[36].transform.position = new Vector3(56.57f, 1, 265.86f);
        NPCs[37].transform.position = new Vector3(288.67f, 1, 261.26f);
        NPCs[38].transform.position = new Vector3(25.75f, 1, 265f);
        NPCs[39].transform.position = new Vector3(468.48f, 1, 270);
        NPCs[40].transform.position = new Vector3(600.6f, 1, 272.6f);
        NPCs[41].transform.position = new Vector3(549.8f, 1, 272.61f);
        NPCs[42].transform.position = new Vector3(526.8f, 1, 261.81f);
        NPCs[43].transform.position = new Vector3(486.4f, 1, 267.25f);
        NPCs[44].transform.position = new Vector3(411.9f, 1, 260.71f);
        NPCs[45].transform.position = new Vector3(428.6f, 1, 265.5f);
        NPCs[46].transform.position = new Vector3(390.3f, 1, 271.61f);
        NPCs[47].transform.position = new Vector3(680.7f, 1, 266.81f);
        NPCs[48].transform.position = new Vector3(707.3f, 1, 259.51f);
        NPCs[49].transform.position = new Vector3(694.48f, 1, 270f);
        NPCs[50].transform.position = new Vector3(646.87f, 1, 270f);
        NPCs[51].transform.position = new Vector3(630.67f, 1, 265f);
        NPCs[52].transform.position = new Vector3(-0.7f, 1, 344f);
        NPCs[53].transform.position = new Vector3(-7.2f, 1,308.9f);
        NPCs[54].transform.position = new Vector3(-6.9f, 1, 286.38f);
        NPCs[55].transform.position = new Vector3(-6.9f, 1, 349.38f);
        NPCs[56].transform.position = new Vector3(-6.9f, 1, 413.78f);
        NPCs[57].transform.position = new Vector3(-6.9f, 1, 515.08f);
        NPCs[58].transform.position = new Vector3(-6.9f, 1, 563.08f);
        NPCs[59].transform.position = new Vector3(-6.9f, 1, 601.18f);
        NPCs[60].transform.position = new Vector3(-6.9f, 1, 650.18f);
        NPCs[61].transform.position = new Vector3(-6.9f, 1, 724.38f);
        //NPCs[62].transform.position = new Vector3(-6.9f, 1, 715.08f);
        NPCs[63].transform.position = new Vector3(-6.9f, 1, 810.48f);
        NPCs[64].transform.position = new Vector3(-6.9f, 1, 697.98f);
        NPCs[65].transform.position = new Vector3(-6.9f, 1, 790.48f);
        NPCs[66].transform.position = new Vector3(-6.9f, 1, 768.08f);
        NPCs[67].transform.position = new Vector3(-6.9f, 1, 602.88f);
        NPCs[68].transform.position = new Vector3(-12.5f, 1, 384f);
        NPCs[69].transform.position = new Vector3(-12.1f, 1, 485f);
        NPCs[70].transform.position = new Vector3(-0.9f, 1, 492.97f);
        NPCs[71].transform.position = new Vector3(-0.9f, 1, 554f);
        NPCs[72].transform.position = new Vector3(-6.9f, 1, 586.2f);
        NPCs[73].transform.position = new Vector3(-6.3f, 1, 648f);
        NPCs[74].transform.position = new Vector3(-12.7f, 1, 685f);
        NPCs[75].transform.position = new Vector3(-1.8f, 1, 685f);
        NPCs[76].transform.position = new Vector3(-7f, 1, 728f);
        NPCs[77].transform.position = new Vector3(-12.4f, 1, 760.4f);
        NPCs[78].transform.position = new Vector3(-12.4f, 1, 823.6f);
        NPCs[79].transform.position = new Vector3(-12.1f, 1, 462.8f);

        NPCs[80].transform.position = new Vector3(151.25f, 1, 852.18f);
        NPCs[81].transform.position = new Vector3(202.3f, 1, 852.18f);
        NPCs[82].transform.position = new Vector3(332.7f, 1, 852.18f);
        NPCs[83].transform.position = new Vector3(237.9f, 1, 845.78f);
        NPCs[84].transform.position = new Vector3(237.9f, 1, 858.28f);
        NPCs[85].transform.position = new Vector3(488.9f, 1, 847.98f);
        NPCs[86].transform.position = new Vector3(557.6f, 1, 847.98f);
        NPCs[87].transform.position = new Vector3(638.6f, 1, 856.78f);
        NPCs[88].transform.position = new Vector3(664.8f, 1, 845.58f);
        NPCs[89].transform.position = new Vector3(395.1f, 1, 858.28f);
        NPCs[90].transform.position = new Vector3(14.39f, 1, 854f);
        NPCs[91].transform.position = new Vector3(178.7f, 1, 857f);
        NPCs[92].transform.position = new Vector3(289f, 1, 857f);
        NPCs[93].transform.position = new Vector3(355.2f, 1, 853f);
        NPCs[94].transform.position = new Vector3(512.1f, 1, 846f);
        NPCs[95].transform.position = new Vector3(616.6f, 1, 858f);
        NPCs[96].transform.position = new Vector3(706.7f, 1, 843f);
        NPCs[97].transform.position = new Vector3(562f, 1, 850f);
        NPCs[98].transform.position = new Vector3(491.4f, 1, 859f);
        NPCs[99].transform.position = new Vector3(383.7f, 1, 854f);
        NPCs[100].transform.position = new Vector3(233.4f, 1, 856f);
        NPCs[101].transform.position = new Vector3(408.4f, 1, 850f);
        NPCs[102].transform.position = new Vector3(59f, 1, 856.2f);
        NPCs[103].transform.position = new Vector3(95.52f, 1, 855f);
        NPCs[104].transform.position = new Vector3(135.1f, 1, 850f);
        NPCs[105].transform.position = new Vector3(208.5f, 1, 852f);
        NPCs[106].transform.position = new Vector3(-7f, 1, 728f);

        NPCs[107].transform.position = new Vector3(455.5f, 1, 821.78f);
        NPCs[108].transform.position = new Vector3(455.5f, 1, 768.58f);
        NPCs[109].transform.position = new Vector3(455.5f, 1, 647.98f);
        NPCs[110].transform.position = new Vector3(455.5f, 1, 515.88f);
        NPCs[111].transform.position = new Vector3(455.5f, 1, 548.68f);
        NPCs[112].transform.position = new Vector3(455.5f, 1, 353.57f);
        NPCs[113].transform.position = new Vector3(455.5f, 1, 318.88f);
        NPCs[114].transform.position = new Vector3(455.5f, 1, 495.98f);
        NPCs[115].transform.position = new Vector3(456f, 1, 344f);
        NPCs[116].transform.position = new Vector3(449.30f, 1, 325f);
        NPCs[117].transform.position = new Vector3(456.1f, 1, 435f);
        NPCs[118].transform.position = new Vector3(449.4f, 1, 528f);
        NPCs[119].transform.position = new Vector3(462.3f, 1, 517f);
        NPCs[120].transform.position = new Vector3(462.3f, 1, 598f);
        NPCs[121].transform.position = new Vector3(456.2f, 1, 584.14f);
        NPCs[122].transform.position = new Vector3(455.2f, 1, 687f);
        NPCs[123].transform.position = new Vector3(461.4f, 1, 719f);
        NPCs[124].transform.position = new Vector3(449.6f, 1, 790f);
        NPCs[125].transform.position = new Vector3(455f, 1, 764f);
        NPCs[126].transform.position = new Vector3(-7f, 1, 728f);

        NPCs[127].transform.position = new Vector3(-12.4f, 1, 760.4f);
        NPCs[128].transform.position = new Vector3(-12.4f, 1, 823.6f);
        NPCs[129].transform.position = new Vector3(-12.1f, 1, 462.8f);
        NPCs[107].transform.position = new Vector3(455.5f, 1, 821.78f);
        NPCs[108].transform.position = new Vector3(455.5f, 1, 768.58f);
        NPCs[109].transform.position = new Vector3(455.5f, 1, 647.98f);
        NPCs[110].transform.position = new Vector3(455.5f, 1, 515.88f);
        NPCs[111].transform.position = new Vector3(455.5f, 1, 548.68f);
        NPCs[112].transform.position = new Vector3(455.5f, 1, 353.57f);
        NPCs[113].transform.position = new Vector3(455.5f, 1, 318.88f);
        NPCs[114].transform.position = new Vector3(455.5f, 1, 495.98f);
        NPCs[115].transform.position = new Vector3(456f, 1, 344f);
        NPCs[116].transform.position = new Vector3(449.30f, 1, 325f);
        NPCs[117].transform.position = new Vector3(456.1f, 1, 435f);
        NPCs[118].transform.position = new Vector3(449.4f, 1, 528f);
        NPCs[119].transform.position = new Vector3(462.3f, 1, 517f);
        NPCs[120].transform.position = new Vector3(462.3f, 1, 598f);
        NPCs[121].transform.position = new Vector3(456.2f, 1, 584.14f);
        NPCs[122].transform.position = new Vector3(455.2f, 1, 687f);
        NPCs[123].transform.position = new Vector3(461.4f, 1, 719f);
        NPCs[124].transform.position = new Vector3(449.6f, 1, 790f);
        NPCs[125].transform.position = new Vector3(455f, 1, 764f);
        NPCs[126].transform.position = new Vector3(-7f, 1, 728f);
        
        NPCs[127].transform.position = new Vector3(730.83f, 1, 297f);
        NPCs[128].transform.position = new Vector3(730.83f, 1, 366f);
        NPCs[129].transform.position = new Vector3(724.58f, 1, 408f);
        NPCs[130].transform.position = new Vector3(739.38f, 1, 444f);
        NPCs[141].transform.position = new Vector3(737.58f, 1, 521f);
        NPCs[142].transform.position = new Vector3(724.08f, 1, 558f);
        NPCs[143].transform.position = new Vector3(732.08f, 1, 579f);
        NPCs[144].transform.position = new Vector3(736.48f, 1, 600f);
        NPCs[145].transform.position = new Vector3(730.38f, 1, 635f);
        NPCs[146].transform.position = new Vector3(730.38f, 1, 699f);
        NPCs[147].transform.position = new Vector3(725.78f, 1, 688f);
        NPCs[148].transform.position = new Vector3(737.68f, 1, 728f);
        NPCs[149].transform.position = new Vector3(737.68f, 1, 768f);
        NPCs[150].transform.position = new Vector3(731.38f, 1, 768f);
        NPCs[151].transform.position = new Vector3(731.38f, 1, 893f);
        NPCs[152].transform.position = new Vector3(736.38f, 1, 916f);
        NPCs[153].transform.position = new Vector3(736.38f, 1, 975f);
        NPCs[154].transform.position = new Vector3(725.18f, 1, 946f);
        NPCs[155].transform.position = new Vector3(732.78f, 1, 1029f);
        NPCs[156].transform.position = new Vector3(738.98f, 1, 1030f);
        NPCs[157].transform.position = new Vector3(738.98f, 1, 1093f);
        NPCs[158].transform.position = new Vector3(729.88f, 1, 1097f);
        NPCs[159].transform.position = new Vector3(729.88f, 1, 1145f);
        NPCs[160].transform.position = new Vector3(725.28f, 1, 1170f);
        NPCs[161].transform.position = new Vector3(731.19f, 1, 363.81f);
        NPCs[162].transform.position = new Vector3(731.19f, 1, 435.81f);
        NPCs[163].transform.position = new Vector3(731.19f, 1, 404.81f);
        NPCs[164].transform.position = new Vector3(731.19f, 1, 482.41f);
        NPCs[165].transform.position = new Vector3(731.19f, 1,544.91f);
        NPCs[166].transform.position = new Vector3(731.19f, 1, 622f);
        NPCs[167].transform.position = new Vector3(731.19f, 1, 732.41f);
        NPCs[168].transform.position = new Vector3(731.19f, 1, 777.91f);
        NPCs[169].transform.position = new Vector3(731.19f, 1, 695f);
        NPCs[170].transform.position = new Vector3(731.19f, 1, 886.81f);
        NPCs[171].transform.position = new Vector3(731.19f, 1, 923.51f);
        NPCs[172].transform.position = new Vector3(731.19f, 1, 1011.3f);
        NPCs[173].transform.position = new Vector3(731.19f, 1, 978.41f);
        NPCs[174].transform.position = new Vector3(731.19f, 1, 1066.5f);
        NPCs[175].transform.position = new Vector3(731.19f, 1, 1100.2f);
        NPCs[176].transform.position = new Vector3(731.19f, 1, 1137.9f);
        NPCs[177].transform.position = new Vector3(731.19f, 1, 1166.2f);
        NPCs[178].transform.position = new Vector3(731.19f, 1, 1153.9f);
        NPCs[179].transform.position = new Vector3(731.19f, 1, 1205.7f);


        pNPCs[0].transform.position = new Vector3(725,1,329);
        pNPCs[1].transform.position = new Vector3(265,1,260);
        pNPCs[2].transform.position = new Vector3(522,1,272);
        pNPCs[3].transform.position = new Vector3(130,1,133);
    }


    void Update()
    {

    }
}
