using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private float levelTime;
    [SerializeField] private Text timerText;

    private float timeLeft;

    private void Start()
    {
        timeLeft = levelTime;
        StartCoroutine(timerCoroutine());
    }

    private void Update()
    {
        if(timeLeft <= 0)
        {
            GameManager.instance.Loose();
        } 
    }

    private IEnumerator timerCoroutine()
    {
        while(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimerText();
            yield return null;
        }
    }

    private void UpdateTimerText()
    {
        if (timeLeft < 0) timeLeft = 0;

        timerText.text = Mathf.Round(timeLeft).ToString();
    }

}
