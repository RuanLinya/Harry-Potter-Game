using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer;
    private bool startTiming;
    public Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartTimer);
       
    }

    // Update is called once per frame
    private void Update()
    {
        if (startTiming)
        {

           
            timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
          
        }
      

    }

    private void StartTimer ()
    {
        startTiming = true;
    }

}

