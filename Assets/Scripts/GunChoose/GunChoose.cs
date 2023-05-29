using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using static Buying;

public class GunChoose : MonoBehaviour
{
    private int i;
    //private int currentGun;
    //public GameObject[] AllGuns;

    public GameObject ButtonSelectGun;

    public GameObject TextSelectGun;
    public GameObject TextSelected;
    public GameObject TextUnavailable;

    private Buying _buying;
    private List<string> _buyItem;
    private GunInChoose ind;
    public GameObject[] AllGuns;

    private void Start()
    {
        _buying=FindObjectOfType<Buying>();

        Debug.Log(_buying);
    }
    /*
     public void GunSelect()
    {
        if (_buyItem.Contains(ind.indexItem))
        {
            Debug.Log("works");
            PlayerPrefs.SetInt("CurrentGun",Convert.ToInt32(ind.indexItem));
        }
        else
        {
            Debug.Log("works");
        }
    }
     */

    /*public void GunSelect()
    {
        if (_buyItem.Contains(AllGuns[i].name))
        {
            Debug.Log("gfthf");
            PlayerPrefs.SetInt("CurrentGun",i);           
        }
    }*/
    public void GunSelect()
    {
        if (_buyItem.Contains(GetComponent<Item>().nameItem))
        {
            PlayerPrefs.SetInt("CurrentGun",i);
            Debug.Log("works1");
        }
        else
        {
            Debug.Log("works2");
        }
    }
}

