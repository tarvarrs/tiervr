using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timerText;
    
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();

        if (timeStart < 0)
        {
            timeStart = 0;
        }
    }
}
