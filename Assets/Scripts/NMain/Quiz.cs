using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Quiz : MonoBehaviour
{
    public TextMeshProUGUI[] Tn;
    private TextMeshProUGUI subject;
    private TextMeshProUGUI content;
    public string answers;
    public GameObject answerButton;
    public EventSystem answerEvent;
    public GameObject subjectBox;
    public GameObject contentBox;
    public string Answer;
    public int a;

    void Start()
    {
        Application.targetFrameRate = 60;
        subject = subjectBox.GetComponent<TextMeshProUGUI>();
        content = contentBox.GetComponent<TextMeshProUGUI>();
        StartCoroutine(RandomCallMail());
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator RandomCallMail()
    {
        float randomInterval = Random.Range(5f, 5f);
        yield return new WaitForSeconds(randomInterval);
        Mailmessage();
        StartCoroutine(RandomCallMail());
    }
    public void Mailmessage()
    {
        switch (a)
        {
            case 0:
                subject.text = "1";
                content.text = "1";
                string[] answer = { "1", "2", "3", "4" };
                mail0(answer, 0);
                a= 1;
                break;
                case 1:
                subject.text = "2";
                content.text = "2";
                string[] answer2 = { "1", "2", "3", "4" };
                mail0(answer2, 1);
                a = 0;
                break;

        }
    }
    public void mail0(string[] T, int Answer)
    {
        answers = T[Answer];
        for (int i = 0; i < 4; i++)
        {
            string temp = T[i];

            int randomIndex = Random.Range(0, 4);
            T[i] = T[randomIndex];

            T[randomIndex] = temp;

        }
        for (int i = 0; i < 4; i++)
        {
            Tn[i].text = T[i];

        }
    }
    public void CheckAnswer()
    {
        // ëIëÇ≥ÇÍÇΩÉ{É^ÉìÇÃéÊìæ
        answerButton = answerEvent.currentSelectedGameObject;

        Transform child = answerButton.transform.GetChild(0);

        TextMeshProUGUI buttonText = child.GetComponent<TextMeshProUGUI>();

        // ê≥âîªíË
        if (answers == buttonText.text)
        {
            Debug.Log("Ç†ÇΩÇË");
        }
        else
        {
            Debug.Log("ÇÕÇ∏ÇÍ");
        }
    }
}
