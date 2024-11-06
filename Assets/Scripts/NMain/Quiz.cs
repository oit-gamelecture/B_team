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
    public AudioClip sound1;
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
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        kennsuu.text = queue.Count.ToString();
        if (queue.Count > 5)
        {
            Angry.angry += queue.Count*0.0002;
        }
        

    }
    private IEnumerator RandomCallMail()
    {

        float randomInterval = Random.Range(5f, 5f);
        yield return new WaitForSeconds(randomInterval);
        queue.Enqueue(a);
        Debug.Log(a);
        //audioSource.PlayOneShot(sound1);
        if (audioSource != null && sound1 != null)
        {
            audioSource.PlayOneShot(sound1);
        }
        else
        {
            Debug.LogError("audioSource�܂���sound1��null�ł�");
        }

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
                subject.text = "��i";
                content.text = "����!�����o�Ў��Ԃ͉߂��Ă邼!";
                string[] answer = { "�\���󂠂�܂���", "�Q�Ă܂���", "�����󂠂�܂���", "�X���@" };
                mail0(answer, 0);
                break;
            case 1:
                answerText.text = "";
                subject.text = "��i";
                content.text = "��Ђɂ͗����̂��H";
                string[] answer2 = { "�}���ł����܂�", "�܂��S�z�����", "����v�ł�", "�S�z�ł������H" };
                mail0(answer2, 0);
                break;
            case 2:
                answerText.text = "";
                subject.text = "��i";
                content.text = "�������H";
                string[] answer3 = { "�Ȃ�ׂ������s���܂�", "�܂������肻��", "�Ԃɍ����Ԃɍ���!", "24���Ԃ��炢����" };
                mail0(answer3, 0);
                break;
            case 3:
                answerText.text = "";
                subject.text = "��i";
                content.text = "��c����!�}��!";
                string[] answer4 = { "��ΊԂɍ��킹�܂�", "�Ԃɍ���Ȃ�����", "�s����s����", "�}�����`���N" };
                mail0(answer4, 0);
                break;
            case 4:
                answerText.text = "";
                subject.text = "��i";
                content.text = "���̒x�����Ă���񂾁H";
                string[] answer5 = { "�Q�V���Ă��܂���", "�Q�Ă�", "�Q������", "�C�ɂ����畉���ł���" };
                mail0(answer5, 0);
                break;
            case 5:
                answerText.text = "";
                subject.text = "��i";
                content.text = "���������Ǝv���Ă���H";
                string[] answer6 = { "�����Ɍ������܂�", "��ׂ�", "���[...", "�~�X�����[" };
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
        // �I�����ꂽ�{�^���̎擾
        answerButton = answerEvent.currentSelectedGameObject;
        if (answerButton == null)
        {
            Debug.LogError("�I�����ꂽ�{�^��������܂���B");
            return;
        }
        Transform child = answerButton.transform.GetChild(0);

        TextMeshProUGUI buttonText = child.GetComponent<TextMeshProUGUI>();
        
        // ���𔻒�
        if (answers == buttonText.text)
        {
            if(Angry.angry>0)
            {
                Angry.angry -= 0.1f;
            }
            Debug.Log("������");
        }
        else
        {
            Angry.angry+=0.2f;
            Debug.Log("�͂���");
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
