using System.Collections;
using UnityEngine;

public class eff_adm : MonoBehaviour
{
    // エフェクトを格納するオブジェクト
    public GameObject effHidann;

    // エフェクトの再生時間（秒）
    public float effectDuration = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        // エフェクトを最初は非表示に設定
        if (effHidann != null)
        {
            effHidann.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたときにエフェクトを再生
        if (Input.GetKeyDown(KeyCode.Space))
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
