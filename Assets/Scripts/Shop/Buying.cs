using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Buying : MonoBehaviour
{
    public static Buying.DataPlayer dataPlayer = new Buying.DataPlayer();
    [HideInInspector]
    public string nameItem;
    [HideInInspector]
    public int priceItem;
    //public Item _Item;
    public GameObject[] allitem;
    public TextMeshProUGUI moneyText;
    public class DataPlayer
    {
        public List<string> buyItem = new List<string>();
    }
    private void Start()
    {
        //_Item=FindObjectOfType<Item>();
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            LoadGame();
        }
        else
        {
            PlayerPrefs.SetInt("Money", 5000);
            SaveGame();
            LoadGame();
        }
        PlayerPrefs.GetInt("Money");
        moneyText.text = PlayerPrefs.GetInt("Money").ToString();
    }
    private void SaveGame()
    {
        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(dataPlayer));
    }
    private void LoadGame()
    {
        dataPlayer = JsonUtility.FromJson<DataPlayer>(PlayerPrefs.GetString("SaveGame"));

        for (int i = 0; i < dataPlayer.buyItem.Count; i++)
        {
            for (int j = 0; j < allitem.Length; j++)
            {
                if (allitem[j].GetComponent<Item>().nameItem == dataPlayer.buyItem[i])
                {
                    allitem[j].GetComponent<Item>().TextItem.text = "Куплено";
                    allitem[j].GetComponent<Item>().isBuy = true;
                }
            }
        }
    }
    public void BuyItem()
    {
        if (PlayerPrefs.GetInt("Money") >= priceItem)
        {
            dataPlayer.buyItem.Add(nameItem);
            PlayerPrefs.SetInt("Money", (PlayerPrefs.GetInt("Money") - priceItem));
            moneyText.text = PlayerPrefs.GetInt("Money").ToString();
            SaveGame();
            LoadGame();
            //_Item.Print();
        }
    }
}