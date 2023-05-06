using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buying : MonoBehaviour
{
    private Buying.DataPlayer dataPlayer = new Buying.DataPlayer();
    public string nameItem;
    public string priceItem;

    public class DataPlayer
    {
        public int money; //Кол-во монет
    }

    private void Start()
    {
        SaveGame();
    }
    
    //Сохранение
    private void SaveGame()
    {
        dataPlayer.money = 500; //Изначальное количество очков монет

        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(dataPlayer));
    }

    //Загрузка
    private void LoadGame()
    {
        dataPlayer = JsonUtility.FromJson<DataPlayer>(PlayerPrefs.GetString("SaveGame"));
    }
    
    
    
}
