using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    public Buying ScriptBuying;
    
    //Имя оружия
    public string nameItem;
    //Цена оружия
    public int priceItem;

    public TextMeshProUGUI TextItem;

    public bool isBuy;
    
    public void BuyItem()
    {
        //передаём переменную в Buying
        if (isBuy == false)
        {
            ScriptBuying.nameItem = nameItem;
            ScriptBuying.priceItem = priceItem;

            ScriptBuying.BuyItem();
        }
    }
}
