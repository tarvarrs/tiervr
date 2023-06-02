using UnityEngine;
using TMPro;
public class Item : MonoBehaviour
{
    public Buying ScriptBuying;
    public string nameItem;
    public int priceItem;
    public TextMeshProUGUI TextItem;
    public bool isBuy;
    public int index;
    public void BuyItem()
    {
        if (isBuy == false)
        {
            ScriptBuying.nameItem = nameItem;
            ScriptBuying.priceItem = priceItem;
            ScriptBuying.BuyItem();
        }

        if(isBuy == true)
        {
            PlayerPrefs.SetInt("CurrentGun",index);
            //ScriptBuying.allitem[index].GetComponent<Item>().TextItem.text = "Выбрано";
        }
    }
}