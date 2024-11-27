using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    private Image ruleimage;
    public Sprite[] rulesprite; // ���[���摜�̔z��
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ruleimage = GetComponent<Image>();
        ruleimage.sprite = rulesprite[0]; // �ŏ��̉摜���Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        // �ǂ̃L�[��������Ă�TapDownUI���Ăяo��
        if (Input.anyKeyDown)
        {
            TapDownUI();
        }
    }

    public void TapDownUI()
    {
        // ���̉摜�ɐi��
        if (count < rulesprite.Length - 1) // �Ō�̉摜�łȂ��ꍇ
        {
            count++;
            ruleimage.sprite = rulesprite[count];
        }
        else
        {
            // �Ō�̉摜�̎��̓V�[���J��
            SceneManager.LoadScene("Title");
        }
    }
}
