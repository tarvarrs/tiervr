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

    public GameObject TextIsBuyGun;

    public Buying _buying;
    private List<string> _buyItem;

    private void Start()
    {
        _buying = FindObjectOfType<Buying>();
        _buyItem = _buying.dataPlayer.buyItem;
        
        //!!!!!!!!!!!!!!!!!!!!!
        //PlayerPrefs.SetInt("CurrentGun",i);
        AllGuns[i].SetActive(true);
        TextSelectGun.SetActive(false);

        if (_buyItem.Contains(AllGuns[i].name))
        {
            ButtonSelectGun.SetActive(false);
            TextSelectGun.SetActive(true);
        }

        /*
        if (AllGuns[i].gameObject.name ){
            ButtonSelectGun.SetActive(false);
            TextSelectGun.SetActive(true);
        }*/

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

            if (currentGun == i && _buyItem.Contains(AllGuns[i].name))
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
        if (_buyItem.Contains(AllGuns[i].name))
        {
            Debug.Log("ЕСТЬ НАХУЙ ВСЕ РАБОТАЕТ");
            PlayerPrefs.SetInt("CurrentGun",i);
            currentGun = i;
            ButtonSelectGun.SetActive(false);
            TextSelectGun.SetActive(true);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(8);
    }
}