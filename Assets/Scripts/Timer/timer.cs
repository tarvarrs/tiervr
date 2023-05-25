using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timerText;
    
    void Start()
    {
        timerText.text = timeStart.ToString();
    }ы
    
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();

        if (timeStart < 0)
        {
            PlayerPrefs.SetInt("Score",BulletScript.score);
            timeEnd();
        }
    }
    public void timeEnd()
    {
        SceneManager.LoadScene(6);
    }
}
