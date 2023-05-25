using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Results : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public void playAgain()
    {
        SceneManager.LoadScene(7);
        PlayerPrefs.SetInt("Money", BulletScript.score + PlayerPrefs.GetInt("Money"));
        BulletScript.score = 0;
    }
    public void toMenu()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("Money", BulletScript.score + PlayerPrefs.GetInt("Money"));
        BulletScript.score = 0;
    }
    private void Start()
    {
        scoreText.text = BulletScript.score.ToString();
    }
}