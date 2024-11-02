using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSwitcher : MonoBehaviour
{
    public Text uiText;
    public string[] messages;
    public float switchInterval = 2.0f;
    private int currentIndex = 0;
    private float timer = 0; 
    // Start is called before the first frame update
    void Start()
    {
        if (messages.Length > 0 && uiText != null)
        {
            uiText.text = messages[currentIndex]; // 最初のテキストを設定
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 経過時間を計測
        timer += Time.deltaTime;

        // 指定の切り替え時間を経過したら次のテキストに切り替える
        if (timer >= switchInterval && currentIndex != messages.Length - 1)
        {
            timer = 0.0f; // タイマーをリセット
            currentIndex = (currentIndex + 1) % messages.Length; // 次のインデックスに移動
            uiText.text = messages[currentIndex]; // テキストを更新
        }
    }
}
