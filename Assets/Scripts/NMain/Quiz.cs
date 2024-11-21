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
            if (!audioSource.isPlaying)  // ä˘Ç…çƒê∂íÜÇ≈Ç»ÇØÇÍÇŒçƒê∂Ç∑ÇÈ
            {
                audioSource.clip = WalkSE;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)  // çƒê∂íÜÇÃèÍçáÇÃÇ›í‚é~Ç∑ÇÈ
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

        //float randomInterval = Random.Range(12, 12);
        yield return new WaitForSeconds(7f);
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
                subject.text = "è„éi";
                content.text = "Ç®Ç¢!Ç‡Ç§èoé–éûä‘ÇÕâﬂÇ¨ÇƒÇÈÇº!";
                string[] answer = { "ê\ÇµñÛÇ†ÇËÇ‹ÇπÇÒ", "êQÇƒÇ‹ÇµÇΩ", "íÜÇµñÛÇ†ÇËÇ‹ÇπÇÒ", "ÉXÉÑÉ@" };
                mail0(answer, 0);
                break;
            case 1:
                answerText.text = "";
                subject.text = "è„éi";
                content.text = "âÔé–Ç…ÇÕóàÇÍÇÈÇÃÇ©ÅH";
                string[] answer2 = { "ã}Ç¢Ç≈Ç¢Ç´Ç‹Ç∑", "Ç‹Ç†êSîzÇ∑ÇÒÇ»", "å¢è‰ïvÇ≈Ç∑", "êSîzÇ≈ÇµÇΩÇ©ÅH" };
                mail0(answer2, 0);
                break;
            case 2:
                answerText.text = "";
                subject.text = "è„éi";
                content.text = "Ç¢Ç¬íÖÇ≠ÅH";
                string[] answer3 = { "Ç»ÇÈÇ◊Ç≠ëÅÇ≠çsÇ´Ç‹Ç∑", "Ç‹ÇæÇ©Ç©ÇËÇªÇ§", "ä‘Ç…çáÇ§ä‘Ç…çáÇ§!", "24éûä‘ÇÆÇÁÇ¢Ç©Ç»" };
                mail0(answer3, 0);
                break;
            case 3:
                answerText.text = "";
                subject.text = "è„éi";
                content.text = "âÔãcÇæÇº!ã}Ç∞!";
                string[] answer4 = { "ê‚ëŒä‘Ç…çáÇÌÇπÇ‹Ç∑", "ä‘Ç…çáÇÌÇ»Ç¢Ç©Ç‡", "çsÇØÇÈçsÇØÇÈ", "ã}Ç¨ÉìÉ`ÉÉÉN" };
                mail0(answer4, 0);
                break;
            case 4:
                answerText.text = "";
                subject.text = "è„éi";
                content.text = "âΩåÃíxçèÇµÇƒÇ¢ÇÈÇÒÇæÅH";
                string[] answer5 = { "êQñVÇµÇƒÇ¢Ç‹ÇµÇΩ", "êQÇƒÇΩ", "êQÇ∑Ç¨ÇΩ", "ãCÇ…ÇµÇΩÇÁïâÇØÇ≈Ç∑ÇÊ" };
                mail0(answer5, 0);
                break;
            case 5:
                answerText.text = "";
                subject.text = "è„éi";
                content.text = "ç°âΩéûÇæÇ∆évÇ¡ÇƒÇ¢ÇÈÅH";
                string[] answer6 = { "Ç∑ÇÆÇ…å¸Ç©Ç¢Ç‹Ç∑", "Ç‚Ç◊Ç¡", "Ç†Å[...", "É~ÉXÇ¡ÇΩÅ[" };
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
        // ëIëÇ≥ÇÍÇΩÉ{É^ÉìÇÃéÊìæ
        answerButton = answerEvent.currentSelectedGameObject;
        if (answerButton == null)
        {
            Debug.LogError("ëIëÇ≥ÇÍÇΩÉ{É^ÉìÇ™Ç†ÇËÇ‹ÇπÇÒÅB");
            return;
        }
        Transform child = answerButton.transform.GetChild(0);

        TextMeshProUGUI buttonText = child.GetComponent<TextMeshProUGUI>();
        
        // ê≥âîªíË
        if (answers == buttonText.text)
        {
            if(Angry.angry>0)
            {
                Angry.angry -= 0.1f;
            }
            Debug.Log("Ç†ÇΩÇË");

        }
        else
        {
            Angry.angry+=0.2f;
            Debug.Log("ÇÕÇ∏ÇÍ");
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
