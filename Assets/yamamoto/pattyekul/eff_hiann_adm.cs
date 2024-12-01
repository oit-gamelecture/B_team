using System.Collections;
using UnityEngine;

public class eff_adm : MonoBehaviour
{
    // エフェクトを格納するオブジェクト
    public GameObject effHidann;

    // エフェクトの再生時間（秒）
    public float effectDuration = 0.75f;

    void Start()//初期化
{
    if (effHidann != null)
    {
        effHidann.SetActive(false);
    }
}


    // トリガーイベントが発生したときの処理
    
    private void OnTriggerEnter(Collider other)
    {
        // 特定のタグ[]に反応
        if (other.CompareTag("buckwall"))
        {
            StartCoroutine(PlayEffect());
        }

        if (other.CompareTag("NPCs"))
        {
            StartCoroutine(PlayEffect());
        }
    }

    // エフェクトを再生し、指定時間後に停止するコルーチン
    IEnumerator PlayEffect()
    {
        if (effHidann != null)
        {
            // エフェクトを有効化
            effHidann.SetActive(true);

            // 指定された時間だけ待機
            yield return new WaitForSeconds(effectDuration);

            // エフェクトを無効化
            effHidann.SetActive(false);
        }
    }
}
