using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buying : MonoBehaviour
{
    private Buying.DataPlayer dataPlayer = new Buying.DataPlayer();
    [HideInInspector]
    public string nameItem;
    [HideInInspector]
    public int priceItem;

    public GameObject[] allitem;

    public class DataPlayer
    {
        public int money; //Кол-во монет
        
        public List<string> buyItem = new List<string>(); // 
        
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            LoadGame();
        }
        else
        {
            dataPlayer.money = 50; //Изначальное количество очков монет
            SaveGame();
            LoadGame();
        }        
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
            for(int j = 0; j < allitem.Length; j++)
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
        if(dataPlayer.money >= priceItem)
        {
            dataPlayer.buyItem.Add(nameItem);
            dataPlayer.money = dataPlayer.money - priceItem;

            SaveGame();
            LoadGame();
        }
    }
    
}
