using UnityEngine;
using UnityEngine.SceneManagement;
public class Modes : MonoBehaviour
{
    public static int gamemode;
    public void FstMode()
    {
        gamemode = 1;
        SceneManager.LoadScene(7);
    }
    public void SndMode()
    {
        gamemode = 2;
        SceneManager.LoadScene(7);
    }
    public void TrdMode()
    {
        gamemode = 3;
        SceneManager.LoadScene(7);
    }
    public void MenuExit()
    {
        SceneManager.LoadScene(0);
    }
}