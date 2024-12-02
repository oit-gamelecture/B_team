using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sucor : MonoBehaviour
{
    public TextMeshProUGUI ScoerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(ScoerClass.hyouka<0.1&&ScoerClass.TimeSC>0.4)
        {
            ScoerText.text = "•]‰¿A";
        }
        else if (ScoerClass.hyouka < 0.2 && ScoerClass.TimeSC >0.3)
        {
            ScoerText.text = "•]‰¿B";
        }
        else if (ScoerClass.hyouka < 0.3 && ScoerClass.TimeSC >0.25)
        {
            ScoerText.text = "•]‰¿C";
        }
        else if (ScoerClass.hyouka < 0.4 && ScoerClass.TimeSC >0.15)
        {
            ScoerText.text = "•]‰¿D";
        }
        else if (ScoerClass.hyouka < 0.5&&ScoerClass.TimeSC <=0.15)
        {
            ScoerText.text = "•]‰¿E";
        }
    }
}
