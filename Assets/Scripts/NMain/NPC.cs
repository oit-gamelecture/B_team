using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject prefab1;
    GameObject[] NPCs;
    private int NPCCount = 180;
    private float a = 0.62f;
    void Start()
    {
        NPCs = new GameObject[NPCCount];
        for (int i = 0; i < NPCCount; i++)
        {
            if (i == 6 || i == 7 || i == 62||(i>=129&&i<=136))
            {
                continue;
            }
                NPCs[i] = Instantiate(prefab1, new Vector3(0, 0.5f, 0), Quaternion.identity);
                NPCs[i].tag = "NPCs";
            
        }
        NPCs[0].transform.position = new Vector3(148, a, 133.5f);
        NPCs[1].transform.position = new Vector3(351, a, 200);
        NPCs[2].transform.position = new Vector3(173, a, 266);
        NPCs[3].transform.position = new Vector3(-8, a, 383);
        NPCs[4].transform.position = new Vector3(456, a, 450);
        NPCs[5].transform.position = new Vector3(600, a, 260);
        //NPCs[6].transform.position = new Vector3(600, a, 260);
        //NPCs[7].transform.position = new Vector3(600, a, 260);
        NPCs[8].transform.position = new Vector3(730, a, 570);
        NPCs[9].transform.position = new Vector3(152, a, 850);
        NPCs[10].transform.position = new Vector3(734, a, 1060);
        NPCs[11].transform.position = new Vector3(344, a, 232);
        NPCs[12].transform.position = new Vector3(306.19f, a, 267.37f);
        NPCs[13].transform.position = new Vector3(243.19f, a, 267.37f);
        NPCs[14].transform.position = new Vector3(122.39f, a, 267.37f);
        NPCs[15].transform.position = new Vector3(96.8f, a, 267.37f);
        NPCs[16].transform.position = new Vector3(66.589f, a, 268);
        NPCs[17].transform.position = new Vector3(351, a, 180);
        NPCs[18].transform.position = new Vector3(290.90f, a, 145);
        NPCs[19].transform.position = new Vector3(320.41f, a, 140.96f);
        NPCs[20].transform.position = new Vector3(258.54f, a, 140.96f);
        NPCs[21].transform.position = new Vector3(240.44f, a, 140.96f);
        NPCs[22].transform.position = new Vector3(141.75f, a, 139.95f);
        NPCs[23].transform.position = new Vector3(148.05f, a, 145);
        NPCs[24].transform.position = new Vector3(276.05f, a, 148.58f);
        NPCs[25].transform.position = new Vector3(210, a, 133);
        NPCs[26].transform.position = new Vector3(183.78f, a, 148.57f);
        NPCs[27].transform.position = new Vector3(357.05f, a, 165);
        NPCs[28].transform.position = new Vector3(350.97f, a, 247.11f);
        NPCs[29].transform.position = new Vector3(356.35f, a, 206);
        NPCs[30].transform.position = new Vector3(198.05f, a, 147);
        NPCs[31].transform.position = new Vector3(313.95f, a, 275);
        NPCs[32].transform.position = new Vector3(271.45f, a, 275);
        NPCs[33].transform.position = new Vector3(268.35f, a, 273);
        NPCs[34].transform.position = new Vector3(212.57f, a, 261.26f);
        NPCs[35].transform.position = new Vector3(138.27f, a, 266.66f);
        NPCs[36].transform.position = new Vector3(56.57f, a, 265.86f);
        NPCs[37].transform.position = new Vector3(288.67f, a, 261.26f);
        NPCs[38].transform.position = new Vector3(25.75f, a, 265f);
        NPCs[39].transform.position = new Vector3(468.48f, a, 270);
        NPCs[40].transform.position = new Vector3(600.6f, a, 272.6f);
        NPCs[41].transform.position = new Vector3(549.8f, a, 272.61f);
        NPCs[42].transform.position = new Vector3(526.8f, a, 261.81f);
        NPCs[43].transform.position = new Vector3(486.4f, a, 267.25f);
        NPCs[44].transform.position = new Vector3(411.9f, a, 260.71f);
        NPCs[45].transform.position = new Vector3(428.6f, a, 265.5f);
        NPCs[46].transform.position = new Vector3(390.3f, a, 271.61f);
        NPCs[47].transform.position = new Vector3(680.7f, a, 266.81f);
        NPCs[48].transform.position = new Vector3(707.3f, a, 259.51f);
        NPCs[49].transform.position = new Vector3(694.48f, a, 270f);
        NPCs[50].transform.position = new Vector3(646.87f, a, 270f);
        NPCs[51].transform.position = new Vector3(630.67f, a, 265f);
        NPCs[52].transform.position = new Vector3(-0.7f, a, 344f);
        NPCs[53].transform.position = new Vector3(-7.2f, a,308.9f);
        NPCs[54].transform.position = new Vector3(-6.9f, a, 286.38f);
        NPCs[55].transform.position = new Vector3(-6.9f, a, 349.38f);
        NPCs[56].transform.position = new Vector3(-6.9f, a, 413.78f);
        NPCs[57].transform.position = new Vector3(-6.9f, a, 515.08f);
        NPCs[58].transform.position = new Vector3(-6.9f, a, 563.08f);
        NPCs[59].transform.position = new Vector3(-6.9f, a, 601.18f);
        NPCs[60].transform.position = new Vector3(-6.9f, a, 650.18f);
        NPCs[61].transform.position = new Vector3(-6.9f, a, 724.38f);
        //NPCs[62].transform.position = new Vector3(-6.9f, a, 715.08f);
        NPCs[63].transform.position = new Vector3(-6.9f, a, 810.48f);
        NPCs[64].transform.position = new Vector3(-6.9f, a, 697.98f);
        NPCs[65].transform.position = new Vector3(-6.9f, a, 790.48f);
        NPCs[66].transform.position = new Vector3(-6.9f, a, 768.08f);
        NPCs[67].transform.position = new Vector3(-6.9f, a, 602.88f);
        NPCs[68].transform.position = new Vector3(-12.5f,a, 384f);
        NPCs[69].transform.position = new Vector3(-12.1f, a, 485f);
        NPCs[70].transform.position = new Vector3(-0.9f, a, 492.97f);
        NPCs[71].transform.position = new Vector3(-0.9f, a, 554f);
        NPCs[72].transform.position = new Vector3(-6.9f, a, 586.2f);
        NPCs[73].transform.position = new Vector3(-6.3f, a, 648f);
        NPCs[74].transform.position = new Vector3(-12.7f, a, 685f);
        NPCs[75].transform.position = new Vector3(-1.8f, a, 685f);
        NPCs[76].transform.position = new Vector3(-7f, a, 728f);
        NPCs[77].transform.position = new Vector3(-12.4f, a, 760.4f);
        NPCs[78].transform.position = new Vector3(-12.4f, a, 823.6f);
        NPCs[79].transform.position = new Vector3(-12.1f, a, 462.8f);

        NPCs[80].transform.position = new Vector3(151.25f, a, 852.18f);
        NPCs[81].transform.position = new Vector3(202.3f, a, 852.18f);
        NPCs[82].transform.position = new Vector3(332.7f, a, 852.18f);
        NPCs[83].transform.position = new Vector3(237.9f, a, 845.78f);
        NPCs[84].transform.position = new Vector3(237.9f, a, 858.28f);
        NPCs[85].transform.position = new Vector3(488.9f, a, 847.98f);
        NPCs[86].transform.position = new Vector3(557.6f, a, 847.98f);
        NPCs[87].transform.position = new Vector3(638.6f, a, 856.78f);
        NPCs[88].transform.position = new Vector3(664.8f, a, 845.58f);
        NPCs[89].transform.position = new Vector3(395.1f, a, 858.28f);
        NPCs[90].transform.position = new Vector3(14.39f, a, 854f);
        NPCs[91].transform.position = new Vector3(178.7f, a, 857f);
        NPCs[92].transform.position = new Vector3(289f, a, 857f);
        NPCs[93].transform.position = new Vector3(355.2f, a, 853f);
        NPCs[94].transform.position = new Vector3(512.1f, a, 846f);
        NPCs[95].transform.position = new Vector3(616.6f, a, 858f);
        NPCs[96].transform.position = new Vector3(706.7f,       a, 843f);
        NPCs[97].transform.position = new Vector3(562f, a, 850f);
        NPCs[98].transform.position = new Vector3(491.4f, a, 859f);
        NPCs[99].transform.position = new Vector3(383.7f, a, 854f);
        NPCs[100].transform.position = new Vector3(233.4f, a, 856f);
        NPCs[101].transform.position = new Vector3(408.4f, a, 850f);
        NPCs[102].transform.position = new Vector3(59f, a, 856.2f);
        NPCs[103].transform.position = new Vector3(95.52f, a, 855f);
        NPCs[104].transform.position = new Vector3(135.1f, a, 850f);
        NPCs[105].transform.position = new Vector3(208.5f, a, 852f);
        NPCs[106].transform.position = new Vector3(-7f, a, 728f);

        NPCs[107].transform.position = new Vector3(455.5f, a, 821.78f);
        NPCs[108].transform.position = new Vector3(455.5f, a, 768.58f);
        NPCs[109].transform.position = new Vector3(455.5f, a, 647.98f);
        NPCs[110].transform.position = new Vector3(455.5f, a, 515.88f);
        NPCs[111].transform.position = new Vector3(455.5f, a, 548.68f);
        NPCs[112].transform.position = new Vector3(455.5f, a, 353.57f);
        NPCs[113].transform.position = new Vector3(455.5f, a, 318.88f);
        NPCs[114].transform.position = new Vector3(455.5f, a, 495.98f);
        NPCs[115].transform.position = new Vector3(456f, a, 344f);
        NPCs[116].transform.position = new Vector3(449.30f, a, 325f);
        NPCs[117].transform.position = new Vector3(456.1f, a, 435f);
        NPCs[118].transform.position = new Vector3(449.4f, a, 528f);
        NPCs[119].transform.position = new Vector3(462.3f, a, 517f);
        NPCs[120].transform.position = new Vector3(462.3f, a, 598f);
        NPCs[121].transform.position = new Vector3(456.2f, a, 584.14f);
        NPCs[122].transform.position = new Vector3(455.2f, a, 687f);
        NPCs[123].transform.position = new Vector3(461.4f, a, 719f);
        NPCs[124].transform.position = new Vector3(449.6f, a, 790f);
        NPCs[125].transform.position = new Vector3(455f, a, 764f);

        NPCs[126].transform.position = new Vector3(-12.4f, a, 760.4f);
        NPCs[127].transform.position = new Vector3(-12.4f, a, 823.6f);
        NPCs[128].transform.position = new Vector3(-12.1f, a, 462.8f); 
        
        NPCs[137].transform.position = new Vector3(730.83f, a, 297f);
        NPCs[138].transform.position = new Vector3(730.83f, a, 366f);
        NPCs[139].transform.position = new Vector3(724.58f, a, 408f);
        NPCs[140].transform.position = new Vector3(739.38f, a, 444f);
        NPCs[141].transform.position = new Vector3(737.58f, a, 521f);
        NPCs[142].transform.position = new Vector3(724.08f, a, 558f);
        NPCs[143].transform.position = new Vector3(732.08f, a, 579f);
        NPCs[144].transform.position = new Vector3(736.48f, a, 600f);
        NPCs[145].transform.position = new Vector3(730.38f, a, 635f);
        NPCs[146].transform.position = new Vector3(730.38f, a, 699f);
        NPCs[147].transform.position = new Vector3(725.78f, a, 688f);
        NPCs[148].transform.position = new Vector3(737.68f, a, 728f);
        NPCs[149].transform.position = new Vector3(737.68f, a, 768f);
        NPCs[150].transform.position = new Vector3(731.38f, a, 768f);
        NPCs[151].transform.position = new Vector3(731.38f, a, 893f);
        NPCs[152].transform.position = new Vector3(736.38f, a, 916f);
        NPCs[153].transform.position = new Vector3(736.38f, a, 975f);
        NPCs[154].transform.position = new Vector3(725.18f, a, 946f);
        NPCs[155].transform.position = new Vector3(732.78f, a, 1029f);
        NPCs[156].transform.position = new Vector3(738.98f, a, 1030f);
        NPCs[157].transform.position = new Vector3(738.98f, a, 1093f);
        NPCs[158].transform.position = new Vector3(729.88f, a, 1097f);
        NPCs[159].transform.position = new Vector3(729.88f, a, 1145f);
        NPCs[160].transform.position = new Vector3(725.28f, a, 1170f);
        NPCs[161].transform.position = new Vector3(731.19f, a, 363.81f);
        NPCs[162].transform.position = new Vector3(731.19f, a, 435.81f);
        NPCs[163].transform.position = new Vector3(731.19f, a, 404.81f);
        NPCs[164].transform.position = new Vector3(731.19f, a, 482.41f);
        NPCs[165].transform.position = new Vector3(731.19f, a,544.91f);
        NPCs[166].transform.position = new Vector3(731.19f, a, 622f);
        NPCs[167].transform.position = new Vector3(731.19f, a, 732.41f);
        NPCs[168].transform.position = new Vector3(731.19f, a, 777.91f);
        NPCs[169].transform.position = new Vector3(731.19f, a, 695f);
        NPCs[170].transform.position = new Vector3(731.19f, a, 886.81f);
        NPCs[171].transform.position = new Vector3(731.19f, a, 923.51f);
        NPCs[172].transform.position = new Vector3(731.19f, a, 1011.3f);
        NPCs[173].transform.position = new Vector3(731.19f, a, 978.41f);
        NPCs[174].transform.position = new Vector3(731.19f, a, 1066.5f);
        NPCs[175].transform.position = new Vector3(731.19f, a, 1100.2f);
        NPCs[176].transform.position = new Vector3(731.19f, a, 1137.9f);
        NPCs[177].transform.position = new Vector3(731.19f, a, 1166.2f);
        NPCs[178].transform.position = new Vector3(731.19f, a, 1153.9f);
        NPCs[179].transform.position = new Vector3(731.19f, a, 1205.7f);


    }


    void Update()
    {

    }
}
