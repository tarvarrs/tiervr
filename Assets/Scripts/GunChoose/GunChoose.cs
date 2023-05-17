using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class GunChoose : MonoBehaviour
{
    private int i=0;
    private int currentGun;
    
    public GameObject[] AllGuns;
    
    public GameObject ArrowToLeft;
    public GameObject ArrowToRight;

    public GameObject ButtonSelectGun;
    public GameObject TextSelectGun;

    private void Start()
    {
        if (PlayerPrefs.HasKey("CurrentGun"))
        {
            i = PlayerPrefs.GetInt("CurrentGun");
            currentGun=PlayerPrefs.GetInt("CurrentGun");
        }
        else
        {
            PlayerPrefs.SetInt("CurrentGun",i);
        }
        
        AllGuns[i].SetActive(true);

        ButtonSelectGun.SetActive(false);
        TextSelectGun.SetActive(true);

        if (i > 0)
        {
            ArrowToLeft.SetActive(true);
        }

        if (i + 1 == AllGuns.Length)
        {
            ArrowToRight.SetActive(false);
        }
    }

    public void ArrowRight()
    {
        if (i < AllGuns.Length)
        {
            if (i == 0)
            {
                ArrowToLeft.SetActive(true);
            }

            AllGuns[i].SetActive(false);
            i++;
            AllGuns[i].SetActive(true);

            if (currentGun == i)
            {
                ButtonSelectGun.SetActive(false);
                TextSelectGun.SetActive(true);
                
            }
            else
            {
                ButtonSelectGun.SetActive(true);
                TextSelectGun.SetActive(false);
            }

            if (i + 1 == AllGuns.Length)
            {
                ArrowToRight.SetActive(false);
            }
        }
    }
    
    public void ArrowLeft()
    {
        if (i < AllGuns.Length)
        {
            AllGuns[i].SetActive(false);
            i--;
            AllGuns[i].SetActive(true);
            ArrowToRight.SetActive(true);
            
            if (currentGun == i)
            {
                ButtonSelectGun.SetActive(false);
                TextSelectGun.SetActive(true);
                
            }
            else
            {
                ButtonSelectGun.SetActive(true);
                TextSelectGun.SetActive(false);
            }
            
            if (i == 0)
            {
                ArrowToLeft.SetActive(false);
            }

            
        }
    }

    public void SelectGun()
    {
        PlayerPrefs.SetInt("CurrentGun",i);
        currentGun = i;
        ButtonSelectGun.SetActive(false);
        TextSelectGun.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(8);
    }
}