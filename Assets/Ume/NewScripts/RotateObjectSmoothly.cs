using UnityEngine;

public class RotateObjectSmoothly : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // 回転軸 (例: Y軸)
    public float rotationDuration = 1.0f; // 回転にかかる時間（秒）

    private Quaternion targetRotation; // 目標の回転角度
    private Quaternion startRotation; // 開始時の回転角度
    private bool isRotating = false; // 回転中かどうか
    private float rotationTime = 0.0f; // 回転の経過時間

    public float setTimer = 10;
    private float timer = 0;
    private bool isTurn = false;

    void Start()
    {
        targetRotation = transform.rotation; // 初期値を現在の回転に設定
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= setTimer && !isTurn)
        {
            StartRotation();
            isTurn = true;
        }

        // 回転中であれば、回転を補間で更新
        if (isRotating)
        {
            rotationTime += Time.deltaTime;
            float t = rotationTime / rotationDuration;

            // 補間で回転を滑らかに
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, t);

            // 回転が完了したか確認
            if (t >= 1.0f)
            {
                isRotating = false;
                isTurn = false; // 次の回転の準備
                timer = 0; // タイマーリセットで次のサイクルを開始
            }
        }
    }

    // 回転を開始するメソッド
    private void StartRotation()
    {
        isRotating = true;
        rotationTime = 0.0f;
        startRotation = transform.rotation;
        targetRotation = transform.rotation * Quaternion.Euler(rotationAxis * -180); // 180度のみ加算
    }
}
