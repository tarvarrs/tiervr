using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(5);
    }

    public void Shop()
    {
        SceneManager.LoadScene(4);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
