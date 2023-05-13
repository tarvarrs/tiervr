using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Results : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public void playAgain()
    {
        SceneManager.LoadScene(7);
    }
    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
