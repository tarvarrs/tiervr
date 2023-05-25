using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buying : MonoBehaviour
{
    public Buying.DataPlayer dataPlayer = new Buying.DataPlayer();
    [HideInInspector]
    public string nameItem;
    [HideInInspector]
    public int priceItem;

    public GameObject[] allitem;
    //public int earnedMoney;
    public TextMeshProUGUI moneyText;
    public class DataPlayer
    {
        //public int money;
        public List<string> buyItem = new List<string>();

    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            PlayerPrefs.SetInt("Money", 50); 
            LoadGame();
        }
        else
        {
            PlayerPrefs.SetInt("Money", 50); //Изначальное количество очков монет
            SaveGame();
            LoadGame();

        }
        //dataPlayer.money = 50;
        //dataPlayer.money = PlayerPrefs.GetInt("Money");
        //earnedMoney = PlayerPrefs.GetInt("earnedMoney");
        //dataPlayer.money += earnedMoney;

        PlayerPrefs.GetInt("Money");
        //earnedMoney = 0;

        //PlayerPrefs.SetInt("Money", dataPlayer.money);
        moneyText.text = PlayerPrefs.GetInt("Money").ToString();
        
    }

    //Сохранение
    private void SaveGame()
    {
        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(dataPlayer));
    }

    //Загрузка
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
            //PlayerPrefs.GetInt("Money") = PlayerPrefs.GetInt("Money") - priceItem;
            PlayerPrefs.SetInt("Money", (PlayerPrefs.GetInt("Money") - priceItem));
            moneyText.text = PlayerPrefs.GetInt("Money").ToString();
            SaveGame();
            LoadGame();
        }
    }
}
