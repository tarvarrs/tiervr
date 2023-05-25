using TMPro;
using UnityEngine;
public class Scorik1 : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    public void Print(string text)
    {
        scoreText.text = text;
    }
}