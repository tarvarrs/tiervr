using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectedGun : MonoBehaviour
{
    private int i;
    public GameObject[] AllGuns;

    private void Start()
    {
        i = PlayerPrefs.GetInt("CurrentGun");
        AllGuns[i].SetActive(true);
    }
}
