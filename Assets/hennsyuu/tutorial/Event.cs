using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    private Image ruleimage;
    public Sprite[] rulesprite; // ルール画像の配列
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ruleimage = GetComponent<Image>();
        ruleimage.sprite = rulesprite[0]; // 最初の画像をセット
    }

    // Update is called once per frame
    void Update()
    {
        // どのキーが押されてもTapDownUIを呼び出す
        if (Input.anyKeyDown)
        {
            TapDownUI();
        }
    }

    public void TapDownUI()
    {
        // 次の画像に進む
        if (count < rulesprite.Length - 1) // 最後の画像でない場合
        {
            count++;
            ruleimage.sprite = rulesprite[count];
        }
        else
        {
            // 最後の画像の次はシーン遷移
            SceneManager.LoadScene("Title");
        }
    }
}
