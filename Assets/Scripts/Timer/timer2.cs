using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer2 : MonoBehaviour
{
    public float timeStart = 5;
    public TextMeshProUGUI timerText;
    private int mode = Modes.gamemode;
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
            timeEnd();
        }
    }
    public void timeEnd()
    {
        if (mode == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (mode == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (mode == 3)
        {
            SceneManager.LoadScene(3);
        }
        
    }
}