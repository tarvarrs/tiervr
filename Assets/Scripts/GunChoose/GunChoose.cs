using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChoose : MonoBehaviour
{
    void Start()
    {
        // Get the list of guns that the player has bought
        List<string> boughtGuns = Buying.dataPlayer.buyItem;

        // Loop through all the gun objects in the scene
        foreach (GameObject gun in Buying.allitem)
        {
            // Get the name of the gun
            string gunName = gun.GetComponent<Item>().nameItem;

            // If the player has bought this gun, show it on the screen
            if (boughtGuns.Contains(gunName))
            {
                Debug.Log("true");
                gun.SetActive(true);
            }
            // Otherwise, hide it and show a "locked" message
            else
            {
                Debug.Log("locked");
                gun.SetActive(false);
                gun.GetComponent<Item>().TextItem.text = "Заблокировано";
            }
        }
    }

    
    public void SelectGun(GameObject gunObject)
    {
        Item gunItem = gunObject.GetComponent<Item>();
        string gunName = gunItem.nameItem;

        // If the player has bought this gun, select it
        if (Buying.dataPlayer.buyItem.Contains(gunName))
        {
            Debug.Log("Selected gun: " + gunName);
            // Add your code here to actually select the gun
        }
        // Otherwise, show a "locked" message
        else
        {
            gunItem.TextItem.text = "Заблокировано";
        }
    }

}
