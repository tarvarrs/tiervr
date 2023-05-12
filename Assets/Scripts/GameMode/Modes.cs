using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modes : MonoBehaviour
{
    public void FstMode()
    {
        SceneManager.LoadScene(1);
    }

    public void SndMode()
    {
        SceneManager.LoadScene(2);
    }
    
    public void TrdMode()
    {
        SceneManager.LoadScene(3);
    }

    public void MenuExit()
    {
        SceneManager.LoadScene(0);
    }
    
    
}
