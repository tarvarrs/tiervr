using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Buying ScriptBuying;
    
    //Имя оружия
    public string nameItem;
    //Цена оружия
    public string priceItem;

    public void BuyItem()
    {
        //передаём переменную в Buying
        ScriptBuying.nameItem = nameItem;
        ScriptBuying.priceItem = priceItem;
    }
}
