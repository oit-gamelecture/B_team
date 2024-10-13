using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public float Score { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // シーンを跨いでオブジェクトを保持
        }
        else
        {
            Destroy(gameObject);  // 既に存在する場合は削除
        }
    }

    public void AddScore(float amount)
    {
        Score += amount;
        Debug.Log("会社まで残り" + Score+"m");
    }

    public void ResetScore()
    {
        Score = 500000;
    }
}
