using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool timerGoing;
    public float currentTime;
    public TimeSpan elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "01:30.00";
        timerGoing = true;
        currentTime = 90f;
        StartCoroutine(TimerGoingDown());
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentTime <= 0)
        {
            EndTimer();
        }

    }
    public IEnumerator TimerGoingDown()
    {
        while (timerGoing)
        {
            currentTime -= Time.deltaTime;
            elapsedTime = TimeSpan.FromSeconds(currentTime);
            string timeLeftString = elapsedTime.ToString("mm':'ss'.'ff");
            timerText.text = timeLeftString;

            yield return null;
        }
        
    }
    public void EndTimer()
    {
        timerGoing = false;
    }
}