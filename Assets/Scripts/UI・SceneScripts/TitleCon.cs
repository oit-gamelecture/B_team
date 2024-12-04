using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleCon : MonoBehaviour
{
    public GameObject ui;
    CanvasGroup canvasGroup;

    public AudioSource audioSource;
    public AudioClip buttonAudioClip;
    private bool isTransitioning = false;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = ui.GetComponent<CanvasGroup>();
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isTransitioning)
        {
            //SceneManager.LoadScene("Prologue");
            isTransitioning = true;  // シーン遷移が二重に実行されないようにする
            StartCoroutine(PlaySoundAndTransition());
        }
        if (Input.GetKey(KeyCode.Escape) && !isTransitioning)
        {
            //SceneManager.LoadScene("main");
            ScoreManager.Instance.ResetScore();
            isTransitioning = true;  // シーン遷移が二重に実行されないようにする
            StartCoroutine(PlaySoundAndTransitionEnd());
        }
        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && !isTransitioning)
        {
            isTransitioning = true; //シーン遷移が二重に実行されないようにする
            StartCoroutine(PlaySoundAndTransition("Rule"));
        }
    }

    private IEnumerator PlaySoundAndTransition()
    {
        audioSource.PlayOneShot(buttonAudioClip);
        yield return new WaitForSeconds(1f);  // 効果音が鳴り終わるまで待機
        SceneManager.LoadScene("Prologue");
        ScoreManager.Instance.ResetScore();
    }
    private IEnumerator PlaySoundAndTransition(string sceneName)
    {
        audioSource.PlayOneShot(buttonAudioClip);
        yield return new WaitForSeconds(1f);  // 効果音が鳴り終わるまで待機
        SceneManager.LoadScene("Rule");
        ScoreManager.Instance.ResetScore();
    }
    private IEnumerator PlaySoundAndTransitionEnd()
    {
        audioSource.PlayOneShot(buttonAudioClip);
        yield return new WaitForSeconds(1f);  // 効果音が鳴り終わるまで待機
        Application.Quit();
    }
}
