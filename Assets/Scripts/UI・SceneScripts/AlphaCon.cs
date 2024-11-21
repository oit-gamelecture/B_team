using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaCon : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float minAlpha = 0.3f;
    [SerializeField] private float maxAlpha = 1.0f;
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;

        float alpha = (Mathf.Sin(time) + 1) / 2;

        alpha = Mathf.Lerp(minAlpha, maxAlpha, alpha);
        
        if(canvasGroup != null){
            canvasGroup.alpha = alpha;
        }
    }
}
