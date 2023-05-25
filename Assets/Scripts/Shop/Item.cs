using UnityEngine;
using TMPro;
public class Item : MonoBehaviour
{
    public Buying ScriptBuying;
    public string nameItem;
    public int priceItem;
    public TextMeshProUGUI TextItem;
    public bool isBuy;
    public void BuyItem()
    {
        if (isBuy == false)
        {
            ScriptBuying.nameItem = nameItem;
            ScriptBuying.priceItem = priceItem;
            ScriptBuying.BuyItem();
        }
    }
}