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
    public GameObject angryscp;
     Angry Angry;
    public GameObject Button;
    public TextMeshProUGUI answerText;
    public Queue<int> queue = new Queue<int>();
    public TextMeshProUGUI kennsuu;
    public GameObject NextButton;
    public int b;
    public AudioClip SE;
    public AudioClip WalkSE;
    AudioSource audioSource;
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
        audioSource = gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        kennsuu.text = queue.Count.ToString();
        if (queue.Count > 5)
        {
            Angry.angry += queue.Count*0.0002;
        }
        if (ScoerClass.oto == true)
        {
            if (!audioSource.isPlaying)  // 既に再生中でなければ再生する
            {
                audioSource.clip = WalkSE;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)  // 再生中の場合のみ停止する
            {
                audioSource.Stop();
            }
        }
    }
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        audioSource.volume = newSliderValue;
    }
    private IEnumerator RandomCallMail()
    {

        float randomInterval = Random.Range(5f, 5f);
        yield return new WaitForSeconds(randomInterval);
        queue.Enqueue(a);
        Debug.Log(a);
            audioSource.PlayOneShot(SE);



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
        int messageID = Random.Range(0, 6);
        switch (messageID)
        {
            case 0:
                answerText.text = "";
                subject.text = "上司";
                content.text = "おい!もう出社時間は過ぎてるぞ!";
                string[] answer = { "申し訳ありません", "寝てました", "中し訳ありません", "スヤァ" };
                mail0(answer, 0);
                break;
            case 1:
                answerText.text = "";
                subject.text = "上司";
                content.text = "会社には来れるのか？";
                string[] answer2 = { "急いでいきます", "まあ心配すんな", "犬丈夫です", "心配でしたか？" };
                mail0(answer2, 0);
                break;
            case 2:
                answerText.text = "";
                subject.text = "上司";
                content.text = "いつ着く？";
                string[] answer3 = { "なるべく早く行きます", "まだかかりそう", "間に合う間に合う!", "24時間ぐらいかな" };
                mail0(answer3, 0);
                break;
            case 3:
                answerText.text = "";
                subject.text = "上司";
                content.text = "会議だぞ!急げ!";
                string[] answer4 = { "絶対間に合わせます", "間に合わないかも", "行ける行ける", "急ぎンチャク" };
                mail0(answer4, 0);
                break;
            case 4:
                answerText.text = "";
                subject.text = "上司";
                content.text = "何故遅刻しているんだ？";
                string[] answer5 = { "寝坊していました", "寝てた", "寝すぎた", "気にしたら負けですよ" };
                mail0(answer5, 0);
                break;
            case 5:
                answerText.text = "";
                subject.text = "上司";
                content.text = "今何時だと思っている？";
                string[] answer6 = { "すぐに向かいます", "やべっ", "あー...", "ミスったー" };
                mail0(answer6, 0);
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
            Angry.angry+=0.2f;
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
