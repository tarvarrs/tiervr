using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuExit : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}