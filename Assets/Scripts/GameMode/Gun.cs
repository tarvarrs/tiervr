using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private int i;
    public GameObject[] AllGuns;
    void Start()
    {
        i = PlayerPrefs.GetInt("CurrentGun");
        AllGuns[i].SetActive(true);
    }
}
