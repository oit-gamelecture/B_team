using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEditor.Search;
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
    public GameObject angryscp;
     Angry Angry;
    public GameObject Button;
    public TextMeshProUGUI answerText;
    public Queue<int> queue = new Queue<int>();
    public TextMeshProUGUI kennsuu;
    public GameObject NextButton;
    public int b;
    void Start()
    {
        Application.targetFrameRate = 60;
        subject = subjectBox.GetComponent<TextMeshProUGUI>();
        content = contentBox.GetComponent<TextMeshProUGUI>();
        StartCoroutine(RandomCallMail());
        a = 0;
        Angry = angryscp.GetComponent<Angry>();
        Button.SetActive(false);
        NextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        kennsuu.text=queue.Count.ToString();
    }
    private IEnumerator RandomCallMail()
    {

        float randomInterval = Random.Range(5f, 5f);
        yield return new WaitForSeconds(randomInterval);
        queue.Enqueue(a);
        Debug.Log(a);
        StartCoroutine(RandomCallMail());

        answerText.text = "";
        a = Random.Range(0, 2);
        if(a==b)
        {
            for (int i = 0; a ==b&&i<10;i++)
            {
                a= Random.Range(0, 2);
            }
        }
            b = a;
    }

    public void Mailmessage()
    {
        switch (queue.Peek())
        {
            case 0:
                subject.text = "1";
                content.text = "1";
                string[] answer = { "1", "2", "3", "4" };
                mail0(answer, 0);
                break;
                case 1:
                subject.text = "2";
                content.text = "6";
                string[] answer2 = { "5", "6", "7", "8" };
                mail0(answer2, 1);
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
        // 選択されたボタンの取得
        answerButton = answerEvent.currentSelectedGameObject;
        if (answerButton == null)
        {
            Debug.LogError("選択されたボタンがありません。");
            return;
        }
        Transform child = answerButton.transform.GetChild(0);

        TextMeshProUGUI buttonText = child.GetComponent<TextMeshProUGUI>();
        
        // 正解判定
        if (answers == buttonText.text)
        {
            if(Angry.angry>0)
            {
                Angry.angry -= 0.1f;
            }
            Debug.Log("あたり");
        }
        else
        {
            Angry.angry+=0.1f;
            Debug.Log("はずれ");
        }
        Button.SetActive(false);
        answerText.text = buttonText.text;
        queue.Dequeue();
        if(queue.Count > 0)
        {
            NextButton.SetActive(true);
        }

    }
}
