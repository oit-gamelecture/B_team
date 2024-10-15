using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class asobi : MonoBehaviour
{
    public int random;
    public TextMeshProUGUI deme;
    public bool move;
    public int joukenn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move == true)
        {
        random = Random.Range(1, 7);
            deme.text = random.ToString();
        }
    }
    public void OnclickDown()
    {
        move = true;
        if (move == true&&joukenn==1)
        {
            move = false;
            joukenn = 0;
        }
        if (move == true) 
        {
          joukenn = 1;      
        }

    }
}
